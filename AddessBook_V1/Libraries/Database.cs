using System;
using System.Data.SQLite;
using System.IO;

namespace AddessBook_V1.Libraries
{
    public class Database
    {

        public Database()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=AddressBookDB.sqlite3");

            if (!File.Exists("./AddressBookDB.sqlite3"))
            {
                SQLiteConnection.CreateFile("AddressBookDB.sqlite3");
                Console.WriteLine("Database Created");

                conn.Open();
                string tbl = "create TABLE AddressBook (ID integer primary key AUTOINCREMENT, FirstName text, LastName text, Address1 text, " +
                    "Address2 text, City text, State text, Zipcode text, PhoneNumber text)";
                SQLiteCommand command = new SQLiteCommand(tbl, conn);
                command.ExecuteNonQuery();
                conn.Close();

                Console.WriteLine("Table Created");

            }
            else
            {
                Console.WriteLine("db already exists");
            }



        }
    }
}
