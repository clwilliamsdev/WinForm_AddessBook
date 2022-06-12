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
using AddessBook_V1.Libraries;

namespace AddessBook_V1
{
    public partial class AddressBook : Form
    {
        public static string dbDetail;
        public static int position;
        public static string lName;
        public static string fName;

        public AddressBook()
        {
            InitializeComponent();

        }
        public void Main_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            SQLiteConnection conn = new SQLiteConnection("Data Source=./AddressBookDB.sqlite3");
            conn.Open();
            string load = "SELECT LastName, FirstName FROM AddressBook ORDER BY LastName ASC, FirstName ASC";
            SQLiteDataAdapter da = new SQLiteDataAdapter(load, conn);
            DataSet ds = new DataSet();
            ds.Reset();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            AddressListDisplay.DataSource = dt;
            conn.Close();

            
            DataGridViewColumn column = AddressListDisplay.Columns[0];
            column.Width = 72;
            DataGridViewColumn column1 = AddressListDisplay.Columns[1];
            column.Width = 72;
        }

   

        private void NewBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            NewAddress newAddress = new NewAddress();
            newAddress.ShowDialog();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAddress viewAddress = new ViewAddress();
            viewAddress.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lName = AddressListDisplay.Rows[e.RowIndex].Cells[0].Value.ToString();
            fName = AddressListDisplay.Rows[e.RowIndex].Cells[1].Value.ToString();
            position = AddressListDisplay.CurrentCell.RowIndex;
            Console.WriteLine(position);
            Console.WriteLine(lName);
            Console.WriteLine(fName);
        }
    }
}
