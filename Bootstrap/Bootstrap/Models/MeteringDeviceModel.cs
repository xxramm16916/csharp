using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bootstrap.Models
{
    public class MeteringDeviceModel
    {
        public MeteringDeviceModel(int meteringDeviceId,
            DateTime meteringDeviceDateRegistration,
            DateTime meteringDeviceDateRemoval)
        {
            this.meteringDeviceId = meteringDeviceId;
            this.meteringDeviceDateRegistration = meteringDeviceDateRegistration;
            this.meteringDeviceDateRemoval = meteringDeviceDateRemoval;
        }
        [Display(Name = "meteringDeviceId")]
        public int meteringDeviceId { get; set; }
        [Display(Name = "meteringDeviceDateRegistration")]
        public DateTime meteringDeviceDateRegistration { get; set; }
        [Display(Name = "meteringDeviceDateRemoval")]
        public DateTime meteringDeviceDateRemoval { get; set; }
    }
}