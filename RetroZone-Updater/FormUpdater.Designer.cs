namespace RetroZone_Updater
{
    partial class FormUpdater
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdater));
            this.pictureBoxRetroZone = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.materialProgressBarDownload = new MaterialSkin.Controls.MaterialProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCurrentVersionNumber = new System.Windows.Forms.Label();
            this.labelNewVersionNumber = new System.Windows.Forms.Label();
            this.labelCurrentVersionTitle = new System.Windows.Forms.Label();
            this.labelNewVersionTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRetroZone
            // 
            this.pictureBoxRetroZone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRetroZone.Image = global::RetroZone_Updater.Properties.Resources.RetroZoneLogo;
            this.pictureBoxRetroZone.Location = new System.Drawing.Point(3, 58);
            this.pictureBoxRetroZone.Name = "pictureBoxRetroZone";
            this.pictureBoxRetroZone.Size = new System.Drawing.Size(600, 300);
            this.pictureBoxRetroZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRetroZone.TabIndex = 1;
            this.pictureBoxRetroZone.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::RetroZone_Updater.Properties.Resources.Duck;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 29);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(22, 23);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(168, 407);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(243, 50);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // materialProgressBarDownload
            // 
            this.materialProgressBarDownload.Depth = 0;
            this.materialProgressBarDownload.Location = new System.Drawing.Point(12, 379);
            this.materialProgressBarDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBarDownload.Name = "materialProgressBarDownload";
            this.materialProgressBarDownload.Size = new System.Drawing.Size(566, 5);
            this.materialProgressBarDownload.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStatus.Location = new System.Drawing.Point(8, 387);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 8;
            // 
            // labelCurrentVersionNumber
            // 
            this.labelCurrentVersionNumber.AutoSize = true;
            this.labelCurrentVersionNumber.ForeColor = System.Drawing.Color.Silver;
            this.labelCurrentVersionNumber.Location = new System.Drawing.Point(253, 465);
            this.labelCurrentVersionNumber.Name = "labelCurrentVersionNumber";
            this.labelCurrentVersionNumber.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentVersionNumber.TabIndex = 4;
            // 
            // labelNewVersionNumber
            // 
            this.labelNewVersionNumber.AutoSize = true;
            this.labelNewVersionNumber.ForeColor = System.Drawing.Color.White;
            this.labelNewVersionNumber.Location = new System.Drawing.Point(253, 478);
            this.labelNewVersionNumber.Name = "labelNewVersionNumber";
            this.labelNewVersionNumber.Size = new System.Drawing.Size(0, 13);
            this.labelNewVersionNumber.TabIndex = 6;
            // 
            // labelCurrentVersionTitle
            // 
            this.labelCurrentVersionTitle.AutoSize = true;
            this.labelCurrentVersionTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCurrentVersionTitle.Location = new System.Drawing.Point(165, 465);
            this.labelCurrentVersionTitle.Name = "labelCurrentVersionTitle";
            this.labelCurrentVersionTitle.Size = new System.Drawing.Size(81, 13);
            this.labelCurrentVersionTitle.TabIndex = 3;
            this.labelCurrentVersionTitle.Text = "Current version:";
            // 
            // labelNewVersionTitle
            // 
            this.labelNewVersionTitle.AutoSize = true;
            this.labelNewVersionTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNewVersionTitle.Location = new System.Drawing.Point(165, 478);
            this.labelNewVersionTitle.Name = "labelNewVersionTitle";
            this.labelNewVersionTitle.Size = new System.Drawing.Size(83, 13);
            this.labelNewVersionTitle.TabIndex = 5;
            this.labelNewVersionTitle.Text = "Newest version:";
            // 
            // FormUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 500);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.materialProgressBarDownload);
            this.Controls.Add(this.labelNewVersionNumber);
            this.Controls.Add(this.labelNewVersionTitle);
            this.Controls.Add(this.labelCurrentVersionNumber);
            this.Controls.Add(this.labelCurrentVersionTitle);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.pictureBoxRetroZone);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(590, 500);
            this.MinimumSize = new System.Drawing.Size(590, 500);
            this.Name = "FormUpdater";
            this.Sizable = false;
            this.Text = "RetroZone - Updater";
            this.TitleEnabled = true;
            this.TitleOffset = 30;
            this.Load += new System.EventHandler(this.FormUpdater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxRetroZone;
        private System.Windows.Forms.Button buttonUpdate;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBarDownload;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCurrentVersionNumber;
        private System.Windows.Forms.Label labelNewVersionNumber;
        private System.Windows.Forms.Label labelCurrentVersionTitle;
        private System.Windows.Forms.Label labelNewVersionTitle;
    }
}

