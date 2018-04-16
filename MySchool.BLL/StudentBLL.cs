using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using MySchool.DAL;

namespace MySchool.BLL
{
   public class StudentBLL
    {
       public static List<Student> GetAllStudentByGrade(int id)
       {
           try
           {
              return StudentDAL.GetAllStudent(id);
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public static List<StudentBuss> GetAllStudentByName(string name)
       {
           try
           {
               return StudentDAL.GetAllStudentBuss(name);
           }
           catch (Exception)
           {

               throw;
           }
       }
       public static bool AddStudent(Student stu)
       {
           try
           {
               return StudentDAL.AddStudent(stu);
           }
           catch (Exception)
           {
               throw;
           }
       }
       public static bool UpdateStudent(Student stu)
       {
           try
           {
               return StudentDAL.UpdateStudent(stu);
           }
           catch (Exception)
           {
               throw;
           }
       }
        //通过性别及年级Id获取学生
       public static List<Student> GetAllStudentByStuIdAndGender(int ?id = null, string gender = null)
       {
           try
           {
               return StudentDAL.GetAllStudentByStuIdAndGender(id, gender);
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public static bool DelStudentByStuNo(string StuNo)
       {
           try
           {
             return  StudentDAL.DelStudentByStuNo(StuNo);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
