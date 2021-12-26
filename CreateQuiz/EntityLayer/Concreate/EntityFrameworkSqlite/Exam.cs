using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFrameworkSqlite
{
    public class Exam
    {
        [Key]
        public int ExamID { get; set; }
        public DateTime Date { get; set; }
        public int? QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
