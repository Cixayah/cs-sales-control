using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    static class DatabaseConnection
    {
        // Database credentials
        private const string server = "1";
        private const string database = "2";
        private const string port = "3";
        private const string user = "4";
        private const string password = "5";

        // Database connection string
        public static string ConnectionString = $"server={server}; user={user}; database={database}; port={port}; password={password}";
    }
}
