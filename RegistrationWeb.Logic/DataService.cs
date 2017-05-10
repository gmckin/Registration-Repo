using RegistrationWeb.Logic.RegistrationServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWeb.Logic
{
  public class DataService
  {
    private RegistrationServiceClient rsc = new RegistrationServiceClient();
    

    public bool InsertStudent(StudentDAO student)
    {          
      
      return rsc.InsertStudent(student);      
    }

    public bool InsertCourse(CourseDAO course )
    {
      
      return rsc.InsertCourse(course);
    }   

    public bool InsertEnrollment(StudentDAO student, CourseDAO course)
    {
      return rsc.InsertEnrollment(student, course);
    }

    public bool DeleteCourseEnrollment(StudentDAO student, CourseDAO course)
    {

      return rsc.DeleteEnrollment(student, course);
    }

    public List<StudentDAO> GetStudents()
    {        
      return rsc.GetStudents().ToList();
    }

    public List<Course> GetStudentEnrollments(int id)
    {      
      return rsc.GetStudentEnrollments(id).ToList();
    }

    public List<Student> GetCourseEnrollments(int id)
    {
      return rsc.GetCourseEnrollments(id).ToList();
    }

    public List<CourseDAO> GetCourses()
    {
      return rsc.GetCourses().ToList();
    }

    public bool DeleteStudent(int id)
    {
      return rsc.DeleteStudent(id);
    }

    public bool DeleteCourse(int id)
    {
      return rsc.DeleteCourse(id);
    }
    // grrr
  }
}
