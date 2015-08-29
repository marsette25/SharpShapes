using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {

        public float length { get; set; }
        public float width { get; set; } 

    public override float Area()
        {
            return this.length * this.width;
        }

    public override float Perimeter()
        {


                return (this.length * 2) + (this.width * 2);
        }


    }
}
