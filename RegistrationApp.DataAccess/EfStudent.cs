﻿using System;
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

    public bool UpdateStudent(Student student)
    {
      var result = db.Students.SingleOrDefault(x => x.StudentID == student.StudentID);

      if (result != null)
      {
        if (student.StudentID != 0)
          result.StudentID = student.StudentID;

        if (student.LastName != null)
          result.LastName = student.LastName;

        if (student.FirstName != null)
          result.FirstName = student.FirstName;

        if (student.Major != null)
          result.Major = student.Major;

        if (student.Active != false)
          result.Active = student.Active;
      }
      return db.SaveChanges() > 0;
    }

    public int GetTopS()
    {
      var topid = db.Students.Where(a => a.Active).Max(a => a.StudentID);
      return topid;
    }
    public bool DeleteStudent(int id)
    {      
      var student = db.Students.Where(x => x.StudentID == id).FirstOrDefault(); 
      db.Students.Remove(student);
      return db.SaveChanges() > 0;
    }

    public List<Student> GetStudentById(int id)
    {
      var result = db.Students.Where(a => a.StudentID == id);

      return result.ToList();
    }

   
  }
}
