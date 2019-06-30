using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TNE_v2.Models
{
    public class CurrentTransformerModel
    {
        public CurrentTransformerModel(int currentTransformerNumber,
            string currentTransformerType,
            DateTime currentTransformerDate,
            int currentTransformerKoeff)
        {
            this.currentTransformerNumber = currentTransformerNumber;
            this.currentTransformerType = currentTransformerType;
            this.currentTransformerDate = currentTransformerDate;
            this.currentTransformerKoeff = currentTransformerKoeff;
        }

        public int currentTransformerNumber { get; set; }
        public string currentTransformerType { get; set; }
        public DateTime currentTransformerDate { get; set; }
        public int currentTransformerKoeff { get; set; }
    }
}