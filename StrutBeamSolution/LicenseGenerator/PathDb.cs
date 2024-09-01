using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGenerator
{
    public static class PathDb
    {
        public static string GetPath(string dbName)
        {
            return Path.Combine(Application.LocalUserAppDataPath, dbName);
        }
    }
}
