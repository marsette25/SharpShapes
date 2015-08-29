using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTests
    {

        [TestMethod]
            public void TestRectangleCanComputeArea()
            {
                Rectangle myRectangle = new Rectangle();
                myRectangle.length = 2;
                myRectangle.width = 2;
                Assert.AreEqual(myRectangle.Area(), 4);
            }

           [TestMethod]
            public void TestRectangleCanComputePerimeter()
            {
                Rectangle myRectangle = new Rectangle();
                myRectangle.length = 5;
                myRectangle.width = 10;
                Assert.AreEqual(myRectangle.Perimeter(), 30);
            }
        }
    }



