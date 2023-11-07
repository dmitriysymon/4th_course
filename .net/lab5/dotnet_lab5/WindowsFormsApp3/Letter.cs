using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp3
{
    [Serializable]
    public class Rhombus
    {
        public int a { get; set; }
        public int b { get; set; }
        public Rhombus(int a, int b)
        {
            this.a = a; this.b = b;
        }
        public Rhombus()
        {
            a = 0; b = 0;
        }
        //public void Draw(Pen p, Brush br, Graphics g, int x, int y)
        //{
        //    Brush Beye = new SolidBrush(Color.Blue);
        //    int A = (int)a;
        //    int B = (int)b;
        //    g.DrawLine(p, x, y, A, B);
        //    g.DrawLine(p)
        //}
    }
}
