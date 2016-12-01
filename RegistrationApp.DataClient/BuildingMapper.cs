using RegistrationApp.DataAccess;
using RegistrationApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationApp.DataClient
{
  public class BuildingMapper
  {
    public static BuildingDAO MapToBuildingDAO(Building building)
    {
      var p = new BuildingDAO();
      p.Id = building.BuildingID;
      p.Name = building.BuildingName;
      p.Department = building.Department;
     
      return p;
    }

    public static Building MapToBuilding(BuildingDAO building)
    {
      throw new NotImplementedException();
    }


    // this is an example of "Reflection"
    public static object MapTo(object o)
    {
      var properties = o.GetType().GetProperties();
      var ob = new object();

      foreach (var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
      }
      return ob;
    }
  }
}
