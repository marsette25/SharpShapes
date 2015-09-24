using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public abstract class AShape : IShape
    {

        public Color FillColor { get; protected set; }
        public Color BorderColor { get; protected set; }

        // Comes from the ConcreteShape class in ShapeTest.
        public AShape()
        {
            BorderColor = Color.DeepSkyBlue;
            FillColor = Color.Khaki;
        }


        public virtual float Area() { throw new NotImplementedException(); }
        public virtual float Perimeter() { throw new NotImplementedException(); }
    }
}
