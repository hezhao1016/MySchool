using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using MySchool.DAL;

namespace MySchool.BLL
{
   public class ResultBLL
    {
       public static List<Result> GetResultByStu(string StuNo)
       {
           try
           {
             return  ResultDAL.GetResultByStu(StuNo);
           }
           catch (Exception)
           {
               throw;
           }
       }
       public static List<ResultSeach> SeachResultByStu(string stuNo)
       {
           try
           {
              return  ResultDAL.SeachResultByStu(stuNo);
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public static bool AddResult(ResultInsert result)
       {
           try
           {
             return  ResultDAL.AddResult(result);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
