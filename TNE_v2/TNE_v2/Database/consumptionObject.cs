using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("consumptionObject")]
    public class consumptionObject
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int consumptionObjectId { get; set; }
        public string consumptionObjectName { get; set; }
        public string consumptionObjectAddress { get; set; }
        public virtual subsidiary subsidiary { get; set; }
        public virtual ICollection<electricitySupplyPoint> electricitySupplyPoint { get; set; }
        public virtual ICollection<electricityMeasurementPoint> electricityMeasurementPoint { get; set; }
    }
}