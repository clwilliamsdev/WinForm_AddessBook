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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void ClrDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("This will delete all data in the table. Do you want to proceed?", "Delete Table Data",
                MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
                conn.Open();
                string tbl = "DELETE FROM AddressBook ";
                SQLiteCommand command = new SQLiteCommand(tbl, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data has been Deleted");
            }
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
