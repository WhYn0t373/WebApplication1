using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Services;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private const string expected10 = "55";

        [TestMethod]
        public void FiboTest()
        {
            Fibo fibo = new Fibo();
            string result10 = fibo.Fibonacci(10);

            Assert.AreEqual(expected10, result10);
        }
    }
}
