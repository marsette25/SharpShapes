using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;

namespace UnitTestShapes
{
    [TestClass]
    public class AbstractShapeTests
    {

        private class MyMockShape : Shape 
        {
            public override float Area()
            {
                throw new NotImplementedException();
            }

            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }

        MyMockShape omgMyShape = new MyMockShape();

        [TestMethod]
        public void TestingAbstractShapeClass()
        {
            omgMyShape.FillColor = Color.PapayaWhip;
            Assert.AreEqual(Color.PapayaWhip, omgMyShape.FillColor);
        }

        [TestMethod]
        public void TestThatAbstractShapeClassHasBorderColor()
        {
            omgMyShape.BorderColor = Color.NavajoWhite;
            Assert.AreEqual(Color.NavajoWhite, omgMyShape.BorderColor);
        }

    }
}
