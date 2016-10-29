using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Data;
using System.Globalization;

namespace RegistrationApp.DataAccess.Tests
{
  public class EfTests
  {
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

    //[Fact]
    //public void Test_DeleteStudent()
    //{
    //  //var data = new EfData();
    //  //var expected = data.GetStudent();
    //  //var actual = data.DeleteStudent(expected);

    //  //Assert.True(actual);
    //}



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
      var expected = new Course() { CourseNumber = 1111, Title = "PE105", StartTime = TimeSpan.Parse("09:00"), EndTime = TimeSpan.Parse("10:00"), StartDate = DateTime.Parse("10-24-2016"), EndDate = DateTime.Parse("12-23-2016"), ClassDates = "MTWRF"};

    var actual = data.UpdateCourse(expected, System.Data.Entity.EntityState.Added);

    Assert.True(actual);
    }
    [Fact]
    public void Test_Enrollment()
    {
      var data = new EfData();
      var expected = new Enrollment() { CourseID = 9, StudentID = 5, CourseNumber = 8845, StartTime = TimeSpan.Parse("09:00") };

      var actual = data.UpdateEnrollment(expected, System.Data.Entity.EntityState.Added);
      
      Assert.True(actual);
    }
  }
}
