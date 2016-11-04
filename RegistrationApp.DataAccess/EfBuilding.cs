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

    public bool UpdateBuilding(Building building)
    {
      var result = db.Buildings.SingleOrDefault(x => x.BuildingID == building.BuildingID);

      if (result != null)
      {
        if (building.BuildingID != 0)
          result.BuildingID = building.BuildingID;

        if (building.BuildingName != null)
          result.BuildingName = building.BuildingName;

        if (building.Department != null)
          result.Department = building.Department;
      }
      return db.SaveChanges() > 0;    
    }

    public int GetTopB()
    {
      var topid = db.Buildings.Max(a => a.BuildingID);
      return topid;
    }

    public bool DeleteBuilding(Building building, int? id)
    {
      building = db.Buildings.Where(x => x.BuildingID == id).FirstOrDefault();
      db.Buildings.Remove(building);
      return db.SaveChanges() > 0;
    }
  }
}
