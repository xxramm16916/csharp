using Bootstrap.Handlers;
using Bootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class TNEController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetCurrentTransformerModel([System.Web.Http.FromBody] string consObj)
        {
            CurrentTransformers current = new CurrentTransformers();
            return View(current.getCurrentTransformers(consObj));
        }

        [HttpPost]
        public ActionResult GetElectricEnergyMeterModel([System.Web.Http.FromBody] string consObj)
        {
            ElectricEnergyMeters meters = new ElectricEnergyMeters();
            return View(meters.GetElectricEnergyMeters(consObj));
        }

        [HttpPost]
        public ActionResult GetVoltageTransformerModel([System.Web.Http.FromBody] string consObj)
        {
            VoltageTransformers vts = new VoltageTransformers();
            return View(vts.GetVoltageTransformers(consObj));
        }

        [HttpPost]
        public ActionResult GetMeteringDeviceModel([System.Web.Http.FromBody] string year)
        {
            MeteringDevices vts = new MeteringDevices();
            return View(vts.GetMeteringDevices(year));
        }

        [HttpPost]
        public ActionResult GetAddEMPModel([System.Web.Http.FromBody] string consObj, [System.Web.Http.FromBody] string electricityMeasurementPointName,
            [System.Web.Http.FromBody] int electricEnergyMeterNumber, [System.Web.Http.FromBody] string electricEnergyMeterType, [System.Web.Http.FromBody] DateTime electricEnergyMeterDate,
            [System.Web.Http.FromBody] int voltageTransformerNumber, [System.Web.Http.FromBody] string voltageTransformerType, [System.Web.Http.FromBody] DateTime voltageTransformerDate,
            [System.Web.Http.FromBody] int voltageTransformerKoeff, [System.Web.Http.FromBody] int currentTransformerNumber, [System.Web.Http.FromBody] string currentTransformerType,
            [System.Web.Http.FromBody] DateTime currentTransformerDate, [System.Web.Http.FromBody] int currentTransformerKoeff)
        {
                    
            AddEMPModel model = new AddEMPModel(electricityMeasurementPointName, electricEnergyMeterNumber, electricEnergyMeterType,
            electricEnergyMeterDate, voltageTransformerNumber, voltageTransformerType, voltageTransformerDate, voltageTransformerKoeff,
            currentTransformerNumber, currentTransformerType, currentTransformerDate, currentTransformerKoeff );

            AddEMP add = new AddEMP();
            bool error = add.GetAddEMP(model, consObj);        
            
            if (error == false)
            {
                ViewBag.Error = "Done";
            }
            else
            {
                ViewBag.Error = "Error";
            }
            return View();
        }
    }
}
