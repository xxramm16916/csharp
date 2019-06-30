using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using TNE_v2.Database;
using TNE_v2.Models;
using TNE_v2.Service;

namespace TNE_v2.Controllers
{
    public class WorkController : ApiController
    {
        private Service.Service eMPService;

        public WorkController()
        {
            eMPService = new Service.Service();
        }

        [Route("{consumptionObject}/addEMP")]
        [HttpPost]
        [System.Web.Http.Description.ResponseType(typeof(electricityMeasurementPoint))]
        public IHttpActionResult AddEMP([FromUri] string consumptionObject, [FromBody] JObject addEMPModel)
        {
            try
            {
                if (addEMPModel == null)
                {
                    return BadRequest("Body isn't JSON");
                }
                var empModel = addEMPModel.ToObject<AddEMPModel>();
                var cons = eMPService.ConsumptionObjectByName(consumptionObject);
                if (cons != null)
                {
                    var newEMp = eMPService.AddEMP(cons, empModel);
                    return Ok(newEMp);
                }
                else
                {
                    return NotFound();
                }
            } catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                return BadRequest("Format error");
            }

        }

        [Route("allMeteringDevices/{year}")]
        [HttpGet]
        [System.Web.Http.Description.ResponseType(typeof(List<MeteringDeviceModel>))]
        public IHttpActionResult getAllMD([FromUri] string year)
        {

            try
            {
                return Ok(eMPService.GetmeteringDevice(Int32.Parse(year)));
            } catch (FormatException)
            {
                return BadRequest("Format error");
            }
        }

        [Route("overdueEnergyMeters/{consumptionObjectName}")]
        [HttpGet]
        [System.Web.Http.Description.ResponseType(typeof(ElectricEnergyMeterModel))]
        public IHttpActionResult getOverdueEnergyMeters([FromUri] string consumptionObjectName)
        {

            try
            {
                return Ok(eMPService.getOverdueEnergyMeters(consumptionObjectName));
            }
            catch (FormatException)
            {
                return BadRequest("Format error");
            }
        }

        [Route("overdueVoltageTransformers/{consumptionObjectName}")]
        [HttpGet]
        [System.Web.Http.Description.ResponseType(typeof(VoltageTransformerModel))]
        public IHttpActionResult getOverdueVoltageTransformers([FromUri] string consumptionObjectName)
        {

            try
            {
                return Ok(eMPService.getOverdueVoltageTransformers(consumptionObjectName));
            }
            catch (FormatException)
            {
                return BadRequest("Format error");
            }
        }

        [Route("overdueCurrentTransformers/{consumptionObjectName}")]
        [HttpGet]
        [System.Web.Http.Description.ResponseType(typeof(CurrentTransformerModel))]
        public IHttpActionResult getOverdueCurrentTransformers([FromUri] string consumptionObjectName)
        {

            try
            {
                return Ok(eMPService.getOverdueCurrentTransformers(consumptionObjectName));
            }
            catch (FormatException)
            {
                return BadRequest("Format error");
            }
        }


    }
}
