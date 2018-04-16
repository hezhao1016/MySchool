using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
    public class Admin
    {
        public string  LoginId { get; set; }
        public string LoginPwd { get; set; }

        public Admin(string id, string pwd)
        {
            this.LoginId = id;
            this.LoginPwd = pwd;
        }
    }
}
