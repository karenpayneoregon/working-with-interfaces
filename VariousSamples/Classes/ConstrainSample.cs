using System.Numerics;
// ReSharper disable LoopCanBeConvertedToQuery
#pragma warning disable CA1510

namespace VariousSamples.Classes;

/// <summary>
/// There are two versions of Sum, the first most likely will appeal to new developers
/// as many novice developers believe one-liners are best.
///
/// A one line method is not always the best choice, the second version is more readable
/// and easier to debug.
///
/// Performance, the second version which introduces some overhead due to delegate
/// invocation for each element in the array.  
/// </summary>
public class ConstrainSample
{

    /// <summary>
    /// Computes the sum of an array of numbers.
    /// </summary>
    /// <typeparam name="T">
    /// The numeric type of the elements in the array. Must implement <see cref="INumber{T}"/>.
    /// </typeparam>
    /// <param name="numbers">
    /// An array of numbers to sum.
    /// </param>
    /// <returns>
    /// The sum of all elements in the <paramref name="numbers"/> array.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown if the <paramref name="numbers"/> array is <c>null</c>.
    /// </exception>
    public static T Sum<T>(T[] numbers) where T : INumber<T>
    {
        return numbers == null
            ? throw new ArgumentNullException(nameof(numbers))
            : numbers.Aggregate(T.Zero, (current, item) => current + item);
    }
    /// <summary>
    /// Computes the sum of an array of numbers.
    /// </summary>
    /// <typeparam name="T">
    /// The numeric type of the elements in the array. Must implement <see cref="INumber{T}"/>.
    /// </typeparam>
    /// <param name="numbers">
    /// An array of numbers to sum.
    /// </param>
    /// <returns>
    /// The sum of all elements in the <paramref name="numbers"/> array.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown if the <paramref name="numbers"/> array is <c>null</c>.
    /// </exception>
    public static T Sum1<T>(params T[] numbers) where T : INumber<T>
    {
        if (numbers == null) throw new ArgumentNullException(nameof(numbers));

        var result = T.Zero;

        foreach (var item in numbers)
        {
            result += item;
        }

        return result;
    }

    /// <summary>
    /// Computes the sum of a list of numbers.
    /// </summary>
    /// <typeparam name="T">
    /// The numeric type of the elements in the list. Must implement <see cref="INumber{T}"/>.
    /// </typeparam>
    /// <param name="numbers">
    /// A list of numbers to sum.
    /// </param>
    /// <returns>
    /// The sum of all elements in the <paramref name="numbers"/> list.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown if the <paramref name="numbers"/> list is <c>null</c>.
    /// </exception>
    /// <remarks>
    /// For those using Resharper, a prompt will recommend using LINQ but
    /// is not always the correct way dependent on the data size.
    /// </remarks>
    public static T SumList<T>(List<T> numbers) where T : INumber<T>
    {
        if (numbers == null) throw new ArgumentNullException(nameof(numbers));

        var result = T.Zero;

        // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
        foreach (var item in numbers)
        {
            result += item;
        }

        return result;
    }

}