using System.Diagnostics;
using System.IO;

namespace RetroZone_Updater.UpdateSystem
{
    class RetroZoneExecutable
    {
        public static void Launch()
        {
            if(File.Exists("RetroZone.exe"))
            {
                Process.Start("RetroZone.exe");
            }
        }

        public static void Close()
        {
            Process[] procs = null;
            try
            {
                procs = Process.GetProcessesByName("RetroZone");
                if (procs.Length > 0)
                {
                    Process retrozone = procs[0];
                    if (!retrozone.HasExited)
                    {
                        retrozone.Kill();
                    }
                }
            }
            finally
            {
                if (procs != null)
                {
                    foreach (Process p in procs)
                    {
                        p.Dispose();
                    }
                }
            }
        }
    }
}
