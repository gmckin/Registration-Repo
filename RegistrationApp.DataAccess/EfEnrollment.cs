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

    public bool UpdateEnrollment(Enrollment enrollment)
    {
      var result = db.Enrollments.SingleOrDefault(x => x.EnrollmentID == enrollment.EnrollmentID);

      if (result != null)
      {
        if (enrollment.EnrollmentID != 0)
          result.EnrollmentID = enrollment.EnrollmentID;

        if (enrollment.CourseID != 0)
          result.CourseID = enrollment.CourseID;

        if (enrollment.StudentID != 0)
          result.StudentID = enrollment.StudentID;

        if (enrollment.CourseNumber != 0)
          result.CourseNumber = enrollment.CourseNumber;

        if (enrollment.StartTime != null)
          result.StartTime = enrollment.StartTime;        
      }
      return db.SaveChanges() > 0;
    }

    public bool DeleteEnrollment(Enrollment enrollment, int? id)
    {
      enrollment = db.Enrollments.Where(x => x.EnrollmentID == id).FirstOrDefault();
      db.Enrollments.Remove(enrollment);
      return db.SaveChanges() > 0;


    }

    public List<Enrollment> GetStudentEnrollments()
    {
      //var studentenrollment = db.Students.Include(Enrollment => Enrollment.Enrollments.Select(Course => Course)).ToList();
      var studentenrollment = db.Enrollments.Include(e => e.Course).Include(e => e.Student);
      return studentenrollment.ToList();
    }

    public int GetTopE()
    {
      var topid = db.Enrollments.Max(a => a.EnrollmentID);
      return topid;
    }

    public bool Enroll()
    {
      return db.sp_CourseRegistration(2, 3, 8845, TimeSpan.Parse("09:00")) > 0;
    }
  }
}
