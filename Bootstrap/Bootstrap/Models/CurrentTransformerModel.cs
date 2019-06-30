using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bootstrap.Models
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