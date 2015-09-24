using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Shapes
{
    public class Square : Rectangle
    {
        private int v;

        // constructors
        public Square() : base() { }

        public Square(int v)
        {
            this.v = v;
        }

        public Square(float top, float bottom, float left, float right) : base()
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }

        // methods
        public override float Area()
        {
            if (Top == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return this.Top * this.Left;
            }

        }

        public override float Perimeter()
        {
            if (Top == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return this.Top * 4;
            }


        }
    }
}
