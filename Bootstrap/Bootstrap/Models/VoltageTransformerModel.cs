using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bootstrap.Models
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

        [Display(Name = "voltageTransformerNumber")]
        public int voltageTransformerNumber { get; set; }
        [Display(Name = "voltageTransformerType")]
        public string voltageTransformerType { get; set; }
        [Display(Name = "voltageTransformerDate")]
        public DateTime voltageTransformerDate { get; set; }
        [Display(Name = "voltageTransformerKoeff")]
        public int voltageTransformerKoeff { get; set; }
    }
}