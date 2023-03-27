using System.Drawing;
using System.Windows.Forms;

namespace StirivVrsto
{
    public partial class Form1 : Form
    {
        int[,] stanje = {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 2, 0, 0, 0 },
            { 0, 1, 2, 1, 2, 0, 0 },
            { 1, 1, 2, 2, 1, 2, 0 },

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            NarisiVodoravne(g);
            narisiVpicne(g);
            NarisiKrozce(g);
        }

        private void NarisiVodoravne(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            int y = 0;
            for (int i = 0; i <= 5; i++)
            {
                g.DrawLine(p, 0, y, 7 * 100, y);
                y += 100;
            }
        }

        private void narisiVpicne(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            int x = 0;
            for (int i = 0; i <= 7; i++)
            {
                g.DrawLine(p, x, 0, x, 5 * 100);
                x += 100;
            }
        }

        private void NarisiKrozce(Graphics g)
        {
            int y = 0;
            for (int i = 0; i < 5; i++)
            {
                int x = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (stanje[i, j] == 1)
                    {
                        Brush br = new SolidBrush(Color.Red);
                        g.FillEllipse(br, x, y, 100, 100);
                    }
                    if (stanje[i, j] == 2)
                    {
                        Brush br = new SolidBrush(Color.Green);
                        g.FillEllipse(br, x, y, 100, 100);
                    }
                    x += 100;
                }
                y += 100;
            }
        }
    }
}
