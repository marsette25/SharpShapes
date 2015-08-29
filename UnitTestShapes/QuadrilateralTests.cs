using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class QuadrilateralTests
    {
        public class QuadTestClass : Quadrilateral
        {
            public override float Area()
            {
                throw new NotImplementedException();
            }
        }



        [TestMethod]
        public void TestQuadrilateralCanComputePerimeter()
        {
            QuadTestClass myQuadrilateral = new QuadTestClass();
            myQuadrilateral.Top = 2;
            myQuadrilateral.Right = 4;
            myQuadrilateral.Left = 99;
            myQuadrilateral.Bottom = 6;
            Assert.AreEqual(myQuadrilateral.Perimeter(), 111);
        }
    }
}
