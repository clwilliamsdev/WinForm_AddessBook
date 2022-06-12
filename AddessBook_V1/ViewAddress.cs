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


            //string save = "INSERT INTO AddressBook(FirstName, LastName, Address1, Address2, City," +
            //    " State, Zipcode, PhoneNumber)" + "Values('" + FirstNameInput.Text + "', '" + LastNameInput.Text + "','" + Address1Input.Text + "'," +
            //    "  '" + Address2Input.Text + "', '" + CityInput.Text + "', '" + StateInput.Text + "', '" + ZipInput.Text + "', '" + PhoneInput.Text + "')";

            //Libraries.AddressModel addressModel = new Libraries.AddressModel();
            //addressModel.FirstName = FirstNameInput.Text;
            //addressModel.LastName = LastNameInput.Text;
            //addressModel.Address1 = Address1Input.Text;
            //addressModel.Address2 = Address2Input.Text;
            //addressModel.City = CityInput.Text;
            //addressModel.State = StateInput.Text;
            //addressModel.Zipcode = ZipInput.Text;
            //addressModel.PhoneNumber = PhoneInput.Text;



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

       
    }
}
