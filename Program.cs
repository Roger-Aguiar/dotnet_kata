using System;
using SumOfLowesIntegers;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTwoLowestIntegers sum = new SumOfTwoLowestIntegers();
            int[] numbers = {20, 8, 15, 7, 99, 3, 78};
            Console.WriteLine("The sum of the two lowest number of the array is " + sum.SumTwoSmallestNumbers(numbers));
        }
    }
}
