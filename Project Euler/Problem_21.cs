using System.Numerics;

namespace ProjectEuler;

public static class Problem_21
{
    public static void Solve()
    {
        var listOfAmicableNumbers = new List<int>();
        var upperLimit = 10000;
        for (var i = 1; i < upperLimit; i++)
        {
            if(IsAmicableNumber(i))
                listOfAmicableNumbers.Add(i);
        }

        Console.WriteLine($"All amicable numbers:");
        foreach (var n in listOfAmicableNumbers)
        {
            Console.WriteLine(n);
        }
        
        var sumOfAllAmicableNumbers = listOfAmicableNumbers.Sum();
        Console.WriteLine($"Sum of all amicable numbers under {upperLimit} = {sumOfAllAmicableNumbers}");
    }

    private static bool IsAmicableNumber(int a)
    {
        var b = SumOfProperDivisors(a);

        if (a == b)
            return false;
        
        return SumOfProperDivisors(b) == a;
    }
    
    private static int SumOfProperDivisors(int n)
    {
        var sum = 0;
        // Get all divisors of n
        for (var i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        
        // Sum them together and return
        return sum;
    }
}