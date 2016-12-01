using RegistrationApp.DataAccess;
using RegistrationApp.DataClient.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationApp.DataClient
{
  public class EnrollmentMapper
  {
    public static EnrollmentDAO MapToEnrollmentDAO(Enrollment enrollment)
    {
      var e = new EnrollmentDAO();

      e.Id = enrollment.EnrollmentID;
      e.CourseId = enrollment.CourseID;
      e.CourseNumber = enrollment.CourseNumber;
      e.StudentId = enrollment.StudentID;
      e.StartTime = enrollment.StartTime;

      return e;
    }

    public static Enrollment MapToEnrollment(EnrollmentDAO enrollment)
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