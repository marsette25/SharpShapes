using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class AQuadrilateral : Shape
    {
        // Calls Shape's Constructor that provides default fill and border colors.
        public AQuadrilateral() : base() { }

        // Shape's Constructor is called BEFORE the supplied code block.
        public AQuadrilateral(float top, float bottom, float left, float right) : base()
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }
        private float bottom;
        private float top;
        private float left;
        private float right;

        public float Top
        {
            get { return top; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    top = value;
                }
            }
        }

        public float Bottom
        {
            get { return bottom; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    bottom = value;
                }
            }
        }

        public float Left
        {
            get { return left; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    left = value;
                }
            }
        }
        public float Right
        {
            get { return right; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    right = value;
                }
            }
        }

        public abstract override float Area();
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
