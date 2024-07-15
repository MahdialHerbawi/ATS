using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Core.Data
{
    public class ApplicantExam:BaseEntity
    {
        public int Id { get; set; }
        public DateTime Appointment { get; set; }
        public bool IsApplied { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
    }
}
