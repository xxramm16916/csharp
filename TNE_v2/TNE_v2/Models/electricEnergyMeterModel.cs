using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TNE_v2.Models
{
    public class ElectricEnergyMeterModel
    {
        public ElectricEnergyMeterModel(int electricEnergyMeterNumber, string electricEnergyMeterType, DateTime electricEnergyMeterDate)
        {
            this.electricEnergyMeterNumber = electricEnergyMeterNumber;
            this.electricEnergyMeterType = electricEnergyMeterType;
            this.electricEnergyMeterDate = electricEnergyMeterDate;
        } 
        public int electricEnergyMeterNumber { get; set; }
        public string electricEnergyMeterType { get; set; }
        public DateTime electricEnergyMeterDate { get; set; }

    }
}