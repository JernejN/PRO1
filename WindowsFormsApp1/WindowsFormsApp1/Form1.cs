using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            if (rdSec.Checked == true)
                textBox3.Text = "" + (a + b);
            if (rdOds.Checked == true)
                textBox3.Text = "" + (a - b);
            if (rdMno.Checked == true)
                textBox3.Text = "" + (a * b);
            if (rdDel.Checked == true)
                textBox3.Text = "" + (a / b);
            if (rdOds.Checked == true && double.Parse(textBox3.Text) < 0)
                textBox3.ForeColor = Color.Red;
            else
                textBox3.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
