using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Core.Data
{
    public class LookupItem : BaseEntity
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int Code { get; set; }
        public LookupCategory Category { get; set; }
    }
}
