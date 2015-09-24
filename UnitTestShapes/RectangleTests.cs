using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;
using System.Reflection;
using System.Linq;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTests
    {
            [TestMethod]
            public void TestRectangleConstructor()
            {
                // test that sides are set to 0 by default if a value is not specified
                Shapes.Rectangle rect = new Shapes.Rectangle();
                Assert.AreEqual(0, rect.Top);
            }

            [TestMethod]
            public void TestRectangleConstructor2()
            {
                // test that top and left are set by constructor
                Shapes.Rectangle rect = new Shapes.Rectangle(5, 3);
                Assert.AreEqual(5, rect.Top);
                Assert.AreEqual(3, rect.Left);
            }

            [TestMethod]
            public void TestRectangleConstructor3()
            {
                // test that top and left are set by setter
                Shapes.Rectangle rect = new Shapes.Rectangle();
                rect.Top = 5;
                rect.Left= 3;
                Assert.AreEqual(5, rect.Top);
                Assert.AreEqual(3, rect.Left);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void TestRectangleConstructorNegativeValue1()
            {
                Shapes.Rectangle rect = new Shapes.Rectangle(4, -2);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void TestRectangleConstructorNegativeValue2()
            {
                Shapes.Rectangle rect = new Shapes.Rectangle(-4, 2);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void TestRectangleSetterNegativeValue()
            {
                // test that you cannot set a side to be a negative or zero value
                Shapes.Rectangle rect = new Shapes.Rectangle();
                rect.Top = -2;
            }

            [TestMethod]
            public void TestRectangleComputeArea()
            {
                Shapes.Rectangle myRectangle = new Shapes.Rectangle(6, 10);
                Assert.AreEqual(60, myRectangle.Area());
            }

            [TestMethod]
            public void TestRectangleComputePerimeter()
            {
                Shapes.Rectangle myRectangle = new Shapes.Rectangle(5, 10);
                Assert.AreEqual(30, myRectangle.Perimeter());
            }

            [TestMethod]
            public void TestRectangleDefaultColors()
            {
                Shapes.Rectangle rect = new Shapes.Rectangle();
                Assert.AreEqual(Color.DeepSkyBlue, rect.BorderColor);
                Assert.AreEqual(Color.Khaki, rect.FillColor);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void TestRectanglePerimeterIsZero()
            {
                Shapes.Rectangle rect = new Shapes.Rectangle();
                rect.Perimeter();
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void TestRectangleAreaIsZero()
            {
                Shapes.Rectangle rect = new Shapes.Rectangle();
                rect.Area();
            }

        [TestMethod]
        public void TestCorrectNumberofArguments()
        {
            var theClass = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == "Rectangle").First(); // This is a Collection. Get the First
            var theClassConstructor = theClass.GetConstructors().First();
            Assert.AreEqual(2, theClassConstructor.GetParameters().Length);
        }
    }
    }