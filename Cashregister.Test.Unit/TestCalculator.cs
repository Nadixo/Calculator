using CalculatorClass.Classes;

namespace CalculatorClass.Test.Unit
{
    public class TestCalculator
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            Calculator utt = new Calculator();

            Assert.That(utt.Add(12.5,5), Is.EqualTo(17.5));
        }

        [Test]
        public void Subtract()
        {
            Calculator utt = new Calculator();

            Assert.That(utt.Subtract(12.5,5), Is.EqualTo(7.5));
        }

        [Test]
        public void Multiply()
        {
            Calculator utt = new Calculator();

            Assert.That(utt.Multiply(2,2), Is.EqualTo(4));
        }
        [Test]
        public void Pow()
        {
            Calculator utt = new Calculator();

            Assert.That(utt.Multiply(2, 2), Is.EqualTo(4));
        }

    }
       

}