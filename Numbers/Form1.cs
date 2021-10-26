using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inte_Click(object sender, EventArgs e)
        {
            int x = 10;
            MessageBox.Show(x.ToString());
        }

        private void flt_Click_1(object sender, EventArgs e)
        {
            float f = 10232.3223F;
            MessageBox.Show(f.ToString());
        }

        private void dbl_Click(object sender, EventArgs e)
        {
            double d = 20.43;
            MessageBox.Show(d.ToString());
        }
    }
}
