namespace ProjectEuler
{
    public static class Problem_7
    {
        private static readonly int _maxNumber = 1000000;

        public static void Solve()
        {
            var n = 10001;
            var p = GetNthPrime(n);

            if (p == 0)
                Console.WriteLine($"Not enough tries to find {n}th prime number.");
            else
                Console.WriteLine($"The {n}th prime number is {p}");
        }

        private static int GetNthPrime(int n)
        {
            var primeNumber = 0;

            for (int j = 2; j < _maxNumber; j++)
            {
                if (IsPrime(j))
                    primeNumber++;

                if (primeNumber == n)
                    return j;
            }


            return 0;
        }

        private static bool IsPrime(int p)
        {
            if (p < 2) return false;

            for (int i = 2; i < p; i++)
            {
                if (p % i == 0) return false;
            }

            return true;
        }
    }
}