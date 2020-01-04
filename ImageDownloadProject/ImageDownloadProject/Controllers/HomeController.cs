using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ImageDownloadProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly string fileType = "image/jpg";

        public IActionResult Index()
        {          
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> DownloadImage(string url)
        {
            byte[] file = null;
            using (var client = new HttpClient())
            {

                using (var result = await client.GetAsync(url))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        file = await result.Content.ReadAsByteArrayAsync();
                    }

                }
            }
            return File(file, fileType);
        }
    }
}