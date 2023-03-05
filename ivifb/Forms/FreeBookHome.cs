using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ivifb.Forms;
using FreeBook;

namespace ivifb
{
    public partial class FreeBookHome : Form
    {
        public FreeBookHome()
        {
            InitializeComponent();
            Load += new EventHandler(FreeBookHome_Load);
        }

        private void FreeBookHome_Load(object sender, EventArgs e)
        {
            DatabaseHelper.Initialisation();
        }
        private void inregBTN_Click(object sender, EventArgs e)
        {
            var page = new CreareContFreeBook();
            page.ShowDialog(this);
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            var page = new LogareFreeBook();
            page.ShowDialog(this);
        }
    }
}
