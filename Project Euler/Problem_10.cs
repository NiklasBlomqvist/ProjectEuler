namespace ProjectEuler
{
    public static class Problem_10
    {
        public static void Solve()
        {
            var n = 2000000;
            var result = SumPrimesBelow(n);
            Console.WriteLine($"Sum of all primes below {n} is {result}.");
        }

        /// <summary>
        /// Check if a number is a prime number.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private static bool IsPrime(int p)
        {
            if (p < 2) return false;

            if (p == 2 || p == 3)
                return true;

            if (p % 2 == 0 || p % 3 == 0)
                return false;

            for (var i = 5; i * i <= p; i += 6)
            {
                if (p % i == 0 || p % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Sums all prime numbers below parameter.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static long SumPrimesBelow(int n)
        {
            var result = 0L;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    result += i;
                }
            }

            return result;
        }

    }
}