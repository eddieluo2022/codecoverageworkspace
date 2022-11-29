using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTestClass
    {
        [TestMethod]
        public void TestAdd()
        {
            CalculatorClass c = new CalculatorClass();
            Assert.AreEqual(10, c.Add(5, 5));
        }

        [TestMethod]
        public void TestSubtract()
        {
            CalculatorClass c = new CalculatorClass();
            Assert.AreEqual(0, c.Subtract(5, 5));
        }

        [TestMethod]
        public void TestMultiply()
        {
            CalculatorClass c = new CalculatorClass();
            Assert.AreEqual(25, c.Multiply(5, 5));
        }

        [TestMethod]
        public void TestDivide()
        {
            CalculatorClass c = new CalculatorClass();
            Assert.AreEqual(1, c.Divide(5, 5));
        }
    }
}
