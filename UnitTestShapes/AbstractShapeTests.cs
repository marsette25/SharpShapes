using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;

namespace UnitTestShapes
{
    [TestClass]
    public class ShapeTest
    {
        public class ConcreteShape : Shapes.Shape
        {
            public ConcreteShape()
            {
                BorderColor = Color.DeepSkyBlue;
                FillColor = Color.Khaki;
            }
        }

        [TestMethod]
        public void TestAbstractShapeHasBorderColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Color.DeepSkyBlue, cs.BorderColor);
        }

        [TestMethod]
        public void TestAbstractShapeHasFillColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Color.Khaki, cs.FillColor);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasArea()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Area();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasPerimeter()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Perimeter();
        }

        [TestMethod]
        public void TestFindShapes()
        {
            List<string> classes = new List<string> { "Square", "Rectangle", "Shape"};
            CollectionAssert.AreEqual(classes, Assembly.GetAssembly(typeof(Shapes.Quadrilateral)).GetTypes());

        }

        [TestMethod]
        public void TestSquareIsASubClassOfRectangle()
        {
            Assert.IsTrue(typeof(Shapes.Square).IsSubclassOf(typeof(Shapes.Rectangle)));
        }

        [TestMethod]
        public void TestSquareIsASubClassOfQuadrilateral()
        {
            Assert.IsTrue(typeof(Shapes.Square).IsSubclassOf(typeof(Shapes.Quadrilateral)));
        }


    }
}