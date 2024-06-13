using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Entities
{
    public enum Status
    {
        [Description("Active")]
        Verified,

        [Description("Inactive")]
        Inactive,

        [Description("Pending")]
        InProgress

        //Verified,
        //Inactive,
        //InProgress
    }
}
