using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTests
    {
        public class RectangleTestClass : Square
        {
            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }

        [TestMethod]
            public void TestRectangleCanComputeArea()
            {
                RectangleTestClass myRectangle = new RectangleTestClass();
                myRectangle.length = 2;
                myRectangle.width = 2;
                Assert.AreEqual(myRectangle.Area(), 4);
            }
        }
    }

