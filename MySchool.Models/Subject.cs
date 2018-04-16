using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
  public  class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int ClassHour { get; set; }
        public Grade Grade { get; set; }

        public Subject(int subId, string subName, int classHour, Grade grade)
        {
            this.SubjectId = subId;
            this.SubjectName = subName;
            this.ClassHour = classHour;
            this.Grade = grade;
        }
        public Subject(string SubName)
        {
            this.SubjectName = SubName;
        }

        public override string ToString()
        {
            return this.SubjectName.ToString();
        }
        
    }
}
