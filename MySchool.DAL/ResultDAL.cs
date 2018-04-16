using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using System.Data.SqlClient;

namespace MySchool.DAL
{
    //数据访问层成绩类
  public  class ResultDAL
    {
        //使用重写ToString（）方法显示ListView
      public static List<Result> GetResultByStu(string StuNo)
      {
          string sql = "select r.*,s.StudentName,sub.SubjectName from Result as r inner join  Student as s on s.StudentNo = r.StudentNo  inner join Subject as sub on r.SubjectId = sub.SubjectId where r.StudentNo = @StuNo";
          SqlParameter[] paras = { 
            new SqlParameter("@StuNo",StuNo)                        
            };
          try
          {
              SqlDataReader reader = SQLDBHelper.GetReader(sql,paras);
              List<Result> results = new List<Result>();
              while (reader.Read())
              {
                  results.Add(
                      new Result(
                          new Student(reader["StudentName"].ToString()),
                          new Subject(reader["SubjectName"].ToString()),
                          Convert.ToInt32(reader["StudentResult"]),
                          Convert.ToDateTime(reader["ExamDate"])
                          )
                      );
              }
              reader.Close();
              return results;
          }
          catch (Exception)
          {
              throw;
          }
      }
      //使用实体扩展类显示ListView
      public static List<ResultSeach> SeachResultByStu(string stuNo)
      {
          string sql = "select r.*,s.StudentName,sub.SubjectName from Result as r inner join  Student as s on s.StudentNo = r.StudentNo  inner join Subject as sub on r.SubjectId = sub.SubjectId where r.StudentNo = @StuNo";
          SqlParameter[] paras = { 
            new SqlParameter("@StuNo",stuNo)                        
            };
          try
          {
              SqlDataReader reader = SQLDBHelper.GetReader(sql, paras);
              List<ResultSeach> results = new List<ResultSeach>();
              while (reader.Read())
              {
                  results.Add(
                      new ResultSeach(
                          reader["StudentName"].ToString(),
                          reader["SubjectName"].ToString(),
                          Convert.ToInt32(reader["StudentResult"]),
                          Convert.ToDateTime(reader["ExamDate"])
                          )
                      );
              }
              reader.Close();
              return results;
          }
          catch (Exception)
          {
              throw;
          }
      }
      //新增成绩
      public static bool AddResult(ResultInsert result)
      {
          string sql = "insert Result Values(@StuNo,@SubNo,@Result,@ExamDate)";
          SqlParameter [] paras = { 
            new SqlParameter("@StuNo",result.StudentNo),
            new SqlParameter("@SubNo",result.SubjectNo),
            new SqlParameter("@Result",result.StudentResult),
            new SqlParameter("@ExamDate",result.ExamDate)
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
