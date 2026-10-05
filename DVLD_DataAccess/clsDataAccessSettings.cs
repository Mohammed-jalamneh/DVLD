using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DVLD_DataAccess
{
     public static class clsDataAccessSettings
    {
        public static string ConnectionString =
        ConfigurationManager.ConnectionStrings["DVLD_ConnectionString"].ConnectionString;
    }
}
