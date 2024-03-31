using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DBActions
    {
        static string connString;
        IConfiguration config;

        public DBActions(IConfiguration config)
        {
            this.config = config;
        }

        public string GetConnectionString(string connectionString)
        {
            if (connString != null) 
            { 
                return connString;
            }
            string connStr = config.GetConnectionString(connectionString);
            connStr = ReplaceWithCurrentLocation(connStr);
            return connStr;
        }

        private string ReplaceWithCurrentLocation(string connStr)
        {
            string str = AppDomain.CurrentDomain.BaseDirectory;
            string directryAboveBin = str.Substring(0, str.IndexOf("\\bin"));
            string twoDirectoriesAboveBin = directryAboveBin.Substring(0, directryAboveBin.LastIndexOf("\\"));
            string threeDirectoriesAboveBin = twoDirectoriesAboveBin.Substring(0, twoDirectoriesAboveBin.LastIndexOf("\\"));
            connStr = string.Format(connStr, threeDirectoriesAboveBin);
            return connStr;
        }
    }
}
