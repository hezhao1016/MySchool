using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using System.Data.SqlClient;

namespace MySchool.DAL
{
    //数据访问层学生类
   public class StudentDAL
    {
        //通过年级Id获取学生
       public static List<Student> GetAllStudent(int id)
       {
           string sql = "select s.*,g.GradeName from Student as s inner join Grade as g on s.GradeId = g.GradeId where 1=1 ";
           SqlParameter[] paras = null;
           if (id != -1)
           {
               sql += " and s.GradeId = @GradeId";
               paras = new SqlParameter[] { 
                new SqlParameter("@GradeId",id)
               };
           }
           try
           {
             SqlDataReader reader =   SQLDBHelper.GetReader(sql, paras);
             List<Student> stus = new List<Student>();
             while (reader.Read())
             {
                 stus.Add(
                     new Student(
                         reader["StudentNo"].ToString(),
                           reader["LoginPwd"].ToString(),
                           reader["StudentName"].ToString(),
                           reader["Gender"].ToString(),
                           new Grade(
                             Convert.ToInt32(reader["GradeId"]),
                               reader["GradeName"].ToString()
                               ),
                           reader["Phone"].ToString(),
                           reader["Address"].ToString(),
                           Convert.ToDateTime(reader["BornDate"]),
                           reader["Email"].ToString()
                         )
                     );
             }
             reader.Close();
             return stus;
           }
           catch (Exception)
           {
               
               throw;
           } 
       }
       //通过性别及年级Id获取学生
       public static List<Student> GetAllStudentByStuIdAndGender(int ?id = null,string gender = null)
       {
           string sql = "select s.*,g.GradeName from Student as s inner join Grade as g on s.GradeId = g.GradeId where 1=1 ";
           SqlParameter[] paras = null;
           if (id!= null)
           {
               sql += " and s.GradeId = @GradeId ";
               paras = new SqlParameter[]{ 
                new SqlParameter("@GradeId",id)
               };
           }
           if (gender != null)
           {
               sql+=" and s.Gender = @Gender";
               paras = new SqlParameter[]{ 
                new SqlParameter("@GradeId",id),
                new SqlParameter("@Gender",gender)
               };
           }
           try
           {
               SqlDataReader reader = SQLDBHelper.GetReader(sql, paras);
               List<Student> stus = new List<Student>();
               while (reader.Read())
               {
                   stus.Add(
                       new Student(
                           reader["StudentNo"].ToString(),
                             reader["LoginPwd"].ToString(),
                             reader["StudentName"].ToString(),
                             reader["Gender"].ToString(),
                             new Grade(
                               Convert.ToInt32(reader["GradeId"]),
                                 reader["GradeName"].ToString()
                                 ),
                             reader["Phone"].ToString(),
                             reader["Address"].ToString(),
                             Convert.ToDateTime(reader["BornDate"]),
                             reader["Email"].ToString()
                           )
                       );
               }
               reader.Close();
               return stus;
           }
           catch (Exception)
           {

               throw;
           }
       }
       //根据学生姓名获取学生信息
       public static List<StudentBuss> GetAllStudentBuss(string name)
       {
           string sql = "select s.*,g.GradeName from Student as s inner join Grade as g on s.GradeId = g.GradeId where StudentName like +'%'+@Name+'%'";
           SqlParameter[] paras ={ 
                new SqlParameter("@Name",name)
               };
           try
           {
               SqlDataReader reader = SQLDBHelper.GetReader(sql, paras);
               List<StudentBuss> stus = new List<StudentBuss>();
               while (reader.Read())
               {
                   stus.Add(
                       new StudentBuss(
                           reader["StudentNo"].ToString(),
                           reader["LoginPwd"].ToString(),
                           reader["StudentName"].ToString(),
                           reader["Gender"].ToString(),
                           new Grade(
                             Convert.ToInt32(  reader["GradeId"]),
                               reader["GradeName"].ToString()
                               ),
                           reader["Phone"].ToString(),
                           reader["Address"].ToString(),
                           Convert.ToDateTime(reader["BornDate"]),
                           reader["Email"].ToString()
                           )
                       );
               }
               reader.Close();
               return stus;
           }
           catch (Exception)
           {
               throw;
           }
       }
       //添加学生
       public static bool AddStudent(Student stu)
       {
           string sql = "insert Student values(@StuNo,@Pwd,@StuName,@Gender,@GradeId,@Phone,@Address,@BornDate,@Email)";
           SqlParameter[] paras = { 
            new SqlParameter("@StuNo",stu.StudentNo),  
            new SqlParameter("@Pwd",stu.LoginPwd),  
            new SqlParameter("@StuName",stu.StudentName),  
            new SqlParameter("@Gender",stu.Gender),  
            new SqlParameter("@GradeId",stu.Grade.GradeId),  
            new SqlParameter("@Phone",stu.Phone),  
            new SqlParameter("@Address",stu.Address),  
            new SqlParameter("@BornDate",stu.BornDate),
            new SqlParameter("@Email",stu.Email)
            };
           try
           {
               return SQLDBHelper.ExecuteNonQueryByDBHelper(sql, paras);
           }
           catch (Exception)
           {
               throw;
           }
       }
       //修改学生信息
       public static bool UpdateStudent(Student stu)
       {
           string sql = "Update Student set LoginPwd = @Pwd,StudentName = @StuName,Gender = @Gender,GradeId = @GradeId,Phone = @Phone,Address = @Address,BornDate = @BornDate, Email = @Email where StudentNo = @StudentNo";
           SqlParameter[] paras = { 
            new SqlParameter("@Pwd",stu.LoginPwd),  
            new SqlParameter("@StuName",stu.StudentName),  
            new SqlParameter("@Gender",stu.Gender),  
            new SqlParameter("@GradeId",stu.Grade.GradeId),  
            new SqlParameter("@Phone",stu.Phone),  
            new SqlParameter("@Address",stu.Address),  
            new SqlParameter("@BornDate",stu.BornDate),
            new SqlParameter("@Email",stu.Email),
            new SqlParameter("@StudentNo",stu.StudentNo)
            };
           try
           {
               return SQLDBHelper.ExecuteNonQueryByDBHelper(sql, paras);
           }
           catch (Exception)
           {
               throw;
           }
       }
       //删除成绩
       public static bool DelResultByStuNo(string StuNo)
       {
           string sql = "delete Result where StudentNo = @StudentNo";
           SqlParameter[] paras = { 
             new SqlParameter("@StudentNo",StuNo)                     
             };
           try
           {
              return SQLDBHelper.ExecuteNonQueryByShiWu(sql, paras);
           }
           catch (Exception)
           {
               throw;
           }
       }
        //删除学生
       public static bool DelStudentByStuNo(string StuNo)
       {
           DelResultByStuNo(StuNo);
           string sql = "delete Student where StudentNo = @StuNo";
           SqlParameter[] paras = { 
             new SqlParameter("@StuNo",StuNo)                     
             };
           try
           {
               return SQLDBHelper.ExecuteNonQueryByShiWu(sql, paras);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
