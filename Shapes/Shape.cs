using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;


namespace Shapes
{
    public abstract class Shape : IShape
    {
        // We need info about colors
        // Below C# is creating the data members for us. Yaaay!
        //Color fillColor;
        //Color borderColor;

        /// <summary>
        /// "protected set" allows for child classes to use the setter!
        /// </summary>
        public Color FillColor { get; protected set; }
        public Color BorderColor { get; protected set; }

        // Comes from the ConcreteShape class in ShapeTest.
        public Shape()
        {
            BorderColor = Color.DeepSkyBlue;
            FillColor = Color.Khaki;
        }

        public virtual void DrawOnto(Canvas theCanvas, int x, int y) { throw new NotImplementedException();  }
        public virtual void Scale(int percent) { throw new NotImplementedException(); }
        public virtual float Area() { throw new NotImplementedException(); }
        public virtual float Perimeter() { throw new NotImplementedException(); }

        public class Rectangle
        {
        }
    }
}