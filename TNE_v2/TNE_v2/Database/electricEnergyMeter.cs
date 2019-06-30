using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{ 
    [Table("electricEnergyMeter")]
    public class electricEnergyMeter
    {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public int electricEnergyMeterId { get; set; }
    public int electricEnergyMeterNumber { get; set; }
    public string electricEnergyMeterType { get; set; }
    public DateTime electricEnergyMeterDate { get; set; }
    //public virtual electricityMeasurementPoint electricityMeasurementPoint { get; set; }
}
}