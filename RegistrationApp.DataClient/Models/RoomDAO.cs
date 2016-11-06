using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RegistrationApp.DataClient.Models
{
  [DataContract]
  public class RoomDAO
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public int RoomNumber { get; set; }

    [DataMember]
    public BuildingDAO Building { get; set; }
  }
}