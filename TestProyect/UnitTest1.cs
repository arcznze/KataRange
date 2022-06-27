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
        public void endPointsTest()
        {
            string x = "(5,12)";
            Range range = new Range(x);
            string expected = "{6,11}";

            string actual = range.endPoints(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContainsTest()
        {
            string x = "(9,10]";
            string y = "7, 8";
            Range range = new Range(x);
            bool expected = false;

            bool actual = range.Contains(x,y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContainsRangeTest()
        {
            string x = "[2,10]";
            string y = "(5,8]";
            Range range = new Range(x);
            bool expected = true;

            bool actual = range.ContainsRange(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}