using MandatoryAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 obj1 = new Class1();
            double result = obj1.ConvertionGramToOunce(28.3495231);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 obj2 = new Class1();
            double result = obj2.ConvertionOunceToGram(1);
            Assert.AreEqual(28.3495231, result);
        }
    }
}
