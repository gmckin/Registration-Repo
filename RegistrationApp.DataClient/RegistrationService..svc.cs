using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RegistrationApp.DataClient.Models;
using RegistrationApp.DataAccess;
namespace RegistrationApp.DataClient
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  public class RegistrationService : IRegistrationService
  {
    private EfData ef = new EfData();
    public List<CourseDAO> GetCourses()
    {
      var c = new List<CourseDAO>();

      foreach (var courses in ef.GetCourses())
      {
        c.Add(CourseMapper.MapToCourseDAO(courses));
      }

      return c;
    }    
        
    public List<StudentDAO> GetStudents()
    {
      var s = new List<StudentDAO>();

      foreach (var students in ef.GetStudents())
      {
        s.Add(StudentMapper.MapToStudentDAO(students));
      }

      return s;
    }

    public List<EnrollmentDAO> GetEnrollments()
    {
      var s = new List<EnrollmentDAO>();

      foreach (var enrollment in ef.GetEnrollments())
      {
        s.Add(EnrollmentMapper.MapToEnrollmentDAO(enrollment));
      }

      return s;
    }

    public bool InsertCourse(CourseDAO course)
    {
      var c = new Course();
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
      return ef.AddCourse(c);
    }

    public bool InsertEnrollment(EnrollmentDAO enrollment)
    {
      var e = new Enrollment();
      e.CourseID = enrollment.Id;
      e.CourseNumber = enrollment.CourseNumber;

      return ef.AddEnrollment(e);
    }

    public bool InsertStudent(StudentDAO student)
    {
      var s = new Student();
      s.FirstName = student.FirstName;
      s.LastName = student.LastName;      

      return ef.AddStudent(s);
    }
  }
}
