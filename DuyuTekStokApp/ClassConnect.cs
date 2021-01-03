using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace DuyuTekStokApp
{
    class ClassConnect
    {
        public static string conn = ConfigurationManager.ConnectionStrings["DuyuTekStokApp.Properties.Settings.StockControlConnectionString1"].ConnectionString;
    }
}
