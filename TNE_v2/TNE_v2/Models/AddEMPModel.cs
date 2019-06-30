using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TNE_v2.Models
{
    public class AddEMPModel
    {
        public string electricityMeasurementPointName { get; set; }
        public int electricEnergyMeterNumber { get; set; }
        public string electricEnergyMeterType { get; set; }
        public DateTime electricEnergyMeterDate { get; set; }
        public int voltageTransformerNumber { get; set; }
        public string voltageTransformerType { get; set; }
        public DateTime voltageTransformerDate { get; set; }
        public int voltageTransformerKoeff { get; set; }
        public int currentTransformerNumber { get; set; }
        public string currentTransformerType { get; set; }
        public DateTime currentTransformerDate { get; set; }
        public int currentTransformerKoeff { get; set; }

    }
}