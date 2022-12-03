using ClassLibrary;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(ClassPrimeFactors.PrimeFactors(4324), "2x2x23x47");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(ClassPrimeFactors.PrimeFactors(0), "Number must be more than 2");// Как сделать проверку на throw
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(ClassPrimeFactors.PrimeFactors(-1), "Number must be more than 2");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(ClassPrimeFactors.PrimeFactors(2), "2");
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(ClassPrimeFactors.PrimeFactors(431341241), "23x251x74717");
        }
    }
}