using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = colorDialog1.ShowDialog();
            if (a == DialogResult.OK)
                txt_vnos.ForeColor = colorDialog1.Color;
        }

        private void btn_pisava_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = fontDialog1.ShowDialog();
            if (a == DialogResult.OK)
                txt_vnos.Font = fontDialog1.Font;
        }
    }
}
