using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using RegistrationApp.DataAccess;
using RegistrationApp.DataClient.Models;

namespace RegistrationApp.DataClient
{
  public class EnrollmentAutoMapper
  {
    private MapperConfiguration mapper =
        new MapperConfiguration(m => m.CreateMap<Enrollment, EnrollmentDAO>().ForMember(d => d.Id, o => o.MapFrom(s => s.EnrollmentID)));


    public object MapTo(object o, object o1)
    {
      var m = mapper.CreateMapper();


      return m.Map(o, o1);
    }
  }
}