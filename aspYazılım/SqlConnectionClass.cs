using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace aspYazılım
{
    public class SqlConnectionClass
    {
       public static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OtoServisDB;Integrated Security=True;TrustServerCertificate=True");
    }
}