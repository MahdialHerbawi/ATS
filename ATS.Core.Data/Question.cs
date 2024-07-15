using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Core.Data
{
    public class Question:BaseEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCheckbox{ get; set; }
        public int Mark{ get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
