using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTests
    {
        public class SquareTestClass : Square
        {
            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }
        [TestMethod]
        public void TestSquareCanComputeArea()
        {
            SquareTestClass mySquare = new SquareTestClass();
            mySquare.length = 6;
            mySquare.width = 6;
            Assert.AreEqual(mySquare.Area(), 36);
        }
    }
}

