using System.Numerics;

namespace ProjectEuler;

public static class Problem_16
{
    public static void Solve()
    {
        var powerSize = 1000;
        BigInteger bigNumber = (BigInteger) Math.Pow(2, powerSize);
        
        var digits = new List<int>();
        foreach(char c in bigNumber.ToString())
        {
            digits.Add(c - '0');
        }

        var sum = 0;
        foreach(var digit in digits) 
        {
            sum += digit;
        }

        System.Console.WriteLine($"Result: {sum}");
    }


}