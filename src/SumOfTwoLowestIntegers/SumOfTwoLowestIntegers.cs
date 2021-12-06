using System;

namespace SumOfLowesIntegers
{
    public class SumOfTwoLowestIntegers
    {
        public int SumTwoSmallestNumbers(int [] numbers)
        {
            Array.Sort(numbers);
            return numbers[0] + numbers[1];               
        }
    }
}