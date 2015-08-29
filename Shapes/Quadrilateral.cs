using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape
    {
        public float Top { get; set; }
        public float Right { get; set; }
        public float Left { get; set; }
        public float Bottom { get; set; }

        public abstract override float Area();

        public override float Perimeter()
        {
            return this.Top + this.Right + this.Left + this.Bottom;
            
        }
    }
}
