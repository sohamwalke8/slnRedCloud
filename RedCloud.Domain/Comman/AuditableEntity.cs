using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Comman
{
    public class AuditableEntity
    {
        public int? CreatedBy { get; set; }//c.n
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int? LastModifiedBy { get; set; }//c.n
        public DateTime? ModifiedDate { get; set; }

        public bool? IsDeleted { get; set; } = false; 
    }
}
