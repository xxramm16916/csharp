using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bootstrap.Models
{
    public class AddEMPModel
    {
        public AddEMPModel(string electricityMeasurementPointName,
            int electricEnergyMeterNumber,
            string electricEnergyMeterType,
            DateTime electricEnergyMeterDate,
            int voltageTransformerNumber, 
            string voltageTransformerType,
            DateTime voltageTransformerDate,
            int voltageTransformerKoeff,
            int currentTransformerNumber,
            string currentTransformerType,
            DateTime currentTransformerDate,
            int currentTransformerKoeff
            )
        {
            this.electricityMeasurementPointName = electricityMeasurementPointName;
            this.electricEnergyMeterNumber = electricEnergyMeterNumber;
            this.electricEnergyMeterType = electricEnergyMeterType;
            this.electricEnergyMeterDate = electricEnergyMeterDate;
            this.voltageTransformerNumber = voltageTransformerNumber;
            this.voltageTransformerType = voltageTransformerType;
            this.voltageTransformerDate = voltageTransformerDate;
            this.voltageTransformerKoeff = voltageTransformerKoeff;
            this.currentTransformerNumber = currentTransformerNumber;
            this.currentTransformerType = currentTransformerType;
            this.currentTransformerDate = currentTransformerDate;
            this.currentTransformerKoeff = currentTransformerKoeff;
    }
        [Display(Name = "electricityMeasurementPointName")]
        public string electricityMeasurementPointName { get; set; }
        [Display(Name = "electricEnergyMeterNumber")]
        public int electricEnergyMeterNumber { get; set; }
        [Display(Name = "electricEnergyMeterType")]
        public string electricEnergyMeterType { get; set; }
        [Display(Name = "electricEnergyMeterDate")]
        public DateTime electricEnergyMeterDate { get; set; }
        [Display(Name = "voltageTransformerNumber")]
        public int voltageTransformerNumber { get; set; }
        [Display(Name = "voltageTransformerType")]
        public string voltageTransformerType { get; set; }
        [Display(Name = "voltageTransformerDate")]
        public DateTime voltageTransformerDate { get; set; }
        [Display(Name = "voltageTransformerKoeff")]
        public int voltageTransformerKoeff { get; set; }
        [Display(Name = "currentTransformerNumber")]
        public int currentTransformerNumber { get; set; }
        [Display(Name = "currentTransformerType")]
        public string currentTransformerType { get; set; }
        [Display(Name = "currentTransformerDate")]
        public DateTime currentTransformerDate { get; set; }
        [Display(Name = "currentTransformerKoeff")]
        public int currentTransformerKoeff { get; set; }
    }
}