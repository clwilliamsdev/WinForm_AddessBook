using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddessBook_V1
{
    public partial class ViewAddress : Form
    {
        public static int UpdateID;
        public ViewAddress()
        {
            InitializeComponent();
        }

        private void ViewAddress_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT FirstName, LastName, Address1, Address2, City, State, Zipcode, PhoneNumber, ID " +
                "FROM AddressBook WHERE FirstName = @FirstName AND LastName = @LastName", conn);

            command.Parameters.AddWithValue("FirstName", AddressBook.fName);
            command.Parameters.AddWithValue("LastName", AddressBook.lName);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    FirstNameInput.Text = reader.GetString(0);
                    LastNameInput.Text = reader.GetString(1);
                    Address1Input.Text = reader.GetString(2);
                    Address2Input.Text = reader.GetString(3);
                    CityInput.Text = reader.GetString(4);
                    StateInput.Text = reader.GetString(5);
                    ZipInput.Text = reader.GetString(6);
                    PhoneInput.Text = reader.GetString(7);
                    UpdateID = reader.GetInt32(8);

                    Console.WriteLine(UpdateID);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            conn.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddressBook addressBook = new AddressBook();
            addressBook.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("This will change the original file. Do you want to proceed?", "Update file",
              MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                NewAddress newAddress = new NewAddress();
                string firstName = newAddress.FirstLetterToUpper(FirstNameInput.Text);
                string lastName = newAddress.FirstLetterToUpper(LastNameInput.Text);

                SQLiteConnection conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
                conn.Open();
                string update = "UPDATE AddressBook SET FirstName = @FirstName, LastName = @LastName, Address1 = @Address1, Address2 = @Address2," +
                    " City = @City, State = @State, Zipcode = @Zipcode, PhoneNumber = @PhoneNumber WHERE ID = @UpdateID";
                SQLiteCommand command = new SQLiteCommand(update, conn);
                command.Parameters.AddWithValue("FirstName", firstName);
                command.Parameters.AddWithValue("LastName", lastName);
                command.Parameters.AddWithValue("Address1", Address1Input.Text);
                command.Parameters.AddWithValue("Address2", Address2Input.Text);
                command.Parameters.AddWithValue("City", CityInput.Text);
                command.Parameters.AddWithValue("State", StateInput.Text);
                command.Parameters.AddWithValue("Zipcode", ZipInput.Text);
                command.Parameters.AddWithValue("PhoneNumber", PhoneInput.Text);
                command.Parameters.AddWithValue("UpdateID", UpdateID);
                command.ExecuteNonQuery();
                conn.Close();
            }

            Console.WriteLine("Entry Saved");
            MessageBox.Show("Entry has been saved");

            this.Hide();
            AddressBook addressBook = new AddressBook();
            addressBook.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("This will delete this file. Do you want to proceed?", "Delete file",
              MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                SQLiteConnection conn1;
                conn1 = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
                conn1.Open();
                string delete = "DELETE FROM AddressBook WHERE ID = @UpdateID";
                SQLiteCommand command1 = new SQLiteCommand(delete, conn1);
                command1.Parameters.AddWithValue("UpdateID", UpdateID);
                command1.ExecuteNonQuery();
                conn1.Close();

                Console.WriteLine("File Deleted");
                MessageBox.Show("File has been Deleted");

                this.Hide();
                AddressBook addressBook = new AddressBook();
                addressBook.ShowDialog();
            }
    }


}
}
