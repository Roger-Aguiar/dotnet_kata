using Xunit;

using SumOfLowesIntegers;

public class SumOfTwoLowestIntegersTest
{
    SumOfTwoLowestIntegers sum = new SumOfTwoLowestIntegers();    

    [Fact]
    public void SumTwoSmallestNumbers_ReturnsSum()
    { 
        int[] numbers = {5, 8, 12, 19, 22};               
        Assert.Equal(13, sum.SumTwoSmallestNumbers(numbers));        
    }
}
