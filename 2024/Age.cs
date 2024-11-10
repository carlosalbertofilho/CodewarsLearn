namespace _2024;

/**
In a small town the population is p0 = 1000 at the beginning of a year. The population regularly increases 
by 2 percent per year and moreover 50 new inhabitants per year come to live in the town. How many years does
 the town need to see its population greater than or equal to p = 1200 inhabitants?

At the end of the first year there will be:
1000 + 1000 * 0.02 + 50 => 1070 inhabitants

At the end of the 2nd year there will be:
1070 + 1070 * 0.02 + 50 => 1141 inhabitants (** number of inhabitants is an integer **)

At the end of the 3rd year there will be:
1141 + 1141 * 0.02 + 50 => 1213

It will need 3 entire years.
More generally given parameters:

p0, percent, aug (inhabitants coming or leaving each year), p (population to equal or surpass)
the function nb_year should return n number of entire years needed to get a population greater or equal to p.
aug is an integer, percent a positive or null floating number, p0 and p are positive integers (> 0)

Examples:
nb_year(1500, 5, 100, 5000) -> 15
nb_year(1500000, 2.5, 10000, 2000000) -> 10
Note:
Don't forget to convert the percent parameter as a percentage in the body of your function: if the parameter
percent is 2 you have to convert it to 0.02. There are no fractions of people. At the end of each year, the 
population count is an integer: 252.8 people round down to 252 persons.

**/
public static class Age {
	public static int NbYear(int p0, double percent, int aug, int p)
	{
		var year = 0;
		var population = p0;

		while (population < p)
		{
			population += (int)(population * (percent / 100)) + aug;
			year++;
		}

		return year;
	}

	public static int NbYear2(int p0, double percent, int aug, int p)
		=> p0 >= p
			? 0
			: 1 + NbYear2((int)(p0 + p0 * percent / 100 + aug), percent, aug, p);

}

public class AgeTest
{
	[Fact]
	public void NbYear_ShouldReturnExpectValue()
	{
		Assert.Equal(15, Age.NbYear(1500, 5, 100, 5000));
		Assert.Equal(10, Age.NbYear(1500000, 2.5, 10000, 2000000));
	}
	[Fact]
	public void NbYear2_ShouldReturnExpectValue()
	{
		Assert.Equal(15, Age.NbYear2(1500, 5, 100, 5000));		
		Assert.Equal(10, Age.NbYear2(1500000, 2.5, 10000, 2000000));

	}
}