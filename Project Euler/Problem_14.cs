using System.Numerics;

namespace ProjectEuler;

public static class Problem_14
{
    public static void Solve()
    {
        var longestSequence = 0L;
        var startingNumber = 0;
        var amountOfNumbers = 1000000L;
        for (int i = 0; i < amountOfNumbers; i++)
        {
            var sequenceLength = CollatzSequence(i);
            if(sequenceLength > longestSequence)
            {
                longestSequence = sequenceLength;
                startingNumber = i;
            }
        }

        System.Console.WriteLine($"Longest chain: {longestSequence} was starting number {startingNumber}");
    }

    private static int CollatzSequence(long number)
    {
        if(number < 1) 
        {
            return 0;
        }
        else if(number == 1)
        {
            return 1;
        }
        else if(number % 2 == 0) // Even number.
        {
            return 1 + CollatzSequence(number / 2);
        }
        else // Odd number.
        {
            return 1 + CollatzSequence(3*number + 1);
        }
    }
}
