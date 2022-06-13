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
    public partial class NewAddress : Form
    {
        public NewAddress()
        {
            InitializeComponent();
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstLetterToUpper(FirstNameInput.Text);
            string lastName = FirstLetterToUpper(LastNameInput.Text);


            SQLiteConnection conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
            conn.Open();
            string save = "INSERT INTO AddressBook(FirstName, LastName, Address1, Address2, City," +
                " State, Zipcode, PhoneNumber)" + "Values('" + firstName + "', '" + lastName + "','" + Address1Input.Text + "'," +
                "  '" + Address2Input.Text + "', '" + CityInput.Text + "', '" + StateInput.Text + "', '" + ZipInput.Text + "', '" + PhoneInput.Text + "')";

            SQLiteCommand cmd = new SQLiteCommand(save, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddressBook addressBook = new AddressBook();
            addressBook.ShowDialog();
        }

        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        public void StateCreator()
        {

            List<string> states = new List<string>();
            states.Add("AL");
            states.Add("AK");
            states.Add("AZ");
            states.Add("AR");
            states.Add("CA");
            states.Add("CO");
            states.Add("CT");
            states.Add("DE");
        }

    }
}
