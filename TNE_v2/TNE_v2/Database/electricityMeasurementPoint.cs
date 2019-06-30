using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("electricityMeasurementPoint")]
    public class electricityMeasurementPoint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int electricityMeasurementPointId { get; set; }
        public string electricityMeasurementPointName { get; set; }
        public virtual consumptionObject consumptionObject { get; set; }
        public virtual ICollection<meteringDevice> meteringDevice { get; set; }
        public virtual electricEnergyMeter electricEnergyMeter { get; set; }
        public virtual currentTransformer currentTransformer { get; set; }
        public virtual voltageTransformer voltageTransformer { get; set; }
    }
}