
namespace _2024;

/**
 * Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of 
 n^3, the cube above will have volume of (n−1)^3 and so on until the top which will have a volume of 1^3.

You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

The parameter of the function findNb (find_nb, find-nb, findNb, ...) will be an integer m and you have to return the integer n such as 
n^3 + (n-1)^3 + (n-2)^3 + ... + 1 if such an n exists or -1 if there is no such n.

Examples:

findNb(1071225) --> 45

findNb(91716553919377) --> -1
 */
public static class ASum
{
    public static long FindNb(long m) {
        long totalVolume = 0;
        long n = 0;

        while (totalVolume < m) {
            n++;
            totalVolume += n * n * n; // Adiciona o cubo de n
        }

        return totalVolume == m ? n : -1; // Retorna n se igual, caso contrário -1
    }
}

public class ASumTests {

    [Fact]
    public void Test1() {
        Assert.Equal(2022, ASum.FindNb(4183059834009));
    }
    [Fact]
    public void Test2() {
        Assert.Equal(-1, ASum.FindNb(24723578342962));
    }
    [Fact]
    public void Test3() {
        Assert.Equal(4824, ASum.FindNb(135440716410000));
    }
    [Fact]
    public void Test4() {
        Assert.Equal(3568, ASum.FindNb(40539911473216));
        
    }
}