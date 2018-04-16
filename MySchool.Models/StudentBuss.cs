using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
    //学生实体类派生类
   public class StudentBuss:Student
    {
        public string GradeName { get; set; }

        public StudentBuss(string no, string pwd, string name, string gender, Grade grade,
            string phone, string address, DateTime borndate, string email)
            : base(no, pwd, name, gender, grade, phone, address, borndate, email)
        {
            this.GradeName = grade.GradeName;
        }
    }
}
