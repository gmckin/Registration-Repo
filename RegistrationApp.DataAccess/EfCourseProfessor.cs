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

    //public Task<CourseProfessor> GetCourseProfessorid(int id)
    //{
    //  var profid = db.CourseProfessors.Select(p => p.CourseProfessorID.Equals(id));
    //  return profid;
    //}

    public bool AddCourseProfessor(CourseProfessor courseprofessor)
    {
      db.CourseProfessors.Add(courseprofessor);
      return db.SaveChanges() > 0;
    }

    public bool UpdateCourseProfessor(CourseProfessor courseprofessor)
    {
      var result = db.CourseProfessors.SingleOrDefault(x => x.CourseProfessorID == courseprofessor.CourseProfessorID);
     
      if(result != null)
      {
        if (courseprofessor.CourseProfessorID != 0)
          result.CourseProfessorID = courseprofessor.CourseProfessorID;

        if (courseprofessor.ProfessorID != 0)
          result.ProfessorID = courseprofessor.ProfessorID;

        if (courseprofessor.CourseID != 0)
          result.CourseID = courseprofessor.CourseID;
      }
      
      return db.SaveChanges() > 0;
    }

    public bool DeleteCourseProfessor(CourseProfessor courseprofessor, int? id)
    {
      courseprofessor = db.CourseProfessors.Where(x => x.CourseProfessorID == id).FirstOrDefault();
      //var entry = db.Entry<CourseProfessor>(courseprofessor);
      //db.Entry(entry).State = EntityState.Deleted;
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
