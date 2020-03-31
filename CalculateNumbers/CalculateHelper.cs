using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateNumbers
{
    public class CalculateHelper
    {
        public bool Calculate(int[] numbers, int critera)
        {
            bool result = false;
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        continue;
                    }
                    if (Sum(numbers[j], numbers[i]) == critera)
                    {
                        return true;
                    }
                }
            }
            return result;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
