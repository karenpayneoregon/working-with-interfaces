namespace EfficiencyExamples.Classes;
public static class ConventionalExtensions
{
    public static bool IsBetween(this Range range, Index index) 
        => index.Value >= range.Start.Value && index.Value < range.End.Value;

    public static bool IsBetween(this DateTime dt, DateTime start, DateTime end)
        => dt.Ticks >= start.Ticks && dt.Ticks <= end.Ticks;

    public static bool IsBetween(this int sender, int start, int end) 
        => sender >= start && sender <= end;

    public static bool IsBetween(this decimal sender, decimal start, decimal end)
        => sender >= start && sender <= end;

    public static bool IsBetween(this double sender, double start, double end)
        => sender >= start && sender <= end;



    /// <summary>
    /// Determines whether the specified value is within the inclusive range defined by the lower and upper bounds.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value, which must be a value type and implement <see cref="IComparable{T}"/>.
    /// </typeparam>
    /// <param name="value">The value to compare.</param>
    /// <param name="lowerValue">The inclusive lower bound of the range.</param>
    /// <param name="upperValue">The inclusive upper bound of the range.</param>
    /// <returns>
    /// <c>true</c> if the value is greater than or equal to <paramref name="lowerValue"/> and less than or equal to <paramref name="upperValue"/>; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsBetween<T>(this T value, T lowerValue, T upperValue) where T : struct, IComparable<T>
        => Comparer<T>.Default.Compare(value, lowerValue) >= 0 &&
           Comparer<T>.Default.Compare(value, upperValue) <= 0;

    /// <summary>
    /// Determines whether the specified value is strictly between the given lower and upper bounds.
    /// </summary>
    /// <typeparam name="T">The type of the value, which must implement <see cref="IComparable{T}"/>.</typeparam>
    /// <param name="sender">The value to compare.</param>
    /// <param name="minimumValue">The lower bound to compare against.</param>
    /// <param name="maximumValue">The upper bound to compare against.</param>
    /// <returns>
    /// <c>true</c> if the value is strictly between the lower and upper bounds; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsBetweenExclusive<T>(this IComparable<T> sender, T minimumValue, T maximumValue)
        => sender.CompareTo(minimumValue) > 0 &&
           sender.CompareTo(maximumValue) < 0;
}
