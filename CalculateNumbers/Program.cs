using System;

namespace CalculateNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateHelper helper = new CalculateHelper();
            Console.WriteLine("Hello World!");
            int[] arrayNumbers = { 1, 3, 4, 5, 7 };
            int input = 12;
            bool result = helper.Calculate(arrayNumbers, input);
            Console.WriteLine(string.Format("Result {0}", result.ToString()));
        }
    }
}
