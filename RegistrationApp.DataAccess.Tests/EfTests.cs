using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Data;
using System.Globalization;
using System.Data.Entity;

namespace RegistrationApp.DataAccess.Tests
{
  public class EfTests
  {
    private RegDBEntities db = new RegDBEntities();
    [Fact]
    public void Test_GetStudent()
    {
      var data = new EfData();
      var actual = data.GetStudents();

      Assert.NotNull(actual);
    }


    //[Fact]
    //public void Test_UpdateStudent()
    //{



    //}

    [Fact]
    public void Test_DeleteStudent()
    {
      var data = new EfData();
      var id = data.GetTopS();
      var expected = db.Students.Where(x => x.StudentID == id).FirstOrDefault();
      
      
      var actual = data.DeleteStudent(id);

      Assert.True(actual);
    }


    [Fact]
    public void Test_DeleteRoom()
    {
      var data = new EfData();
      var id = data.GetTopR();
      var expected = db.Rooms.Where(x => x.RoomID == id).FirstOrDefault();
     
      var actual = data.DeleteRoom(expected, id);

      Assert.True(actual);
    }

    [Fact]
    public void Test_DeleteProfessor()
    {
      var data = new EfData();
      var id = data.GetTopP();
      var expected = db.Professors.Where(x => x.ProfessorID == id).FirstOrDefault();
     

      var actual = data.DeleteProfessor(expected, id);

      Assert.True(actual);
    }

    [Fact]
    public void Test_DeleteEnrollment()
    {
      var data = new EfData();
      var id = data.GetTopE();
      var expected = db.Enrollments.Where(x => x.EnrollmentID == id).FirstOrDefault();
      

      var actual = data.DeleteEnrollment(id);

      Assert.True(actual);
    }

    [Fact]
    public void Test_DeleteCourse()
    {
      var data = new EfData();
      var id = data.GetTopC();
      var expected = db.Courses.Where(x => x.CourseID == id).FirstOrDefault();
     

      var actual = data.DeleteCourse(expected, id);

      Assert.True(actual);
    }

    [Fact]
    public void Test_DeleteCourseProfessor()
    {
      var data = new EfData();
      var id = data.GetTopCP();
      var expected = db.CourseProfessors.Where(x => x.CourseProfessorID == id).FirstOrDefault();
      

      var actual = data.DeleteCourseProfessor(expected, id);

      Assert.True(actual);
    }

    [Fact]
    public void Test_DeleteClassRoom()
    {
      var data = new EfData();
      var id = data.GetTopCR();
      var expected = db.ClassRooms.Where(x => x.ClassRoomID == id).FirstOrDefault();
     

      var actual = data.DeleteClassRoom(expected, id);

      Assert.True(actual);
    }

    [Fact]
    public void Test_DeleteBuilding()
    {
      var data = new EfData();
      var id = data.GetTopB();
      var expected = db.Buildings.Where(x => x.BuildingID == id).FirstOrDefault();      

      var actual = data.DeleteBuilding(expected, id);

      Assert.True(actual);
    }


    //[Fact]
    //public void Test_InsertStudent()
    //{
    //  var data = new EfData();
    //  var expected = new Student() { FirstName = "Derek", LastName = "Geter",  Major = "PE" };

    //  var actual = data.UpdateStudent(expected, System.Data.Entity.EntityState.Added);

    //  Assert.True(actual);
    //}

    [Fact]
    public void Test_InsertStudent()
    {
      var data = new EfData();
      var expected = new Student() { FirstName = "Derek", LastName = "Geter", Major = "PE" };

      var actual = data.AddStudent(expected);

      Assert.True(actual);
    }

    [Fact]
    public void Test_InsertCourse()
    {
      var data = new EfData();
      var expected = new Course() { CourseNumber = 1112, Title = "PE106", StartTime = TimeSpan.Parse("10:00"), EndTime = TimeSpan.Parse("11:00"), StartDate = DateTime.Parse("10-24-2016"), EndDate = DateTime.Parse("12-23-2016"), ClassDates = "MTWRF", Capacity = 25 , Active = true};

    var actual = data.AddCourse(expected);

    Assert.True(actual);
    }

    [Fact]
    public void Test_Enrollment()
    {
      var data = new EfData();
      var expected = new Enrollment() { CourseID = 2,  CourseNumber = 8845, StudentID = 1, StartTime = TimeSpan.Parse("08:00") };

      var actual = data.AddEnrollment(expected);
      
      Assert.True(actual);
    }

    [Fact]
    public void Test_Enrollment_sp()
    {
      var data = new EfData();
      var expected = new Enrollment() { CourseID = 1, StudentID = 3, CourseNumber = 8844, StartTime = TimeSpan.Parse("08:00") };
      
      var actual = data.Enroll(expected);

      Assert.True(actual);
    }

    [Fact]
    public void Test_InsertBuilding()
    {
      var data = new EfData();
      var expected = new Building() { BuildingName = "Test Building", Department = "Test Department" };

      var actual = data.AddBuilding(expected);

      Assert.True(actual);
    }

    [Fact]
    public void Test_InsertRoom()
    {
      var data = new EfData();
      var expected = new Room() { RoomNum = 127 };

      var actual = data.AddRoom(expected);

      Assert.True(actual);
    }

    [Fact]
    public void Test_CreateClassRoom()
    {
      var data = new EfData();
      var expected = new ClassRoom() { CourseID = 2, BuildingID = 2, RoomID = 3, StartTime = TimeSpan.Parse("10:00")};

      var actual = data.AddClassRoom(expected);

      Assert.True(actual);
    }

    [Fact]
    public void Test_InsertProfessor()
    {
      var data = new EfData();
      var expected = new Professor() { LastName = "Hopper", FirstName = "Grace"};

      var actual = data.AddProfessor(expected);

      Assert.True(actual);
    }

    [Fact]
    public void Test_CreateCourseProfessor()
    {
      var data = new EfData();
      var expected = new CourseProfessor() { CourseID = 1, ProfessorID = 1 };

      var actual = data.AddCourseProfessor(expected);

      Assert.True(actual);
    }


    //[Fact]
    //public void Test_DeleteCourseProfessor()
    //{
    //  var data = new EfData();
    //  var expected = new CourseProfessor() { CourseProfessorID = 5 };

    //  var actual = data.DeleteCourseProfessor(expected);

    //  Assert.False(actual);
    //}
  }
}
