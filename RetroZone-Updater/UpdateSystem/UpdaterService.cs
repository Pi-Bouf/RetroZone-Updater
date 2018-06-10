using Ionic.Zip;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace RetroZone_Updater.UpdateSystem
{
    class UpdaterService
    {
        // UI
        private Label labelStatus;
        private Label currentVersionNumber;
        private Label newVersionNumber;
        private MaterialProgressBar materialProgressBar;
        private Button mainButton;

        // Versions & Updates
        private RetroZoneVersion retroZoneVersion = null;
        private List<Update> updates = null;

        // Step
        private string updateState = "";

        public UpdaterService(Label labelStatus, MaterialProgressBar materialProgressBar, Button mainButton, Label currentVersionNumber, Label newVersionNumber)
        {
            this.labelStatus = labelStatus;
            this.materialProgressBar = materialProgressBar;
            this.mainButton = mainButton;
            this.currentVersionNumber = currentVersionNumber;
            this.newVersionNumber = newVersionNumber;
        }

        #region PrimitiveCheck
        public async void PrimitiveCheck()
        {
            // EXE version
            this.changeStatusText("Checking versions...");
            this.retroZoneVersion = RetroZoneVersion.GetFromExe();
            this.currentVersionNumber.Text = this.retroZoneVersion.value;
            

            // Updates available
            this.updates = await Update.GetFromApi(retroZoneVersion);
            if(this.updates == null)
            {
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            if(this.retroZoneVersion.value == "NEW")
            {
                this.newVersionNumber.Text = this.updates[0].versionNumber;
            } else
            {
                this.newVersionNumber.Text = (updates.Count > 1) ? this.updates[0].versionNumber : this.updates[1].versionNumber;
            }
            
            if(this.newVersionNumber.Text != this.currentVersionNumber.Text)
            {
                this.mainButton.Text = (retroZoneVersion.value == "NEW") ? "Install" : "Update";
                this.mainButton.Enabled = true;
                this.mainButton.Click += mainButtonClick;
                this.updateState = "ready";
                this.changeStatusText("Ready !");
            } else
            {
                this.mainButton.Text = "Start RetroZone !";
                this.changeStatusText("No updates available...");
                this.updateState = "updated";
            }
        }
        #endregion

        #region Update
        private void DoOneUpdate()
        {
            if(this.updates.Count > 0)
            {
                this.updateState = "updating";
                this.changeStatusText("Downloading " + this.updates[0].versionNumber + "...");
                UpdateDownloader.Download(this.updates[0], this.onDownloadProgressChange, this.onDownloadComplete);
            } else
            {
                this.updateState = "updated";
                this.changeStatusText("Finish !");
                this.mainButton.Text = "Start RetroZone !";
                this.retroZoneVersion = RetroZoneVersion.GetFromExe();
                this.currentVersionNumber.Text = this.retroZoneVersion.value;
            }
        }

        private void onDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            this.changeStatusText("Extracting...");
            UpdateExtractor.ExtractZip("Update.zip");
            this.updates.RemoveAt(0);
            this.DoOneUpdate();
        }
        #endregion

        #region Changing UI
        private async void mainButtonClick(object sender, EventArgs e)
        {
            switch (this.updateState)
            {
                case "updated":
                    RetroZoneExecutable.Launch();
                    break;
                case "ready":
                    RetroZoneExecutable.Close();
                    this.DoOneUpdate();
                    break;
            }
        }

        private void onDownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            this.changeProgressbarValue(e.ProgressPercentage);
        }

        private void changeStatusText(string text)
        {
            this.labelStatus.Invoke((MethodInvoker)(() => this.labelStatus.Text = text));
        }

        private void changeProgressbarValue(int value)
        {
            this.materialProgressBar.Invoke((MethodInvoker)(() => this.materialProgressBar.Value = value));
        }

        private void changeTextButton(string text)
        {
            this.mainButton.Invoke((MethodInvoker)(() => this.mainButton.Text = text));
        }
        #endregion
    }
}
