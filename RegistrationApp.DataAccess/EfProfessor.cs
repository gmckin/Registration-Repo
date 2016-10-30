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
    public List<Professor> GetProfessors()
    {
      return db.Professors.ToList();
    }

    public bool AddProfessor(Professor professor)
    {
      db.Professors.Add(professor);
      return db.SaveChanges() > 0;
    }

    public bool UpdateProfessor(Professor professor)
    {
      var result = db.Professors.SingleOrDefault(x => x.ProfessorID == professor.ProfessorID);

      if (result != null)
      {
        if (professor.ProfessorID != 0)
          result.ProfessorID = professor.ProfessorID;

        if (professor.LastName != null)
          result.LastName = professor.LastName;

        if (professor.FirstName != null)
          result.FirstName = professor.FirstName;
      }
      return db.SaveChanges() > 0;
    }

    public bool DeleteProfessor(Professor professor, int? id)
    {
      professor = db.Professors.Where(x => x.ProfessorID == id).FirstOrDefault();
      db.Professors.Remove(professor);
      return db.SaveChanges() > 0;
    }
  }
}
