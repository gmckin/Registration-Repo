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
    public int CourseId { get; set; }

    [DataMember]
    public int CourseNumber { get; set; }    

    [DataMember]
    public int StudentId { get; set; }

    [DataMember]
    public TimeSpan StartTime { get; set; }
  }
}