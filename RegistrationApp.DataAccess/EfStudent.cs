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
    public List<Student> GetStudents()
    {
      return db.Students.ToList();
    }

    public bool AddStudent(Student student)
    {
      db.Students.Add(student);
      return db.SaveChanges() > 0;
    }

    public bool UpdateStudent(Student student, EntityState state)
    {
      var entry = db.Entry<Student>(student);
      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public bool DeleteStudent(Student student)
    {
      db.Students.Remove(student);
      return db.SaveChanges() > 0;
    }
  }
}
