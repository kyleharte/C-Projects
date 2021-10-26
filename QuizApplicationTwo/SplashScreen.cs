using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplicationTwo
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            Timer t;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);

            label1.Text = "Loading " + progressBar1.Value + "%";
            if (progressBar1.Value >= progressBar1.Maximum){
                timer1.Stop();
                Hide();
                new LoginScreen().Show();
            }
        }
    }
}
