using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
    //查询成绩扩展类
   public class ResultSeach:Result
    {
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public ResultSeach(string stuName, string subName, int result, DateTime examDate)
        {
            this.StudentName = stuName;
            this.SubjectName = subName;
            this.StudentResult = result;
            this.ExamDate = examDate;
        }
    }
}
