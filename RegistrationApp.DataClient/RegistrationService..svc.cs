using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RegistrationApp.DataClient.Models;
using RegistrationApp.DataAccess;
using System.Data;

namespace RegistrationApp.DataClient
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  public class RegistrationService : IRegistrationService
  {
    private EfData ef = new EfData();
    private EfRegistrar efr = new EfRegistrar();

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
      c.Active = true;
      return ef.AddCourse(c);
    }

    public bool InsertStudent(StudentDAO student)
    {
      var s = new Student();
      s.FirstName = student.FirstName;
      s.LastName = student.LastName;
      s.Major = student.Major;
      s.Active = true;

      return ef.AddStudent(s);
    }

    public List<ProfessorDAO> GetProfessors()
    {
      var p = new List<ProfessorDAO>();

      foreach (var profs in ef.GetProfessors())
      {
        p.Add(ProfessorMapper.MapToProfessorDAO(profs));
      }
      return p;
    }

    public bool InsertProfessor(ProfessorDAO professor)
    {
      var p = new Professor();
      p.FirstName = professor.FirstName;
      p.LastName = professor.LastName;
      p.Active = true;

      return ef.AddProfessor(p);
    }

    public List<StudentDAO> GetStudentByID(int id)
    {
      var s = new List<StudentDAO>();

      foreach (var student in ef.GetStudentById(id))
      {
        s.Add(StudentMapper.MapToStudentDAO(student));
      }
      return s.ToList();
    }

    public List<CourseDAO> GetCourseByID(int id)
    {
      var c = new List<CourseDAO>();

      foreach (var course in ef.GetCourseById(id))
      {
        c.Add(CourseMapper.MapToCourseDAO(course));
      }
      return c.ToList();
    }

    public List<Course> GetStudentEnrollments(int id)
    {
      var e = efr.GetCoursesByStudentID(id);

      return e;
    }

    public List<Student> GetCourseEnrollments(int id)
    {
      var e = efr.GetStudentInCourse(id);

      return e;
    }

    //public List<EnrollmentDAO> GetEnrollments()
    //{
    //  var s = new List<EnrollmentDAO>();

    //  foreach (var enrollment in ef.GetEnrollments())
    //  {
    //    s.Add(EnrollmentMapper.MapToEnrollmentDAO(enrollment));
    //  }
    //  return s;
    //}



    public bool InsertEnrollment(StudentDAO student, CourseDAO course)
    {
      var enrollment = new Enrollment();
      enrollment.StudentID = student.Id;
      enrollment.CourseID = course.Id;
      enrollment.CourseNumber = course.CourseNumber;
      enrollment.StartTime = course.StartTime;

      return ef.AddEnrollment(enrollment);
    }

    public List<BuildingDAO> GetBuildings()
    {
      var b = new List<BuildingDAO>();

      foreach (var building in ef.GetBuildings())
      {
        b.Add(BuildingMapper.MapToBuildingDAO(building));
      }
      return b;
    }

    public bool InsertBuilding(BuildingDAO building)
    {
      var b = new Building();
      b.BuildingName = building.Name;
      b.Department = building.Department;

      return ef.AddBuilding(b);
    }

    public List<RoomDAO> GetRooms()
    {
      var r = new List<RoomDAO>();

      foreach (var rooms in ef.GetRooms())
      {
        r.Add(RoomMapper.MapToRoomDAO(rooms));
      }
      return r;
    }

    public bool InsertRoom(RoomDAO room)
    {
      var r = new Room();
      r.RoomNum = room.RoomNumber;

      return ef.AddRoom(r);
    }

    public bool DeleteStudent(int id)
    {
      
     
      return ef.DeleteStudent(id);
    }

    public bool DeleteCourse(int id)
    {
      

      return ef.DeleteStudent(id);
    }

    public bool DeleteEnrollment(StudentDAO student, CourseDAO course)
    {      
     var x = ef.GetEnrollments().Where(e => e.StudentID == student.Id && e.CourseNumber == course.CourseNumber).ToList();

      return ef.DeleteEnrollment(x[0].EnrollmentID);
    }

    
  }
}
