using System.Numerics;

namespace ProjectEuler;

public static class Problem_17
{
    private static readonly string[] units = [
            "", "one", "two", "three", "four", "five", "six", "seven",
            "eight", "nine", "ten", "eleven", "twelve", "thirteen",
            "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",
            "nineteen"
        ];

    private static readonly string[] tens = [
            "", "", "twenty", "thirty", "forty", "fifty", "sixty",
            "seventy", "eighty", "ninety"
        ];

    public static void Solve()
    {
        System.Console.WriteLine($"Counting...");
        var sum = 0;
        var length = 1000;
        for (int i = 1; i <= length; i++)
        {
            var word = FormulateWordFromNumber(i);
            var wordLength = CountWord(word);
            sum += wordLength;
            System.Console.WriteLine($"{i}: {word}, length: {wordLength}");
        }
        System.Console.WriteLine($"Sum word lengths up to {length} = {sum}");
    }

    /// <summary>
    /// Counts the total number of letters used when writing out all the numbers from 1 to 1000 in words.
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    private static int CountWord(string word)
    {
        return word.Length;
    }

    /// <summary>
    /// Translates an int number to a lettered word without whitespaces.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private static string FormulateWordFromNumber(int number)
    {
        if (number < 20)
        {
            return units[number];
        }

        if (number < 100)
        {
            var ten = number / 10;
            var unit = number % 10;
            return $"{tens[ten]}{units[unit]}";
        }
        
        if (number < 1000)
        {
            var hundred = number / 100;
            var remainder = number % 100;

            if (remainder < 20)
            {
                return remainder > 0
                    ? $"{units[hundred]}hundredand{units[remainder]}"
                    : $"{units[hundred]}hundred";
            }
            else
            {
                var ten = remainder / 10;
                var unit = remainder % 10;
                return remainder > 0
                    ? $"{units[hundred]}hundredand{tens[ten]}{units[unit]}"
                    : $"{units[hundred]}hundred";
            }
        }

        return "onethousand";
    }
}