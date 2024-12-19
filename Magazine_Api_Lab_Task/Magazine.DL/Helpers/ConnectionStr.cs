using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Helpers
{
    public class ConnectionStr
    {
        public static string ConnectionString()
        {
            ConfigurationManager configManager = new ConfigurationManager();
            configManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Magazine.API"));
            configManager.AddJsonFile("appsettings.json");
            string? connectionstring = configManager.GetConnectionString("MsSql");
            if (connectionstring == null)
            {
                throw new Exception("Connection String Not Found");
            }
            return connectionstring;



        }

    }
}
