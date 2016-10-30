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

    public bool UpdateCourse(Course course, EntityState state)
    {
      var entry = db.Entry<Course>(course);
      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public bool DeleteCourse(Course course, int? id)
    {
      course = db.Courses.Where(x => x.CourseID == id).FirstOrDefault();       
      db.Courses.Remove(course);
      return db.SaveChanges() > 0;
    }
  }
}
