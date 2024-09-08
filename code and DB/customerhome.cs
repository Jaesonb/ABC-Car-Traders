using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class customerhome : Form
    {
        public customerhome()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel2.Height = button12.Height;
            panel2.Top = button12.Top;
            uc_customercar1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Height = button11.Height;
            panel2.Top = button11.Top;
            uc_customercarparts1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Height = button9.Height;
            panel2.Top = button9.Top;
            uc_customerorderstatus1.BringToFront();
        }
    }
}
