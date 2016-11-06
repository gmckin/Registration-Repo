using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RegistrationApp.DataClient.Models
{
  [DataContract]
  public class EnrollmentDAO
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public CourseDAO CourseId { get; set; }

    [DataMember]
    public CourseDAO CourseNumber { get; set; }    

    [DataMember]
    public StudentDAO StudentId { get; set; }

    [DataMember]
    public CourseDAO StartTime { get; set; }
  }
}