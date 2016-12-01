using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RegistrationApp.DataClient.Models
{
  [DataContract]
  public class CourseDAO
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public int CourseNumber { get; set; }

    [DataMember]
    public string Title { get; set; }

    [DataMember]
    public TimeSpan StartTime { get; set; }

    [DataMember]
    public TimeSpan EndTime { get; set; }

    [DataMember]
    public DateTime StartDate { get; set; }

    [DataMember]
    public DateTime EndDate { get; set; }

    [DataMember]
    public string ClassDates { get; set; }

    [DataMember]
    public int Capacity { get; set; }

    [DataMember]
    public int Credits { get; set; }
      
    [DataMember]
    public bool Active { get; set; }

    [DataMember]
    public StudentDAO Student { get; set; }
  }
}