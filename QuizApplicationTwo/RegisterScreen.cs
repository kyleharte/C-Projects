using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuizApplicationTwo
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_new_user_Click(object sender, EventArgs e)
        {
            string filePath = @"users.txt";
            FileStream aFile;
            StreamWriter sw;

            try
            {
                if (!File.Exists(filePath))
                {
                    aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                } else
                {
                    aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                }
               
            }
            catch 
            {
                MessageBox.Show("User failed to add", "Error Occured");
                aFile = null;

            }
            sw = new StreamWriter(aFile);
            string userName = Username.Text;
            string passWord = Password.Text;
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                sw.WriteLine(userName + "~" + passWord);
                sw.Close();
                aFile.Close();

            } else
            {
                MessageBox.Show("Username and password must not be empty", "Username or Password Missing");
            }
            
        }
    }
}
