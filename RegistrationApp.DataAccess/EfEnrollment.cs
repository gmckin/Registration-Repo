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
    public List<Enrollment> GetEnrollments()
    {
      return db.Enrollments.ToList();
    }

    public bool AddEnrollment(Enrollment enrollment)
    {
      db.Enrollments.Add(enrollment);
      return db.SaveChanges() > 0;
    }

    public bool UpdateEnrollment(Enrollment enrollment, EntityState state)
    {
      var entry = db.Entry<Enrollment>(enrollment);
      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public bool DeleteEnrollment(Enrollment enrollment)
    {
      //db.Enrollments.Remove(enrollment);
      //return db.SaveChanges() > 0;

      db.Enrollments.Find(enrollment);
      db.Enrollments.Remove(enrollment);
      return db.SaveChanges() > 0;


    }

    public List<Enrollment> GetStudentEnrollments()
    {
      //var studentenrollment = db.Students.Include(Enrollment => Enrollment.Enrollments.Select(Course => Course)).ToList();
      var studentenrollment = db.Enrollments.Include(e => e.Course).Include(e => e.Student).ToList();
      return studentenrollment;
    }
  }
}
