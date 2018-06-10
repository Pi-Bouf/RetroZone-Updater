using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroZone_Updater.UpdateSystem
{
    [JsonObject]
    public class Update
    {

        public static string API_URL = "http://retrozone.pierreb.tk";

        [JsonProperty(PropertyName = "authorized")]
        public bool authorized { get; set; }
        [JsonProperty(PropertyName = "versionNumber")]
        public string versionNumber { get; set; }
        [JsonProperty(PropertyName = "link")]
        public string link { get; set; }

        public static async Task<List<Update>> GetFromApi(RetroZoneVersion retroZoneVersion)
        {
            IRestClient client = new RestClient(API_URL);
            IRestRequest request = new RestRequest("api/check_update", Method.GET);
            request.AddHeader("API-VERSION", retroZoneVersion.value);
            IRestResponse response = await client.ExecuteTaskAsync(request);

            if (response.ErrorException != null)
            {
                MessageBox.Show("We are sorry, RetroZone server can't be contacted... Check your network ! \n\nVisit retrozone.net for more help !");
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<List<Update>>(response.Content);
            }
            catch
            {
                return null;
            }
        }
    }
}
