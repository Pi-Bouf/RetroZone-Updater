using MaterialSkin;
using MaterialSkin.Controls;
using RetroZone_Updater.UpdateSystem;
using System;
using System.Reflection;

namespace RetroZone_Updater
{
    public partial class FormUpdater : MaterialForm
    {

        public FormUpdater()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(Assembly.GetExecutingAssembly().GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();
        }

        private void FormUpdater_Load(object sender, System.EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(MaterialSkin.Primary.Purple300, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green100, Accent.Blue200, TextShade.WHITE);

            UpdaterService updaterService = new UpdaterService(labelStatus, materialProgressBarDownload, buttonUpdate, labelCurrentVersionNumber, labelNewVersionNumber);
            updaterService.PrimitiveCheck();
        }
    }
}
