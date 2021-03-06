﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RegistrationApp.DataClient.Models
{
  [DataContract]
  public class BuildingDAO
  {
    [DataMember]
    public int Id { get; set; }

    public string Name { get; set; }

    [DataMember]
    public string Department { get; set; }

    public RoomDAO Room { get; set; }
  }
}