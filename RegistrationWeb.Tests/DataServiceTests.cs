using RegistrationWeb.Logic;
using RegistrationWeb.Logic.RegistrationServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationWeb.Tests
{
  public class DataServiceTests
  {
    [Fact]
    public void Test_GetStudents()
    {
      var service = new DataService();
      var actual = service.GetStudents();

      Assert.NotEmpty(actual);
    }

    [Fact]
    public void Test_GetStudentEnrollments()
    {
      var id = 1;
      var service = new DataService();
      var actual = service.GetStudentEnrollments(id);

      Assert.NotEmpty(actual);
    }


    //[Fact]
    //public void Test_InsertCourse()
    //{
    //  var data = new DataService();
    //  var expected = new CourseDAO() { CourseNumber = 1113, Title = "PE107", StartTime = TimeSpan.Parse("10:00"), EndTime = TimeSpan.Parse("11:00"), StartDate = DateTime.Parse("10-24-2016"), EndDate = DateTime.Parse("12-23-2016"), ClassDates = "MTWRF", Capacity = 25, Active = true };

    //  var actual = data.InsertCourse(expected);

    //  Assert.True(actual) ;
    //}
  }
}
