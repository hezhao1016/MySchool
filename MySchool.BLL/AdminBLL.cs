using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.DAL;
using MySchool.Models;

namespace MySchool.BLL
{
    public class AdminBLL
    {
        public static bool CheckLogin(Admin admin)
        {
            try
            {
               return AdminDAL.CheckLogin(admin);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool EditLoginPwd(Admin admin)
        {
            try
            {
                return AdminDAL.EditLoginPwd(admin);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
