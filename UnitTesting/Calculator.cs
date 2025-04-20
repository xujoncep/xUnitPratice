namespace CalculatorApp
{
    public class Calculator : ICalculator
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Divison(int x, int y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new Exception("Divisor cannot be zero");
            }
        }
    }
}
