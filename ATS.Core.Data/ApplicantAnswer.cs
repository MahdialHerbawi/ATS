using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Core.Data
{
    public class ApplicantAnswer:BaseEntity
    {
        public int Id { get; set; }
        public int ApplicantExamId { get; set; }
        public int ApplicantId { get; set; }
        public int AnswerId { get; set; }
    }
}
