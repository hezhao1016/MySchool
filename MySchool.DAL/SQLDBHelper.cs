using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MySchool.DAL
{
    //数据访问层通用代码
     public static class SQLDBHelper
    {
         private static readonly string ConnString = ConfigurationManager.ConnectionStrings["MySchoolConnString"].ToString();

         //获取DataReader
         public static SqlDataReader GetReader(string sql, SqlParameter[] paras = null)
         {
             SqlConnection conn = new SqlConnection(ConnString);
             SqlCommand comm = new SqlCommand(sql, conn);
             if (paras != null)
             {
                 comm.Parameters.AddRange(paras);
             }
             try
             {
                 conn.Open();
                 return comm.ExecuteReader(CommandBehavior.CloseConnection);
             }
             catch (Exception)
             {
                 throw;
             }
         }
         //增删改
         public static bool ExecuteNonQueryByDBHelper(string sql, SqlParameter[] para = null)
         {
             using (SqlConnection conn = new SqlConnection(ConnString))
             {
                 SqlCommand comm = new SqlCommand(sql, conn);
                 if (para != null)
                 {
                     comm.Parameters.AddRange(para);
                 }
                 try
                 {
                     conn.Open();
                     if (comm.ExecuteNonQuery() > 0)
                     {
                         return true;
                     }
                     else
                     {
                         return false;
                     }
                 }
                 catch (Exception)
                 {
                     throw;
                 }
             }
         }
         //事务
         public static bool ExecuteNonQueryByShiWu(string sql, SqlParameter[] para = null)
         {
             using (SqlConnection conn = new SqlConnection(ConnString))
             {
                 SqlCommand comm = new SqlCommand(sql, conn);
                 if (para != null)
                 {
                     comm.Parameters.AddRange(para);
                 }
                 try
                 {
                     conn.Open();
                     comm.Transaction =  conn.BeginTransaction();
                     if (comm.ExecuteNonQuery() > 0)
                     {
                         comm.Transaction.Commit();
                         return true;
                     }
                     else
                     {
                         comm.Transaction.Rollback();
                         return false;
                     }
                 }
                 catch (Exception)
                 {
                     comm.Transaction.Rollback();
                     throw;
                 }
             }
         }
    }
}
