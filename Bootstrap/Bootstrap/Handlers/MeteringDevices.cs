using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.Models;

namespace Bootstrap.Handlers
{
    public class MeteringDevices
    {
        public List<MeteringDeviceModel> GetMeteringDevices(string year)
        {
            try
            {
                string json = GetAllMeteringDevices(year);
                List<MeteringDeviceModel> MeteringDevices = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MeteringDeviceModel>>(json);
                return MeteringDevices;
            }
            catch (System.Net.WebException)
            {
                return new List<MeteringDeviceModel>();
            }
        }
        private string GetAllMeteringDevices(string year)
        {
            string Url = "https://localhost:44326/allMeteringDevices/" + year + "/";
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
            {
                string Out = sr.ReadToEnd();
                return Out;
            }
        }
    }
}