using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Data;

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

  

    [Fact]
    public void Test_InsertStudent()
    {
      var data = new EfData();
      var expected = new Student() { FirstName = "Derek", LastName = "Geter",  Major = "PE" };

      var actual = data.UpdateStudent(expected, System.Data.Entity.EntityState.Added);

      Assert.True(actual);
    }
  }
}
