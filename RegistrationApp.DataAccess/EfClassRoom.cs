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

    public bool DeleteClassRoom(ClassRoom classRoom, int? id)
    {
      //db.ClassRooms.Remove(classRoom);
      //return db.SaveChanges() > 0;
      classRoom = db.ClassRooms.Where(x => x.ClassRoomID == id).FirstOrDefault();
     
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
