using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess
{
  public class AdoData
  {

    private string connectionString = "@revsqltraining.ccgimk9upnjq.us - east - 1.rds.amazonaws.com; Initial Catalog = RegistrationDB; User id = sqlrootuser; Password=Rubberduck1;";

    private DataSet GetDataDisconnected(string query)
    {
      SqlCommand cmd;

      DataSet ds;

      SqlDataAdapter da;

      using (var connection = new SqlConnection(connectionString))
      {
        cmd = new SqlCommand(query, connection);
        da = new SqlDataAdapter(cmd);

        ds = new DataSet();
        da.Fill(ds);
      }

      return ds;
    }
  }
}
