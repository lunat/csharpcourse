namespace CalculatorLib
{
    public class Calculator
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public int Divide(int a, int b)
        {
            return DivideMe(a, b);
        }

        private int DivideMe(int i, int i1)
        {
            return i / i1;
        }
    }
}