using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string Op1 = string.Empty;
        string Op2 = string.Empty; 
        char Operator; 
        double res = 0.0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;

        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text = input;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text = input;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text = input;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text = input;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text = input;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text = input;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text = input;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            {
Op1 = input;
Operator = '+';
this.textBox1.Text = input +"+";
input = string.Empty;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            this.textBox1.Text = input + "-";
           
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            {
Op1 = input;
Operator = '/';
this.textBox1.Text = input + "/";
input = string.Empty;
}
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            {
Op1 = input;
Operator = '*';
this.textBox1.Text = input + "x";
input = string.Empty;
}
        }
        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = string.Empty;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 's';
        }

        private void sin_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'S';

        }

        private void cos_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'c';

        }

        private void tan_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 't';
        }

        private void equal_Click(object sender, EventArgs e)
        {
          Op2 = input;
double num1, num2;
double.TryParse(Op1, out num1);
double.TryParse(Op2, out num2);
if (Operator == '+')
{
res = num1 + num2;
this.textBox1.Text = res.ToString();
}
else if (Operator == '-')
{
res = num1 - num2;
textBox1.Text = res.ToString();
}
else if (Operator == '*')
{
res = num1 * num2;
textBox1.Text = res.ToString();
}
else if (Operator == 's')
{
    res = Math.Sqrt(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 'S')
{
    res = Math.Sin(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 'c')
{
    res = Math.Cos(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 't')
{
    res = Math.Tan(num1);
    textBox1.Text = res.ToString();
}

            else if (Operator == '/')
{
if (num2 != 0)
{
res = num1 / num2;
textBox1.Text = res.ToString();
}
else
{
textBox1.Text = "DIV/Zero!";
}
             

}
input = string.Empty;



        }

       

        
    }
    
}
