namespace CalculatorClass.Classes
{
    public class Calculator
    {


        public double Add(double a, double b)
        {
            double item = a + b;
            return item;
        }
        public double Subtract(double a, double b)
        {
            double item = a - b;
            return item;
        }
        public double Multiply(double a, double b)
        {
            double item = a * b;
            return item;
        }
        public double Power(double x, double exp)
        {
            double item = Math.Pow(x, exp);
            return item;
        }


    }
}