using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate.EntityFrameworkSqlite
{
    public class Answer
    {
        [Key]
        public int? AnswerId { get; set; }
        public string? QuestionText { get; set; }
        public string? AnswerA { get; set; }
        public string? AnswerB { get; set; }
        public string? AnswerC { get; set; }
        public string? AnswerD { get; set; }
        public string? RightAnswer { get; set; }

        //------------------------------------
        public int? QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
