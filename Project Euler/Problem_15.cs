using System.Numerics;

namespace ProjectEuler;

public static class Problem_15
{
    public static void Solve()
    {
        int gridSize = 20;
        BigInteger routes = CalculateRoutes(gridSize);
        Console.WriteLine($"Number of routes through a {gridSize}x{gridSize} grid: {routes}");
    }

    /// <summary>
    /// Formula:
    /// (2N)! / (N!)^2, where
    /// N = gridSize
    /// </summary>
    /// <param name="gridSize"></param>
    /// <returns></returns>
    private static BigInteger CalculateRoutes(int gridSize)
    {
        return Factorial(2 * gridSize) / (Factorial(gridSize) * Factorial(gridSize));
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}