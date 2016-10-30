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

    public bool UpdateProfessor(Professor professor, EntityState state)
    {
      var entry = db.Entry<Professor>(professor);
      entry.State = state;
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
