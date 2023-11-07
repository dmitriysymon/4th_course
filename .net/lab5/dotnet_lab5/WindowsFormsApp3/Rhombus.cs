using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    public class Rhombus
    {
        public int a { get; set; }
        public int b { get; set; }

        public Rhombus()
        {
            a = 0;
            b = 0;
        }
        public Rhombus(int a, int b)
        {
            this.a=a;
            this.b=b;
        }

    }
}
