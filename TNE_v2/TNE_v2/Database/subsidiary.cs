using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("subsidiary")]
    public class subsidiary
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int subsidiaryId { get; set; }
        public string subsidiaryName { get; set; }
        public string subsidiaryAddress { get; set; }
        public virtual organization organization { get; set; }
        public virtual ICollection<consumptionObject> consumptionObject { get; set; }
    }
}