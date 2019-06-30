using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TNE_v2.Models
{
    public class VoltageTransformerModel
    {
        public VoltageTransformerModel(int voltageTransformerNumber,
           string voltageTransformerType,
           DateTime voltageTransformerDate,
           int voltageTransformerKoeff)
        {
            this.voltageTransformerNumber = voltageTransformerNumber;
            this.voltageTransformerType = voltageTransformerType;
            this.voltageTransformerDate = voltageTransformerDate;
            this.voltageTransformerKoeff = voltageTransformerKoeff;
        }

        public int voltageTransformerNumber { get; set; }
        public string voltageTransformerType { get; set; }
        public DateTime voltageTransformerDate { get; set; }
        public int voltageTransformerKoeff { get; set; }
    }
}