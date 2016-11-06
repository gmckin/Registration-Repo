using RegistrationApp.DataAccess;
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
    List<Course> GetStudentEnrollments(int id);

    [OperationContract]
    List<Student> GetCourseEnrollments(int id);

    [OperationContract]
    bool InsertStudent(StudentDAO student);

    [OperationContract]
    bool InsertCourse(CourseDAO course);

    [OperationContract]
    bool InsertEnrollment(Enrollment enrollment);

    [OperationContract]
    List<ProfessorDAO> GetProfessors();

    [OperationContract]
    List<BuildingDAO> GetBuildings();

    [OperationContract]
    List<RoomDAO> GetRooms();

    [OperationContract]
    List<StudentDAO> GetStudentByID(int id);

    [OperationContract]
    List<CourseDAO> GetCourseByID(int id);



  }
}
