namespace _2024;

/**
Given the triangle of consecutive odd numbers:

         1
      3     5
   7     9    11
13    15    17    19
21    23    25    27    29
...
Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)

1 -->  1
2 --> 3 + 5 = 8

**/
public abstract class SumOddNumbers
{
	/**
Padrão no Triângulo:
	Cada linha n do triângulo contém exatamente n números ímpares.
	O primeiro número ímpar da linha n é o n-ésimo número ao quadrado (n * n).
	A soma de todos os números ímpares na linha n é dada pela fórmula: n * n * n (ou seja, n³).
**/
	public static long RowSumOddNumbers(long n) 
		=> (long)Math.Pow(n, 3);
}

public class SumOddNumbersTest
{
	[Theory]
	[InlineData(1, 1)]
	[InlineData(2, 8)]
	[InlineData(13, 2197)]
	[InlineData(19, 6859)]
	[InlineData(41, 68921)]
	[InlineData(42, 74088)]
	[InlineData(74, 405224)]
	[InlineData(99, 970299)]
	[InlineData(100, 1000000)]
	public void RowSumOddNumbers_ShouldReturnSumOfNumbersInNthRow(long n, long expected)
	{
		Assert.Equal(expected, SumOddNumbers.RowSumOddNumbers(n));
	}
}