using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DB_Library
{
    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }

}
