using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess.Tests
{
  public class EfMSTests
  {
    private DataAccess.Student student;
    [TestInitialize]
    public void Initializ()
    {
      student = new Student() { FirstName = "Ann" };
    }

    [TestCleanup]

    public void Cleanup()
    {
      GC.Collect();
    }

    [TestMethod]
    public void Test_GetStudentFName()
    {
      EfData data = new EfData();
      var expected = 5;

      var actual = data.GetStudents();

      Assert.Equals(expected, actual.Count);
    }
  }
}
