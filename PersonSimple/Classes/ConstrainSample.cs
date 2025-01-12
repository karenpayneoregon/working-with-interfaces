using System.Diagnostics;
using System.Numerics;
using System.Text.Json;
using Serilog;
using static PersonSimple.Classes.ConstrainSample;
#pragma warning disable CA1510

// ReSharper disable LoopCanBeConvertedToQuery

namespace PersonSimple.Classes;

public class Dummy
{
    public Dummy()
    {
        Debug.WriteLine(Sum([1, 2, 3, 4, 5]));
    }
}

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
    public static T Sum<T>(params T[] numbers) where T : INumber<T>
    {
        if (numbers == null) throw new ArgumentNullException(nameof(numbers));

        var result = T.Zero;

        foreach (var item in numbers)
        {
            result += item;
        }

        return result;
    }

}

public interface IPayne
{
    public void WriteToFile<T>(string fileName, params IEnumerable<T>[] list);
    public void WriteToFile<T>(string fileName, params IEnumerable<T> list);
}

public class Payne : IPayne
{
    public void WriteToFile<T>(string fileName, params IEnumerable<T>[] list)
    {
        try
        {
            var combinedList = list.SelectMany(x => x).ToList();
            File.WriteAllText(fileName, JsonSerializer.Serialize(combinedList, Options));
        }
        catch (Exception exception)
        {
            Log.Error($"Failed in {nameof(WriteToFile)}", exception);
        }
    }
    public void WriteToFile<T>(string fileName, params IEnumerable<T> list)
    {
        try
        {
            var combinedList = list.ToList();
            File.WriteAllText(fileName, JsonSerializer.Serialize(combinedList, Options));
        }
        catch (Exception exception)
        {
            Log.Error($"Failed in {nameof(WriteToFile)}", exception);
        }
    }

    private static JsonSerializerOptions Options => new() { WriteIndented = true };
}

public class Demo
{
    public static void Show()
    {
        var payne = new Payne();

        payne.WriteToFile("test.json", 
            BogusOperations.CreatePeopleList(3,1), 
            BogusOperations.CreatePeopleList(3,5));
    }
}
