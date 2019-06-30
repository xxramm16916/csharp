using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TNE_v2.Models
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
        public int meteringDeviceId { get; set; }
        public DateTime meteringDeviceDateRegistration { get; set; }
        public DateTime meteringDeviceDateRemoval { get; set; }
    }
}