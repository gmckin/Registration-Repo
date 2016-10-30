using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess
{
  partial class EfData
  {
    public List<Room> GetRooms()
    {
      return db.Rooms.ToList();
    }

    public bool AddRoom(Room room)
    {
      db.Rooms.Add(room);
      return db.SaveChanges() > 0;
    }

    public bool UpdateRoom(Room room, EntityState state)
    {
      var entry = db.Entry<Room>(room);
      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public bool DeleteRoom(Room room, int? id)
    {
      room = db.Rooms.Where(x => x.RoomID == id).FirstOrDefault();
      db.Rooms.Remove(room);
      return db.SaveChanges() > 0;
    }
  }
}
