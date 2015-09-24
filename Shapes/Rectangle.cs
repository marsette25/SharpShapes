using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        //add constructors for rectangles
        public Rectangle() : base() { }
        public Rectangle(float length, float width) : base( length, length, width, width) {}


        //public float length { get; set; }
        //public float width { get; set; } 
        /// <summary>
        ///calucates area for a shape
        /// </summary>
        /// <returns> area as a float. this is an example of documentation.</returns>
        public override float Area()
        {
            if (Top == 0 || Left == 0)
            { throw new ArgumentException(); }
            else
            {
                return Top * Left;
            }
        }

        public override float Perimeter()
        {
            if (Top == 0.0 || Bottom == 0.0 || Left == 0.0 || Right == 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                return Top + Bottom + Left + Right;
            }

        }


    }
}
