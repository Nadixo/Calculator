namespace CalculatorClass.Classes
{
    public class Calculator
    {
        private double item = 0;

        public double Add(double a, double b)
        {
            item = a + b;
            return item;
        }
        public double Subtract(double a, double b)
        {
            item = a - b;
            return item;
        }
        public double Multiply(double a, double b)
        {
            item = a * b;
            return item;
        }
        public double Power(double x, double exp)
        {
            item = Math.Pow(x, exp);
            return item;
        }

        public double Divide(double dividend, double divisor)
        {
            
            if (divisor == 0)
            {
                Console.Write("Dont divide by 0 dumb cunt");
                return item;
            }
            else
            {
                item = dividend / divisor;
                return item;
            }
            
        }
        public double Accumulator
        {
            get
            {
                return item;
            }
            private set
            {
                item = value;
            }
        }

        public void Clear()
        {
            item = 0;
        }

        public double Add(double addend)
        {
            item += addend;
            return item;
        }

        public double Subtract(double subtractor)
        {
            item -= subtractor;
            return item;
        }

        public double Multiply(double multiplier)
        {
            item *= multiplier;
            return item;
        }

        public double Divide(double divisor)
        {
            item /= divisor;
            return item;
        }

        public double Power(double exponent)
        {
            item = Math.Pow(item, exponent);
            return item;
        }
    }
}