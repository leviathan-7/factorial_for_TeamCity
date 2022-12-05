using Microsoft.VisualStudio.TestTools.UnitTesting;
using factorial;

namespace UnitTestProject1
{
    [TestClass]
    public class factorialTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.factorial(1), 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Program.factorial(5), 120);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Program.factorial(0), 1);
        }
    }
}
