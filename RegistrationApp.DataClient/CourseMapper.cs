using RegistrationApp.DataAccess;
using RegistrationApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationApp.DataClient
{
  public class CourseMapper
  {
    public static CourseDAO MapToCourseDAO(Course course)
    {
      var c = new CourseDAO();
      c.Id = course.CourseID;
      c.CourseNumber = course.CourseNumber;
      c.Title = course.Title;
      c.StartTime = course.StartTime;
      c.EndTime = course.EndTime;
      c.StartDate = course.StartDate;
      c.EndDate = course.EndDate;
      c.ClassDates = course.ClassDates;
      c.Credits = course.Credits;
      c.Capacity = course.Capacity;
      c.Active = course.Active;

      return c;
    }

    public static Course MapToCourse(CourseDAO course)
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