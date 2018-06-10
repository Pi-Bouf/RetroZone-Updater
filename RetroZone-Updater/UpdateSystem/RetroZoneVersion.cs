using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroZone_Updater.UpdateSystem
{
    public class RetroZoneVersion
    {
        public string value { get; set; }

        public RetroZoneVersion(string value)
        {
            this.value = value;
        }

        public static RetroZoneVersion GetFromExe()
        {
            if (File.Exists("RetroZone.exe"))
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "RetroZone.exe";
                p.StartInfo.Arguments = "--version";
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();

                return new RetroZoneVersion(output);
            }
            else
            {
                return new RetroZoneVersion("NEW");
            }
        }
    }
}
