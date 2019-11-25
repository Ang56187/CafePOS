using System;
using System.Data.SQLite;

namespace CafeSystem.Backend
{
    class Database
    {
        public SQLiteConnection SqlConn { get; set; }

        public SQLiteDataReader Sqlite_datareader { get; set; }

        public SQLiteCommand Sqlite_cmd { get; set; }

        public SQLiteDataAdapter Sqlite_adapter { get; set; }

        public void OpenDBConnection()
        {
            String fileLocation = System.IO.Path.Combine(Environment.CurrentDirectory, "..", "..", "Database", "posDB.db");

            String connStr = "Data Source=" + fileLocation + ";Version=3;Synchronous=Off;UTF8Encoding=True;";

            
            SqlConn = new System.Data.SQLite.SQLiteConnection(connStr);
            try
            {
                SqlConn.Open();
            }
            catch (Exception ei)
            {
            }

        }

        public void CloseDBConnection()
        {
            SqlConn.Close();
        }




    }
}
