using EfficiencyExamples.Classes;

namespace EfficiencyExamples;

internal partial class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.MarkupLine("[yellow]Hello[/]");
        var range = new Range(1, 10);
        var isInRange1 = range.IsBetween(1); // true, 1..10 is inclusive min range index(1)
        var isInRange2 = range.IsBetween(10); // false, 1..10 exclusive on max range index (10).
        var isInRange3 = range.IsBetween(100); // false

        WorkingSmarterWithDecimal(10.25m);
        WorkingSmarterWithDateTime(new DateTime(2020, 1, 14));
        WorkingSmarterWithDateOnly(new DateOnly(2020, 1, 10));

        Console.ReadLine();
    }

    internal static void ConventionalBetween(int value)
    {
        if (value >= 1 && value <= 10)
        {
            // do something
        }
    }

    internal static void WorkingSmarterWithInt(int value)
    {
        if (value.IsBetween(1, 10))
        {
            // Do something
        }
    }
    internal static void WorkingSmarterWithDecimal(decimal value)
    {
        if (value.IsBetween(1.5m, 10.5m))
        {
            // Do something
        }
    }

    internal static void WorkingSmarterWithDateTime(DateTime value)
    {
        if (value.IsBetween(new DateTime(2020, 1, 1), new DateTime(2020, 1, 15)))
        {
            // Do something
        }
    }
    internal static void WorkingSmarterWithDateOnly(DateOnly value)
    {
        if (value.IsBetween(new DateOnly(2020, 1, 1), new DateOnly(2020, 1, 15)))
        {
            // Do something
        }
    }
}