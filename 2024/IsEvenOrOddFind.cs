namespace _2024;

/**
You are given an array (which will have a length of at least 3, but could be very large)
containing integers. The array is either entirely composed of odd integers or entirely
composed of even integers except for a single integer N. Write a method that takes the
array as an argument and returns this "outlier" N.

Examples
[2, 4, 0, 100, 4, 11, 2602, 36] -->  11 (the only odd number)

[160, 3, 1719, 19, 11, 13, -21] --> 160 (the only even number)

**/
public abstract class IsEvenFind
{
	public static int Find(int[] integers)
		=> integers.GroupBy(n => n % 2)
			.Single(g => g.Count() == 1)
			.First();
}

public class FindTest
{
	[Theory]
	[InlineData(new[] {2, 4, 0, 100, 4, 11, 2602, 36}, 11)]
	[InlineData(new[] {160, 3, 1719, 19, 11, 13}, 160)]
	[InlineData(new[] { 3, 1719, 19, 11, 13, -21}, -21)]
	public void Find_ShouldReturnOutlier(int[] integers, int expected)
	{
		Assert.Equal(expected, IsEvenFind.Find(integers));
	}
}