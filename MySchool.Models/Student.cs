using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
  public  class Student
    {
        public string StudentNo { get; set; }
        public string LoginPwd { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public Grade Grade { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BornDate { get; set; }
        public string Email { get; set; }

        public Student(string studentNo,string studentName,string gender,DateTime bornDate)
        {
            this.StudentNo = studentNo;
            this.StudentName = studentName;
            this.Gender = gender;
            this.BornDate = bornDate;
        }
        public Student(string studentNo,string loginPwd, string studentName, string gender,Grade grade,string phone,string address, DateTime bornDate,string email)
        {
            this.StudentNo = studentNo;
            this.LoginPwd = loginPwd;
            this.StudentName = studentName;
            this.Gender = gender;
            this.Grade = grade;
            this.Phone = phone;
            this.Address = address;
            this.Email = email;
            this.BornDate = bornDate;
        }
        public Student(string stuName)
        {
            this.StudentName = stuName;
        }

        public override string ToString()
        {
            return this.StudentName.ToString();
        }
        
    }
}
