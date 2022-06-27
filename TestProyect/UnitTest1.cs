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
            string x = "(2,10]";
            Range range = new Range(x);
            string expected = "3, 4, 5, 6, 7, 8, 9, 10";

            string actual = range.GetAllPoint(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void endPoints()
        {
            string x = "(5,12)";
            Range range = new Range(x);
            string expected = "{6,11}";

            string actual = range.endPoints(x);

            Assert.AreEqual(expected, actual);
        }

    }
}