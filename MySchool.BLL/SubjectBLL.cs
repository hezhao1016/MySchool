using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using MySchool.DAL;

namespace MySchool.BLL
{
   public class SubjectBLL
    {
       public static List<Subject> GetSubject( int ?gradeId = null)
       {
           try
           {
               return SubjectDAL.GetSubject(gradeId);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
