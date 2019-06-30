using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using Bootstrap.Models;

namespace Bootstrap.Handlers
{
    public class AddEMP
    {

        
        public bool GetAddEMP(AddEMPModel model, string consObj)
        {
            try
            {
                AddEMPPost(model, consObj);
                return false;
            }
            catch (System.Net.WebException)
            {
                return true;
            }
        }

        private void AddEMPPost(AddEMPModel model, string consObj)
        {

            WebRequest request = WebRequest.Create("https://localhost:44326/" + consObj + "/addEMP/");
            request.Method = "POST";

            AddEMPModel model1 = model;

            var json = new JavaScriptSerializer().Serialize(model);

            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();

            using (dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
            }

            response.Close();
        }
    }
}