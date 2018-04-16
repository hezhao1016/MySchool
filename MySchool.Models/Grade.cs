using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
  public  class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public Grade(int id,string name)
        {
            this.GradeId = id;
            this.GradeName = name;
        }
        public override string ToString()
        {
            return this.GradeName.ToString();
        }
    }
}
