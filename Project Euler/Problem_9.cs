namespace ProjectEuler
{
    public static class Problem_9
    {
        /// <summary>
        /// Knowns:
        /// a < b < c
        /// a^2 + b^2 = c^2
        /// Solve: a + b + c = 1000
        /// </summary>
        public static void Solve()
        {
            var length = 1000;
            for (int a = 1; a < length; a++)
            {
                for (int b = 1; b < length; b++)
                {
                    if(a >= b)
                        continue;

                    var c = Pythagorean(a, b);

                    // Not a natural number, skip.
                    if(c == -1)
                        continue;

                    if(a + b + c == 1000) 
                    {
                        Console.WriteLine($"Answer found to a + b + c = 1000. Product a*b*c = {a*b*c}.");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Returns c in the formula a^2 + b^2 = c^2. If not natural number, return -1.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Pythagorean(int a, int b) 
        {
            var solution = MathF.Sqrt(MathF.Pow(a, 2) + MathF.Pow(b, 2));
            
            // Check if the solution is a natural number
            if (solution % 1 == 0 && solution > 0)
                return (int) solution;
            else
                return -1; // Indicating no natural number found
        }
    }
}