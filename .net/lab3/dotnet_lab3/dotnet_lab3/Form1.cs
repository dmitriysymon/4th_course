using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_lab3
{
    public partial class Form1 : Form
    {
        Form form;
        public Form1()
        {
            InitializeComponent();
            form = this;
        }
        class Pentagon
        {
            private int sideLength;
            public Pentagon(int sideLength)
            {
                this.sideLength = sideLength;
            }

            public void DrawPentagon(Graphics g, int centerX, int centerY)
            {
                Point[] points = new Point[5];


                for (int i = 0; i < 5; i++)
                {
                    double angle = 2 * Math.PI / 5 * i;
                    int px = (int)(centerX + sideLength * Math.Cos(angle));
                    int py = (int)(centerY + sideLength * Math.Sin(angle));
                    points[i] = new Point(px, py);
                }

                g.DrawPolygon(Pens.Black, points);
                sideLength -= 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Pentagon pentagon = new Pentagon(100);
        int CenterX = 200;
        private void button_draw_Click(object sender, EventArgs e)
        {
            using (Graphics g = form.CreateGraphics())
            {
                pentagon.DrawPentagon(g, CenterX, 200);
                CenterX += 50;
            }
        }
    }
}
