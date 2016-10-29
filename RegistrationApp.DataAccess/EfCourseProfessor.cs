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
    public List<CourseProfessor> GetCourseProfessors()
    {
      return db.CourseProfessors.ToList();
    }

    public bool AddCourseProfessor(CourseProfessor courseprofessor)
    {
      db.CourseProfessors.Add(courseprofessor);
      return db.SaveChanges() > 0;
    }

    public bool UpdateCourseProfessor(CourseProfessor courseprofessor, EntityState state)
    {
      var entry = db.Entry<CourseProfessor>(courseprofessor);
      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public bool DeleteCourseProfessor(CourseProfessor courseprofessor)
    {
      db.CourseProfessors.Find(courseprofessor);
      db.CourseProfessors.Remove(courseprofessor);
      return db.SaveChanges() > 0;
    }
        
    //public List<ClassRoom> GetStudentClassRooms()
    //{
    //  var studentclassRoom = db.ClassRooms.Include(e => e.Building).Include(e => e.Room).ToList();
    //  return studentclassRoom;
    //}
  }
}
