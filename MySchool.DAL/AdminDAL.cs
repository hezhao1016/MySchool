using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using System.Data.SqlClient;

namespace MySchool.DAL
{
    //数据访问层管理员类
    public class AdminDAL
    {
        public static bool CheckLogin(Admin admin)
        {
            string sql = "select * from Admin where LoginId = @Id and LoginPwd = @Pwd";
            SqlParameter[] paras = { 
            new SqlParameter("@Id",admin.LoginId),
            new SqlParameter("@Pwd",admin.LoginPwd)         
             };
            try
            {
                SqlDataReader reader = SQLDBHelper.GetReader(sql,paras);
                bool result = reader.Read();
                reader.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool EditLoginPwd(Admin admin)
        {
            string sql = "Update Admin set LoginPwd = @NewPwd where LoginId = @Id";
            SqlParameter[] paras = { 
            new SqlParameter("@NewPwd",admin.LoginPwd),
            new SqlParameter("@Id",admin.LoginId)       

             };
            try
            {
               return  SQLDBHelper.ExecuteNonQueryByDBHelper(sql,paras);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
