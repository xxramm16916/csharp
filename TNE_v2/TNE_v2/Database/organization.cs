using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNE_v2.Database
{
    [Table("organization")]
    public class organization
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int organizationId { get; set; }
        public string organizationName { get; set; }
        public string organizationAddress { get; set; }
        public virtual ICollection<subsidiary> subsidary { get; set; }
    }
}