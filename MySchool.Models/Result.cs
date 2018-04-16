using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
   public class Result
    {
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public int StudentResult { get; set; }
        public DateTime ExamDate { get; set; }

       public Result(Student stu,Subject sub,int stuResult,DateTime examDate)
       {
           this.Student = stu;
           this.StudentResult = stuResult;
           this.Subject = sub;
           this.ExamDate = examDate;
       }
       public Result()
       { 
            
       }
    }
}
