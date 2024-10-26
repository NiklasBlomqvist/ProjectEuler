namespace ProjectEuler;

public class Problem_19
{
    private static readonly int[] DaysOfTheMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    private static readonly string[] DayOfTheWeek =
        { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


    public static void Solve()
    {
        var numberOfSundaysInFirstMonth = 0;

        var dayIndex = 1; // 1 Jan 1901 was a Tuesday
        const int startYear = 1901;
        const int endYear = 2000;

        for (var year = startYear; year <= endYear; year++)
        {
            for (var month = 0; month < DaysOfTheMonth.Length; month++)
            {
                var daysInMonth = IsLeapYear(year) && month == 1 ? 29 : DaysOfTheMonth[month];
                for (var day = 0; day < daysInMonth; day++)
                {
                    if (day == 0 && DayOfTheWeek[dayIndex] == "Sunday")
                    {
                        numberOfSundaysInFirstMonth++;
                    }
                    dayIndex = IterateDayIndex(dayIndex);
                }
            }
        }

        Console.WriteLine(
            $"Number of sundays in the first month between year {startYear} and {endYear}: {numberOfSundaysInFirstMonth}");
    }

    private static int IterateDayIndex(int dayIndex)
    {
        dayIndex++;
        if (dayIndex >= DayOfTheWeek.Length)
            dayIndex = 0;

        return dayIndex;
    }

    private static bool IsLeapYear(int year)
    {
        var century = year % 100 == 0;

        if (century)
        {
            return year % 400 == 0;
        }

        return year % 4 == 0;
    }
}