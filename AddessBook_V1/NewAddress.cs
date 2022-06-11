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
            SQLiteConnection conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
            conn.Open();
            string save = "INSERT INTO AddressBook(FirstName, LastName, Address1, Address2, City," +
                " State, Zipcode, PhoneNumber)" + "Values('" + FirstNameInput.Text + "', '" + LastNameInput.Text + "','" + Address1Input.Text + "'," +
                "  '" + Address2Input.Text + "', '" + CityInput.Text + "', '" + StateInput.Text + "', '" + ZipInput.Text + "', '" + PhoneInput.Text + "')";

            SQLiteCommand cmd = new SQLiteCommand(save, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Entry Saved");
            MessageBox.Show("Entry has been saved");

            this.Hide();
            AddressBook addressBook = new AddressBook();
            addressBook.ShowDialog();



            Libraries.AddressModel addressModel = new Libraries.AddressModel();
            addressModel.FirstName = FirstNameInput.Text;
            addressModel.LastName = LastNameInput.Text;
            addressModel.Address1 = Address1Input.Text;
            addressModel.Address2 = Address2Input.Text;
            addressModel.City = CityInput.Text;
            addressModel.State = StateInput.Text;
            addressModel.Zipcode = ZipInput.Text;
            addressModel.PhoneNumber = PhoneInput.Text;

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
    }
}
