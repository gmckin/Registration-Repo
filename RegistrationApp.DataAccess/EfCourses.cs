using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess
{
  partial class EfData
  {
    public List<Course> GetCourses()
    {
      return db.Courses.ToList();
    }

    public bool AddCourse(Course course)
    {
      db.Courses.Add(course);
      return db.SaveChanges() > 0;
    }

    public bool UpdateCourse(Course course)
    {
      var result = db.Courses.SingleOrDefault(x => x.CourseID == course.CourseID);

      if (result != null)
      {
        if (course.CourseID != 0)
          result.CourseID = course.CourseID;

        if (course.CourseNumber != 0)
          result.CourseNumber = course.CourseNumber;

        if (course.Title != null)
          result.Title = course.Title;

        if (course.StartTime != null)
          result.StartTime = course.StartTime;

        if (course.EndTime != null)
          result.EndTime = course.EndTime;

        if (course.StartDate != null)
          result.StartDate = course.StartDate;

        if (course.EndDate != null)
          result.EndDate = course.EndDate;

        if (course.Credits != 0)
          result.Credits = course.Credits;

        if (course.ClassDates != null)
          result.ClassDates = course.ClassDates;

        if (course.Capacity != 0)
          result.Capacity = course.Capacity;

        if (course.Active != false)
          result.Active = course.Active;
      }
      return db.SaveChanges() > 0;
    }

    public int GetTopC()
    {
      var topid = db.Courses.Where(a => a.Active).Max(a => a.CourseID);
      return topid;
    }
    public bool DeleteCourse(Course course, int? id)
    {
      course = db.Courses.Where(x => x.CourseID == id).FirstOrDefault();
      db.Courses.Remove(course);
      return db.SaveChanges() > 0;
    }
  }
}
