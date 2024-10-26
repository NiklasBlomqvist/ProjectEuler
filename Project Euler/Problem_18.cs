using System.Diagnostics;

namespace ProjectEuler;

public class Problem_18
{
    private static readonly int[][] TestTriangle = new int[][]
    {
        new int[] { 3 },
        new int[] { 7, 4 },
        new int[] { 2, 4, 6 },
        new int[] { 8, 5, 9, 3 }
    };
    
    private static readonly int[][] SolutionTriangle = new int[][]
    {
        new int[] { 75 },
        new int[] { 95, 64 },
        new int[] { 17, 47, 82 },
        new int[] { 18, 35, 87, 10 },
        new int[] { 20, 4, 82, 47, 65 },
        new int[] { 19, 1, 23, 75, 3, 34 },
        new int[] { 88, 2, 77, 73, 7, 63, 67 },
        new int[] { 99, 65, 4, 28, 6, 16, 70, 92 },
        new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
        new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
        new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
        new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
        new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
        new int[] { 63, 66, 4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
        new int[] { 4, 62, 98, 27, 23, 9, 70, 98, 73, 93, 38, 53, 60, 4, 23 }
    };

    private static string path = "";

    public static void Solve()
    {
        Console.WriteLine("Problem 18:");
        Console.WriteLine("Find the maximum total from top to bottom of the triangle below:");

        var sw = new Stopwatch();
        sw.Start();
        var result = FindMaxPath(SolutionTriangle, 0, 0);
        sw.Stop();
        var time = sw.ElapsedMilliseconds;

        Console.WriteLine($"Result: {result}. Time taken to calculate: {time}");
    }

    private static int FindMaxPath(int[][] triangle, int row, int column)
    {
        if (row >= triangle.Length || column >= triangle[row].Length) return 0;

        var val = triangle[row][column];
        var left = val + FindMaxPath(triangle, row + 1, column);
        var right = val + FindMaxPath(triangle, row + 1, column + 1);
        
        return Math.Max(left, right);
    }
}