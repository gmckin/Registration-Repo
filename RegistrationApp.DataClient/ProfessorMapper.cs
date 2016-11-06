using RegistrationApp.DataAccess;
using RegistrationApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationApp.DataClient
{
  public class ProfessorMapper
  {
    public static ProfessorDAO MapToProfessorDAO(Professor professor)
    {
      var p = new ProfessorDAO();
      p.Id = professor.ProfessorID;
      p.FirstName = professor.FirstName;
      p.LastName = professor.LastName;      
      p.Active = professor.Active;

      return p;
    }

    public static Professor MapToProfessor(ProfessorDAO professor)
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
