using TransformingConsoleCodeSample.Interfaces;

namespace TransformingConsoleCodeSample.Classes.Transformers
{
    /// <summary>
    /// Represents a transformer that converts a string input into an integer output.
    /// </summary>
    /// <remarks>
    /// This class implements the <see cref="ITransformer{TSource, TResult}"/> interface,
    /// where <c>TSource</c> is <see cref="string"/> and <c>TResult</c> is <see cref="int"/>.
    /// It attempts to parse the input string into an integer. If parsing fails, it returns a default value of 0.
    /// </remarks>
    public class StringToIntTransformer : ITransformer<string, int>
    {
        public int Transform(string source) => int.TryParse(source, out var value) ? value : 0;
    }
}
