using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtros
{
    public partial class Form1 : Form
    {
        Image image;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            image = Image.FromFile(@"C:\Users\Acer\Desktop\Filtros\Filtros\SonicFlor.png");
            bmp = (Bitmap)image;
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bmp, 0, 0, 300, 256);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BNButton_Click(object sender, EventArgs e)
        {
            
            Color p;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;

                    int teemp;
                    if (avg > 128)
                    {
                        teemp = 255;
                    }
                    else
                    {
                        teemp = 0;
                    }
                    bmp.SetPixel(x, y, Color.FromArgb(a, teemp, teemp, teemp));
                }
            }
            Invalidate();
        }
        private void NButton_Click(object sender, EventArgs e)
        {
            
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
                    Color ncolor = Color.FromArgb(color.A, 255-color.R, 255-color.G, 255-color.B);
                    bmp.SetPixel(x, y, ncolor);
                }
            }
            Invalidate();
        }
        
        private void GButton_Click(object sender, EventArgs e)
        {
            
            Color p;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));

                }
            }
            Invalidate();
        }

        private void SButton_Click(object sender, EventArgs e)
        {
            Color p;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int tr = (int)(0.393 * r + 0.796 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }
                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }
                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }

            }
            Invalidate();
        }

        private void RButton_Click(object sender, EventArgs e)
        {

            image = Image.FromFile(@"C:\Users\Acer\Desktop\Filtros\Filtros\SonicFlor.png");
            bmp = (Bitmap)image;
            Invalidate();
        }
    }
}
