using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RetroZone_Updater.UpdateSystem
{
    class UpdateDownloader
    {
        public static void Download(Update update, DownloadProgressChangedEventHandler progressEvent, AsyncCompletedEventHandler completeEvent)
        {
            WebClient webclient = new WebClient();
            webclient.DownloadProgressChanged += progressEvent;
            webclient.DownloadFileCompleted += completeEvent;
            webclient.DownloadFileAsync(new Uri(update.link), "Update.zip");
        }
    }
}
