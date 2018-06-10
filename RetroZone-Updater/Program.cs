using System;
using System.Windows.Forms;

namespace RetroZone_Updater
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            if(args.Length > 0)
            {
                for(int i = 0; i < args.Length; i++)
                {
                    switch(args[0])
                    {
                        case "--api-url":
                            {
                                UpdateSystem.Update.API_URL = args[1];
                                break;
                            }
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormUpdater());
        }
    }
}
