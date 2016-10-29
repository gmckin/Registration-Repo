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
    public List<ClassRoom> GetClassRoom()
    {
      return db.ClassRooms.ToList();
    }

    public bool AddClassRoom(ClassRoom classroom)
    {
      db.ClassRooms.Add(classroom);
      return db.SaveChanges() > 0;
    }

    public bool UpdateClassRoom(ClassRoom classroom, EntityState state)
    {
      var entry = db.Entry<ClassRoom>(classroom);
      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public bool DeleteClassRoom(ClassRoom classRoom)
    {
      //db.ClassRooms.Remove(classRoom);
      //return db.SaveChanges() > 0;

      db.ClassRooms.Find(classRoom);
      db.ClassRooms.Remove(classRoom);
      return db.SaveChanges() > 0;


    }

    //public List<ClassRoom> GetStudentClassRooms()
    //{     
    //  var studentclassRoom = db.ClassRooms.Include(e => e.Building).Include(e => e.Room).ToList();
    //  return studentclassRoom;
    //}
  }
}
