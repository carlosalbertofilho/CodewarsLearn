namespace _2024;
/**
Your task is to make a function that can take any non-negative integer as an argument and 
return it with its digits in descending order. Essentially, rearrange the digits to create
 the highest possible number.

Examples:
Input: 42145 Output: 54421
Input: 145263 Output: 654321
Input: 123456789 Output: 987654321
**/

public static class OrderDescendingNumber
{
	public static int DescendingOrder(int num)
	       => int.Parse(string.Concat(num.ToString().OrderByDescending(c => c)));
}

public class OrderDescendingNumberTest
{
	[Theory]
	[InlineData(42145, 54421)]
	[InlineData(145263, 654321)]
	[InlineData(123456789, 987654321)]
	public void DescendingOrder_ShouldReturnNumberWithDigitsInDescendingOrder(int num, int expected)
	{
		Assert.Equal(expected, OrderDescendingNumber.DescendingOrder(num));
	}
}