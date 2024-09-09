namespace ProjectEuler;

public static class Problem_12
{
    private const int NumberOfDivisorsForTriangleNumber = 500;

    public static void Solve()
    {
        var i = 1;
        var maxFactors = 0;
        var triangleNumber = 0;

        while (maxFactors <= 500)
        {
            triangleNumber += i;
            var numbersOfFactors = FindNumbersOfFactorsFor(triangleNumber);

            if (numbersOfFactors > maxFactors)
                maxFactors = numbersOfFactors;

            i++;
        }

        System.Console.WriteLine($"The first triangle number ({triangleNumber}) to have over 500 factors with {maxFactors} factors.");

    }

    private static int FindNumbersOfFactorsFor(int number)
    {
        var numbersOfFactors = 1;
        var n = number; // Use a separate variable to keep track of the remaining number

        var sqrt = (int)Math.Sqrt(number);

        for (var i = 2; i <= sqrt; i++)
        {
            if (!IsPrime(i)) continue; // Skip non prime numbers.

            int power = CountNumberOfTimesCanBeDivided(n, i);
            if (power > 0)
            {
                numbersOfFactors *= power + 1;
                n /= (int)Math.Pow(i, power); // Update the remaining number
            }
        }

        if (n > 1)
        {
            numbersOfFactors *= 2;
        }
        return numbersOfFactors;
    }

    private static int CountNumberOfTimesCanBeDivided(int number, int factor)
    {
        int count = 0;
        while (number % factor == 0)
        {
            number /= factor;
            count++;
        }
        return count;
    }

    /// <summary>
    /// Check if a number is a prime number.
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    private static bool IsPrime(int p)
    {
        // Smaller numbers than 2 cannot be primes.
        if (p < 2) return false;

        // First 2 prime numbers.
        if (p == 2 || p == 3)
            return true;

        // If evenly divisble with 2 or 3 it is not a prime.
        if (p % 2 == 0 || p % 3 == 0)
            return false;

        for (var i = 5; i * i <= p; i += 6)
        {
            if (p % i == 0 || p % (i + 2) == 0)
                return false;
        }

        return true;
    }

    ///
    /// See below for nicer solution.
    /// 
    // public static void Solve()
    // {
    //     int n = 1;
    //     while (true)
    //     {
    //         long triangleNumber = CalculateTriangleNumber(n);
    //         int divisorCount = CountDivisors(triangleNumber);
    //         if (divisorCount > 500)
    //         {
    //             System.Console.WriteLine(triangleNumber);
    //             break;
    //         }
    //         n++;
    //     }
    // }

    // public static long CalculateTriangleNumber(int n)
    // {
    //     return (long)n * (n + 1) / 2;
    // }

    // public static int CountDivisors(long number)
    // {
    //     int count = 0;
    //     long sqrt = (long)Math.Sqrt(number);
    //     for (long i = 1; i <= sqrt; i++)
    //     {
    //         if (number % i == 0)
    //         {
    //             count += 2;
    //         }
    //     }
    //     if (sqrt * sqrt == number)
    //     {
    //         count--;
    //     }
    //     return count;
    // }
}
