using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
    //插入成绩扩展类
  public  class ResultInsert:Result
    {
        public string StudentNo { get; set; }
        public int SubjectNo { get; set; }

        public ResultInsert(string studentNo, int subjectNo, int result, DateTime examDate)
        {
            this.StudentNo = studentNo;
            this.SubjectNo = subjectNo;
            this.StudentResult = result;
            this.ExamDate = examDate;
        }
    }
}
