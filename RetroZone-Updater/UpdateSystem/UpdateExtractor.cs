using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroZone_Updater.UpdateSystem
{
    class UpdateExtractor
    {
        public static void ExtractZip(string zipName)
        {
            using (ZipFile zip = ZipFile.Read(zipName))
            {
                foreach (ZipEntry e in zip)
                {
                    e.Extract(ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }
    }
}
