using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using MySchool.DAL;

namespace MySchool.BLL
{
  public class GradeBLL
    {
      public static List<Grade> GetAllGrade()
      {
          try
          {
            return  GradeDAL.GetAllGrade();
          }
          catch (Exception)
          {
              throw;
          }
      }
    }
}
