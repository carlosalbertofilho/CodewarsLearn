namespace _2024;

public static class VowelCount
{
	public static int GetVowelCount(string str)
		=> str.ToLower().Count(c => "aeiou".Contains(c));
}

public class VowelCountTest
{
	[Theory]
	[InlineData("Teste", 2)]
	[InlineData("Hello", 2)]
	[InlineData("World", 1)]
	[InlineData("AEIOU", 5)]
	[InlineData("bcdfg", 0)]
	public void GetVowelCount_ShouldReturnVowelCount(string str, int expected)
	{
		Assert.Equal(expected, VowelCount.GetVowelCount(str));
	}

}