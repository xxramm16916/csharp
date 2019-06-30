using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("currentTransformer")]
    public class currentTransformer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int currentTransformerId { get; set; }
        public int currentTransformerNumber { get; set; }
        public string currentTransformerType { get; set; }
        public DateTime currentTransformerDate { get; set; }
        public int currentTransformerKoeff { get; set; }
        //public virtual electricityMeasurementPoint electricityMeasurementPoint { get; set; }
    }
}