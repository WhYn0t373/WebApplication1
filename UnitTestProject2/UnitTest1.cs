using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest
    {
        private const string expected10 = "55";

        [TestMethod]
        public void FiboTest()
        {
            WebRequest request = WebRequest.Create(@"https://localhost:44352/Services/Fibo.asmx?op=Fibonacci&n=10");
            request.Method = "GET";
            WebResponse response = request.GetResponse();

            Assert.AreEqual(expected10, response);
        }
    }
}
