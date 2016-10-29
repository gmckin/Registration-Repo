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
    public List<Building> GetBuildings()
    {
      return db.Buildings.ToList();
    }

    public bool AddBuilding(Building building)
    {
      db.Buildings.Add(building);
      return db.SaveChanges() > 0;
    }

    public bool UpdateBuilding(Building building, EntityState state)
    {
      var entry = db.Entry<Building>(building);
      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public bool DeleteBuilding(Building building)
    {
      db.Buildings.Remove(building);
      return db.SaveChanges() > 0;
    }
  }
}
