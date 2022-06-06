using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddessBook_V1.Libraries
{
    public class Database
    {
      
        public Database()
        {            
                SQLiteConnection conn = new SQLiteConnection("Data Source=database.sqlite3");

                if (!File.Exists("./database.sqlite3"))
                {
                    SQLiteConnection.CreateFile("database.sqlite3");
                    Console.WriteLine("Database Created");
                }
                else
                {
                    Console.WriteLine("db already exists");
                }
           
        }
    }
}
