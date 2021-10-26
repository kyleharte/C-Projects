using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int firstNumber;
        int secondNumber;
        bool plusPressed;
        bool multiplyPressed;
        bool dividePressed;
        bool subtractPressed;
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusPressed = true;
        }
        // Operator methods
        private int add(int num1, int num2)
        {
            return num1 + num2;
        }
        private int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        private double divide( int num1, int num2)
        {
            return num1 / num2;
        }
        private int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnEquals1_Click(object sender, EventArgs e)
        {
            secondNumber = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            int num;
            if(plusPressed)
            {
                num = add(firstNumber, secondNumber);
                plusPressed = false ;
            }
            else if(subtractPressed)
            {
                num = subtract(firstNumber, secondNumber);
                subtractPressed = false;
            }else if (multiplyPressed)
            {
                num = multiply(firstNumber, secondNumber);
                multiplyPressed = false;
            } else if (dividePressed)
            {
                num = (int) divide(firstNumber, secondNumber);
                dividePressed = false;
            }
            else { num = 0; }
            
            
            txtDisplay.Text = num.ToString();
            firstNumber = 0;
            secondNumber = 0;

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            subtractPressed = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            multiplyPressed = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            dividePressed = true;
        }
    }
}
