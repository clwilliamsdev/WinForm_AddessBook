using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddessBook_V1.Libraries
{
    internal class DbControls
    {
        public static void CreateTbl()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
            conn.Open();
            string tbl = "create TABLE AddressBook (ID integer primary key AUTOINCREMENT, FirstName text, LastName text, Address1 text, " +
                "Address2 text, City text, State text, Zipcode text, PhoneNumber text)";
            SQLiteCommand command = new SQLiteCommand(tbl, conn);
            command.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Table Created");
        }

        public static void DeleteTbl()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
            conn.Open();
            string tbl = "DROP TABLE AddressBook ";
            SQLiteCommand command = new SQLiteCommand(tbl, conn);
            command.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Table Deleted");
            MessageBox.Show("Table has been Deleted");
        }
       
        
    }
}
