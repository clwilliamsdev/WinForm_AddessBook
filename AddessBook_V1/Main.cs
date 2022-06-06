using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddessBook_V1.Libraries;

namespace AddessBook_V1
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            
        }
        public void Main_Load(object sender, EventArgs e)
        {
            Database db = new Database();
        }
    }
}
