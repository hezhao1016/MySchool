using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using System.Data.SqlClient;

namespace MySchool.DAL
{
    //数据访问层年级类
    public class GradeDAL
    {
        public static List<Grade> GetAllGrade()
        {
            string sql = "select * from Grade";
            try
            {
                SqlDataReader reader = SQLDBHelper.GetReader(sql);
                List<Grade> grades = new List<Grade>();
                while (reader.Read())
                {
                    grades.Add(
                        new Grade(Convert.ToInt32(reader["GradeId"]), reader["GradeName"].ToString())
                        );
                }
                reader.Close();
                return grades;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
