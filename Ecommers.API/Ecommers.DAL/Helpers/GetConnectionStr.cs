using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.DAL.Helpers
{
    public static class GetConnectionStr
    {
        public static string GetConnection()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"..", "Ecommers.API"));
            configurationManager.AddJsonFile("appsettings.json");
            string? getconnectionstr = configurationManager.GetConnectionString("Mssql");
            if (getconnectionstr == null)
            {
                throw new Exception("Connection String Not Found");
            }
            return getconnectionstr;
        }
    }
}
