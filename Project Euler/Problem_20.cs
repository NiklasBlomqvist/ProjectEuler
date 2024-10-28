using System.Numerics;

namespace ProjectEuler;

public class Problem_20
{
    public static void Solve()
    {
        var f = Factorial(100);
        var sumDigits = SumDigits(f);
        Console.WriteLine(sumDigits);
    }

    private static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;
        
        return n * Factorial(n - 1);
    }

    private static int SumDigits(BigInteger n)
    {
        var sum = 0;
        var digits = n.ToString().ToCharArray();
        foreach (var d in digits)
        {
            sum += d - '0';
        }

        return sum;
    }
}