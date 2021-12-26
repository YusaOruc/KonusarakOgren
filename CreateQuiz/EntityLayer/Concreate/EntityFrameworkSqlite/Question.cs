using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFrameworkSqlite
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string QuizQuestion { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
