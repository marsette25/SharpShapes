using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTests
    {

        [TestMethod]
        public void TestSquareCanComputeArea()
        {
            Square mySquare = new Square();
            mySquare.length = 6;
            mySquare.width = 6;
            Assert.AreEqual(mySquare.Area(), 36);
        }

        [TestMethod]
        public void TestSquareCanComputePerimeter()
        {
            Square mySquare = new Square();
            mySquare.length = 3;
            mySquare.width = 5;
            Assert.AreEqual(mySquare.Perimeter(), 16);
        }
    }
}

