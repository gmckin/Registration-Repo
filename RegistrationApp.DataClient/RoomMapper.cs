using RegistrationApp.DataAccess;
using RegistrationApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationApp.DataClient
{
  public class RoomMapper
  {
    public static RoomDAO MapToRoomDAO(Room room)
    {
      var p = new RoomDAO();
      p.Id = room.RoomID;
      p.RoomNumber = room.RoomNum;

      return p;
    }

    public static Room MapToRoom(RoomDAO room)
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
