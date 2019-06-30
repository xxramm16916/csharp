using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.Controllers;
using Bootstrap.Models;
using Newtonsoft.Json;

namespace Bootstrap.Handlers
{
    public class CurrentTransformers
    {
        public List<CurrentTransformerModel> getCurrentTransformers(string cons)
        {
            try
            {
                string json = GetOverdueCurrentTransformers(cons);
                List<CurrentTransformerModel> CurrentTransformers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CurrentTransformerModel>>(json);
                return CurrentTransformers;
            }
            catch (System.Net.WebException)
            {
                return new List<CurrentTransformerModel>();
            }
        }

        private string GetOverdueCurrentTransformers(string cons)
        {
            string Url = "https://localhost:44326/overdueCurrentTransformers/" + cons + "/";
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