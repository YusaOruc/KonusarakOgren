using EntityLayer.Concreate.EntityFrameworkSqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.MyContexts
{
    class SqliteContext:DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Question> Questions { get; set; }
        public object Admin { get; internal set; }

        //SQLitePCL.raw.SetProvider().
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\SqliteDb\CreateQuiz.db");
            
        
    }
}
