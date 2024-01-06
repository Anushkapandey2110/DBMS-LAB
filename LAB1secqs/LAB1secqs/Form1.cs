using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1secqs
{
    public partial class Form1 : Form
    {
        
        
        string finalmsg;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb1.Items.Add("First Year");
            cb1.Items.Add("Second Year");
            cb1.Items.Add("Third Year");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            string name = Console.ReadLine();
            this.textbox1.Text = name;


        }

        private void regno_Click(object sender, EventArgs e)
        {

            string regno =Console.ReadLine();
            this.textbox2.Text = regno;
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            checkbox1.ThreeState = true;
            if (checkbox1.Checked == true)
                finalmsg = "confirmed";
            else if (checkbox1.Checked == false)
                finalmsg = "not confirmed";

        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.messagebox.Text = finalmsg;

        }
    }
}
