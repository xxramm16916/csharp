using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("meteringDevice")]
    public class meteringDevice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int meteringDeviceId { get; set; }
        public DateTime meteringDeviceDateRegistration { get; set; }
        public DateTime meteringDeviceDateRemoval { get; set; }
        public virtual ICollection<electricityMeasurementPoint> electricityMeasurementPoint { get; set; }
    }
}