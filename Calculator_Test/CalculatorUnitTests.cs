using NUnit.Framework;
using Lab1;
using System;

namespace Calculator_Test
{
    public class CalculatorUnitTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(-1, 1)]
        [TestCase(-3.25, 4.1)]
        [TestCase(5, 1)]
        public void Add_Test1(double a, double b)
        {
            Assert.AreEqual(a + b, calculator.Add(a, b));
        }

        [TestCase(-1, 1)]
        [TestCase(-3.25, 4.1)]
        [TestCase(5, 1)]
        public void Subtract_Test1(double a, double b)
        {
            Assert.AreEqual(a - b, calculator.Subtract(a, b));
        }

        [TestCase(-1, 1)]
        [TestCase(-3.25, 4.1)]
        [TestCase(5, 1)]
        public void Multiply_Test1(double a, double b)
        {
            Assert.AreEqual(a * b, calculator.Multiply(a, b));
        }

        [TestCase(-1, 1)]
        [TestCase(-3.25, 4.1)]
        [TestCase(5, 1)]
        public void Power_Test1(double a, double b)
        {
            Assert.AreEqual(Math.Pow(a, b), calculator.Power(a, b));
        }
    }
}