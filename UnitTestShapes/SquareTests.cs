using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;
namespace UnitTestShapes
{
    [TestClass]
    public class SquareTests
    { 
    [TestMethod]
    public void TestSquareConstructor()
    {
        // test that sides are set to 0 by default if a value is not specified
        Square mySquare = new Square();
        Assert.AreEqual(0, mySquare.Top);
    }

   
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestSquareConstructor2()
    {
        // test that you cannot set a side to be a negative or zero value
        Square square = new Square();
        square.Top = -2;
    }


 

    [TestMethod]
    public void TestSquareComputePerimeter()
    {
        Square mySquare = new Square(10);
        mySquare.Top = 5;
        Assert.AreEqual(20, mySquare.Perimeter());
    }

    [TestMethod]
    public void TestSquareDefaultColors()
    {
        Square square = new Square();
        Assert.AreEqual(Color.DeepSkyBlue, square.BorderColor);
        Assert.AreEqual(Color.Khaki, square.FillColor);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestSquareAreaIsZero()
    {
        Square square = new Square();
        square.Area();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestSquarePerimeterIsZero()
    {
        Square square = new Square();
        square.Perimeter();
    }

        //[TestMethod]
        //public void TestSquareArea()
        //{
        //    Square mySquare = new Square();
        //    mySquare.Top = 5;
        //    mySquare.Left = 5;
        //    Assert.AreEqual(25, mySquare);
        //}
    }


}
