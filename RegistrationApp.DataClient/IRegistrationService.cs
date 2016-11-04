using RegistrationApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RegistrationApp.DataClient
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
  [ServiceContract]
  public interface IRegistrationService
  {
    [OperationContract]
    List<StudentDAO> GetStudents();

    [OperationContract]
    List<CourseDAO> GetCourses();

    [OperationContract]
    List<EnrollmentDAO> GetEnrollments();

    [OperationContract]
    bool InsertStudent(StudentDAO student);

    [OperationContract]
    bool InsertCourse(CourseDAO course);

    [OperationContract]
    bool InsertEnrollment(EnrollmentDAO enrollment);





  }
}
