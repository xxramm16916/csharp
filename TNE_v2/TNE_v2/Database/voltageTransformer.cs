using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("voltageTransformer")]
    public class voltageTransformer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int voltageTransformerId { get; set; }
        public int voltageTransformerNumber { get; set; }
        public string voltageTransformerType { get; set; }
        public DateTime voltageTransformerDate { get; set; }
        public int voltageTransformerKoeff { get; set; }
        //public virtual electricityMeasurementPoint electricityMeasurementPoint { get; set; }
    }
}