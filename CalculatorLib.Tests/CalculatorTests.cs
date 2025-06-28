using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLib.Tests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            var result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            var result = _calculator.Subtract(2, 3);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {
            var result = _calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(1, 0));
        }
    }
}
