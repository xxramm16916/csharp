using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("electricitySupplyPoint")]
    public class electricitySupplyPoint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int electricitySupplyPointId { get; set; }
        public string electricitySupplyPointName { get; set; }
        public string electricitySupplyPointPower { get; set; }
        public virtual consumptionObject consumptionObject { get; set; }
    }
}