using RegistrationApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess
{
  public class EfRegistrar
  {
    private RegistrationDBEntities db = new RegistrationDBEntities();
    EfData data = new EfData();

    public List<Course> GetCourses()
    {
      var result = db.Courses.ToList();

      return result;
    }

    public List<Enrollment> GetCourseEnrollments()
    {
      return data.GetEnrollments();
    }


    public List<Course> GetCoursesByStudentID(int id)
    {
      var result = db.Enrollments.Join(db.Courses,
         e => e.CourseID,
         c => c.CourseID,
         (Enrollment, Course) => new
         {
           Enrollment = Enrollment,
           Course = Course
         })
         .Where(e => e.Enrollment.StudentID == id).ToList();

      List<Course> studentCourses = new List<Course>();

      for (int i = 0; i < result.Count; i++)
      {
        studentCourses.Add(new Course()
        {
          CourseID = result[i].Course.CourseID,
          CourseNumber = result[i].Course.CourseNumber,
          Title = result[i].Course.Title,
          StartTime = result[i].Course.StartTime,
          EndTime = result[i].Course.EndTime,
          StartDate = result[i].Course.StartDate,
          EndDate = result[i].Course.EndDate,
          ClassDates = result[i].Course.ClassDates,
          Credits = result[i].Course.Credits,
          Capacity = result[i].Course.Capacity
        });
      }


      return studentCourses;
    }

    public List<Student> GetStudentInCourse(int id)
    {
      var result = db.Enrollments.Join(db.Students,
        Enrollment => Enrollment.StudentID,
        Student => Student.StudentID,
        (Enrollment, Student) => new
        {
          Enrollment = Enrollment,
          Student = Student
        }).Where(Enrollment => Enrollment.Enrollment.CourseID == id).ToList();

      List<Student> studentInCourse = new List<Student>();
   
        for(int i = 0; i < result.Count; i++)
        {
        studentInCourse.Add(new Student() {
          StudentID = result[i].Student.StudentID,
          FirstName = result[i].Student.FirstName,
          LastName = result[i].Student.LastName,
          Major = result[i].Student.Major
        });
        }
     

      return studentInCourse;
    }


    public bool AddStudent(Student student)
    {         
      return data.AddStudent(student);
    }    
  }
}
