using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {

        public float length { get; set; }
        public float width { get; set; }

        public override float Area()
        {
            return this.length * this.width;
        }


    }
}
