using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bootstrap.Models
{
    public class ElectricEnergyMeterModel
    {
        public ElectricEnergyMeterModel(int electricEnergyMeterNumber, string electricEnergyMeterType, DateTime electricEnergyMeterDate)
        {
            this.electricEnergyMeterNumber = electricEnergyMeterNumber;
            this.electricEnergyMeterType = electricEnergyMeterType;
            this.electricEnergyMeterDate = electricEnergyMeterDate;
        }
        [Display(Name = "electricEnergyMeterNumber")]
        public int electricEnergyMeterNumber { get; set; }
        [Display(Name = "electricEnergyMeterType")]
        public string electricEnergyMeterType { get; set; }
        [Display(Name = "electricEnergyMeterDate")]
        public DateTime electricEnergyMeterDate { get; set; }
    }
}