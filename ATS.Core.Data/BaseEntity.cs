using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Core.Data
{
    public class BaseEntity
    {

        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsPrivate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditBy { get; set; }
        public DateTime EditOn { get; set; }

    }
}
