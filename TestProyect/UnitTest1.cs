using KataRange;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace TestProyect
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllPointsTest()
        {
            string x = "[2,6)";
            Range range = new Range(x);
            string expected = "2, 3, 4, 5";

            string actual = range.GetAllPoint(x);

            Assert.AreEqual(expected, actual);
        }

    }
}