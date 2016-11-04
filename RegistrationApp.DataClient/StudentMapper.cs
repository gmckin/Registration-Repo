using RegistrationApp.DataAccess;
using RegistrationApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationApp.DataClient
{
  public class StudentMapper
  {

    public static StudentDAO MapToStudentDAO(Student student)
    {
      var s = new StudentDAO();
      s.Id = student.StudentID;
      s.FirstName = student.FirstName;
      s.LastName = student.LastName;
      s.Active = student.Active;

      return s;
    }

    public static Student MapToStudent(StudentDAO student)
    {
      throw new NotImplementedException();
    }


    // this is an example of "Reflection"
    public static object MapTo(object o)
    {
      var properties = o.GetType().GetProperties();
      var ob = new object();

      foreach (var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
      }
      return ob;
    }
  }
}
