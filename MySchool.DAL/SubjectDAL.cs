using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using System.Data.SqlClient;

namespace MySchool.DAL
{
    //数据访问层类库科目类
  public  class SubjectDAL
    {
      //获取科目信息
      public static List<Subject> GetSubject(int ?gradeId  = null)
      {
          string sql = "select s.*,g.GradeName from Subject as s inner join Grade as g on s.GradeId = g.GradeId where 1=1 ";
          SqlParameter[] paras = null;
          if (gradeId != null)
          {
              sql += " and g.GradeId = @GradeId";
              paras = new SqlParameter[] { 
              new SqlParameter("@GradeId",gradeId)
              };
          }
          try
          {
              SqlDataReader reader = SQLDBHelper.GetReader(sql,paras);
              List<Subject> subs = new List<Subject>();
              while (reader.Read())
              {
                  subs.Add(
                       new Subject(
                         Convert.ToInt32(  reader["SubjectId"]),
                         reader["SubjectName"].ToString(),
                         Convert.ToInt32(reader["ClassHour"]),
                         new Grade(
                            Convert.ToInt32( reader["GradeId"]),
                            reader["GradeName"].ToString()
                             )
                         )
                      );
              }
              reader.Close();
              return subs;
          }
          catch (Exception)
          {
              throw;
          }
      }
    }
}
