using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Reflection;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
//using Hoc.Gemm.Inf.Trans;
using System.Xml;

namespace NImport.Inf.Rep
{
    public class ClaseBaseRep : ClaseBaseOrigenRep
    {
        public ClaseBaseRep()
        {
            try
            {
                DataBase = new SqlDatabase(GetConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetConnectionString()
        {
            //return GetConnectionStringFromKey("ConnectionString");
            //return Variables.ConnectionString.ToString();
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        }

    }
}
