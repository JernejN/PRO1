using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fotografije
{
    public partial class Form1 : Form
    {
        Bitmap Original = new Bitmap("D:\\PRO1\\Testnaslika.png");
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void BtnOdpri_Click(object sender, EventArgs e)
        {
            DialogResult a = openFileDialog1.ShowDialog();
            if (a != DialogResult.OK)
            {
                return;
            }
            string imeDatoteke = openFileDialog1.FileName;
            Original = new Bitmap(imeDatoteke);
            pictureBox1.Image = Original;
            PosodobiSliko();
        }
        public void NastaviDrs()
        {
            if (pictureBox1.Width > Original.Width)
            {
                hScrollBar1.Visible = false;
            }
            else
            {
                hScrollBar1.Visible = true;
                hScrollBar1.Maximum = Original.Width - pictureBox1.Width;
            }
            if (pictureBox1.Height > Original.Height)
            {
                vScrollBar1.Visible = false;
            }
            else
            {
                vScrollBar1.Visible = true;
                vScrollBar1.Maximum = Original.Height - pictureBox1.Height;
            }
        }
        public void PosodobiSliko()
        {
            NastaviDrs();
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle p1 = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            Rectangle p2 = new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox1.Width, pictureBox1.Height);
            g.DrawImage(Original, p1, p2, GraphicsUnit.Pixel);
            pictureBox1.Update();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PosodobiSliko();
        }

        private void zrcaliNavpičnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < Original.Width / 2; x++)
            {
                for (int y = 0; y < Original.Height; y++)
                {
                    Color barva = Original.GetPixel(x, y);
                    Original.SetPixel(Original.Width - x - 1, y, barva);
                }
            }
        }

        private void zrcaliVodoravnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < Original.Width; x++)
            {
                for (int y = 0; y < Original.Height / 2; y++)
                {
                    Color barva = Original.GetPixel(x, y);
                    Original.SetPixel(x, Original.Height - y - 1, barva);
                }
            }
        }

        private void filtriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < Original.Width; x++)
            {
                for (int y = 0; y < Original.Height; y++)
                {
                    Color barva = Original.GetPixel(x, y);
                    int r = 255 - barva.R;
                    int g = 255 - barva.G;
                    int b = 255 - barva.B;
                    barva = Color.FromArgb(r, g, b);
                    Original.SetPixel(x, y, barva);
                }
                PosodobiSliko();
            }
        }

        private void za90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Original.RotateFlip(RotateFlipType.Rotate90FlipX);
            PosodobiSliko();
        }
    }
}
