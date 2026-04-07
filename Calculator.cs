namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int a,int b) => a + b;
        public int Subtact(int a,int b) => a - b;
        public int Divide(int a,int b) => b == 0 ? 0 : a / b;
    }
}