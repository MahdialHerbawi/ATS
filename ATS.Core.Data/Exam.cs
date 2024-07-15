using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Core.Data
{
    public class Exam:BaseEntity
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public LookupItem Position { get; set; }
        public int ExperienceId { get; set; }
        public LookupItem Experience { get; set; }

    }
}
