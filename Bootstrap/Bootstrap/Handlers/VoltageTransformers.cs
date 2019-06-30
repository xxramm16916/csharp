using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.Models;

namespace Bootstrap.Handlers
{
    public class VoltageTransformers
    {
        public List<VoltageTransformerModel> GetVoltageTransformers(string cons)
        {
            try
            {
                string json = GetOverdueVoltageTransformers(cons);
                List<VoltageTransformerModel> VoltageTransformers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<VoltageTransformerModel>>(json);
                return VoltageTransformers;
            }
            catch (System.Net.WebException)
            {
                return new List<VoltageTransformerModel>();
            }
        }
        private string GetOverdueVoltageTransformers(string cons)
        {
            string Url = "https://localhost:44326/overdueVoltageTransformers/" + cons + "/";
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