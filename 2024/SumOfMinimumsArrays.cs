namespace _2024;
/**
Given a 2D ( nested ) list ( array, vector, ) of size m * n, your task is to 
find the sum of the minimum values in each row.
For Example:
[ [ 1, 2, 3, 4, 5 ]        #  minimum value of row is 1
, [ 5, 6, 7, 8, 9 ]        #  minimum value of row is 5
, [ 20, 21, 34, 56, 100 ]  #  minimum value of row is 20
]
So the function should return 26 because the sum of the minimums is 1 + 5 + 20 = 26.
Note: You will always be given a non-empty list containing positive values.
ENJOY CODING :)
 */
public static class SumOfMinimumsArrays
{
    public static int SumOfMinimums(int[,] numbers)
    {
        var sum = 0;
        for (var i = 0; i < numbers.GetLength(0); i++)
        {
            var min = numbers[i, 0];
            for (var j = 1; j < numbers.GetLength(1); j++)
                if (numbers[i, j] < min) min = numbers[i, j];
            sum += min;
        }

        return sum;
    }
}

public class SumOfMinimumsTest
{
    // Usando MemberData para fornecer dados de teste
    public static TheoryData<int[,], int> TestData => new TheoryData<int[,], int>
    {
        { new[,] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } }, 26 }
    ,   { new[,] { {7,9,8,6,2 }, {6,3,5,4,3}, {5,8,7,4,5} }, 9}    
    ,   { new[,] { {11,12,14,54}, {67,89,90,56}, {7,9,4,3}, {9,8,6,7} }, 76}
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void SumOfMinimums_ShouldReturnSumOfMinimums(int[,] numbers, int expected)
        => Assert.Equal(expected, SumOfMinimumsArrays.SumOfMinimums(numbers));
}