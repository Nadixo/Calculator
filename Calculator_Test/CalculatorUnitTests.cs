using NUnit.Framework;
using CalculatorClass.Classes;
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

        [TestCase(-1, 1, 0)]
        [TestCase(-3.25, 4.25, 1)]
        [TestCase(5, 1, 6)]
        [TestCase(6, 1, 7)]
        public void Add_Test1(double a, double b, double ans)
        {
            Assert.AreEqual(ans, calculator.Add(a, b));
        }

        [TestCase(-1, 1, -2)]
        [TestCase(-3.25, 4.2, -7.45)]
        [TestCase(5, 1, 4)]
        public void Subtract_Test1(double a, double b, double ans)
        {
            Assert.AreEqual(ans, calculator.Subtract(a, b));
        }

        [TestCase(-1, 1, -1)]
        [TestCase(-3.25, 4.1, -13.325)]
        [TestCase(5, 1, 5)]
        public void Multiply_Test1(double a, double b, double ans)
        {
            Assert.AreEqual(ans, calculator.Multiply(a, b));
        }

        [TestCase(-1, 1, -1)]
        [TestCase(-3, 4, 81)]
        [TestCase(5, 1, 5)]
        public void Power_Test1(double a, double b, double ans)
        {
            Assert.AreEqual(ans, calculator.Power(a, b));
        }


        [TestCase(1, 4)]
        [TestCase(1, 1)]
        [TestCase (24,4123)]
        public void Divide_Test1(double a, double b)
        {
            Assert.AreEqual(a/b, calculator.Divide(a, b));
        }

        [TestCase(2)]
        [TestCase(5)]
        [TestCase(8)]
        public void Clear_Test1(double a)
        {
            calculator.Accumulator = a;
            calculator.Clear();
            Assert.AreEqual(calculator.Accumulator, 0);
        }

        [TestCase(-1)]
        [TestCase(-3.25)]
        [TestCase(5)]
        [TestCase(6)]
        public void Accumulator_Add_Test1(double a)
        {
            calculator.Accumulator = 2;
            Assert.AreEqual(a + calculator.Accumulator, calculator.Add(a));
        }

        [TestCase(-3)]
        [TestCase(5)]
        [TestCase(7)]
        public void Accumulator_Subtract_Test1(double a)
        {
            calculator.Accumulator = 2;
            Assert.AreEqual(calculator.Accumulator - a, calculator.Subtract(a));
        }

        [TestCase(2)]
        [TestCase(7)]
        [TestCase(11)]
        public void Accumulator_Multiply_Test1(double a)
        {
            calculator.Accumulator = 2;
            Assert.AreEqual(calculator.Accumulator * a, calculator.Multiply(a));
        }

        [TestCase(-1)]
        [TestCase(5)]
        [TestCase(10)]
        public void Accumulator_Divide_Test1(double a)
        {
            calculator.Accumulator = 2;
            Assert.AreEqual(calculator.Accumulator / a, calculator.Divide(a));
        }

        [TestCase(-8)]
        [TestCase(1)]
        [TestCase(9)]
        public void Accumulator_Power_Test1(double a)
        {
            calculator.Accumulator = 2;
            Assert.AreEqual(Math.Pow(calculator.Accumulator, a), calculator.Power(a));
        }
    }
}