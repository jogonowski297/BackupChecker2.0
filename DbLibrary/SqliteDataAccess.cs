using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;

namespace DbLibrary
{
    public class SqliteDataAccess
    {
        public static void SaveCopy(CopyModel copy)
        {
            using (IDbConnection cnn = new SQLiteConnection())
            {
                cnn.Execute("insert into Copy (Path, Size) values (@Path, @Size)", copy);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
