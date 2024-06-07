using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedCloud.Domain.Common;

namespace RedCloud.Domain.Entities
{
    public class Rate : AuditableEntity
    {
        [Key]
        public int RateId { get; set; }

        public string ResellerName { get; set; }

        [ForeignKey("ResellerAdminUser")]
        public int ResellerAdminUserId { get; set; }

        public ResellerAdminUser ResellerAdminUser { get; set; }


        [Required]
        public string Type { get; set; } = "Postpaid/Unlimited"; 

        public int InboundSMS { get; set; }
        public int OutboundSMS { get; set; }
        public int InboundMMS { get; set; }
        public int OutboundMMS { get; set; }
        public int MonthlyNumber { get; set; }
        public int Users { get; set; }


    }
}
