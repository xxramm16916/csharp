using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.Models;

namespace Bootstrap.Handlers
{
    public class ElectricEnergyMeters
    {
        public List<ElectricEnergyMeterModel> GetElectricEnergyMeters(string cons)
        {
            try
            {
                string json = GetOverdueElectricEnergyMeters(cons);
                List<ElectricEnergyMeterModel> ElectricEnergyMeters = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ElectricEnergyMeterModel>>(json);
                return ElectricEnergyMeters;
            }
            catch (System.Net.WebException)
            {
                return new List<ElectricEnergyMeterModel>();
            }
        }
        private string GetOverdueElectricEnergyMeters(string cons)
        {
            string Url = "https://localhost:44326/overdueEnergyMeters/" + cons + "/";
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