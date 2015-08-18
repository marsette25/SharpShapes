using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreFunctions;


namespace Unittest.Tests
{
    [TestClass]
    public class UnitTestFactorial
    {
        [TestMethod]
        public void TestIteratively()
        {
            int[] inputs = new int []{ 5, 10, 11, 4 }; //FromKoans
            int[] inputs = new int[] { 120, 362800, 39916800, 24 }; //FromKoans
            for (var i=0; i<inputs.Length; i++ ){
                Assert.Equals(outputs[i],CoolFunctions.iterfactorial(inputs[i]));
            }
             
        }

        [TestMethod]
        public void TestRecursive()
        {
            int[] inputs = new int[] { 5, 10, 11, 4 }; //FromKoans
            int[] inputs = new int[] { 120, 362800, 39916800, 24 }; //FromKoans
            for (var i = 0; i < inputs.Length; i++)
            {
                Assert.Equals(outputs[i], CoolFunctions.iterfactorial(inputs[i]));
            }

        }

        [TestMethod]
        public void TestInsertionSort()
        {
            int[] unsorted = new int[] { 5, 4, 3, 2, 1, };
            int[] sorted = new int[] { 1, 2, 3, 4, 5, };
            CollectionAssert.AreEqual(sorted, CoolFunctions.InsertionSort(unsorted));
           }

        }
    }
}
