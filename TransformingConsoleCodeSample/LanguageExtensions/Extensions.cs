using System.Text.RegularExpressions;
using TransformingConsoleCodeSample.Interfaces;

namespace TransformingConsoleCodeSample.LanguageExtensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Transforms an array of elements of type <typeparamref name="TSource"/> 
        /// into an array of elements of type <typeparamref name="TResult"/> 
        /// using the specified transformer.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements in the source array.</typeparam>
        /// <typeparam name="TResult">The type of the elements in the resulting array.</typeparam>
        /// <param name="source">The array of elements to be transformed.</param>
        /// <param name="transformer">
        /// An implementation of <see cref="ITransformer{TSource, TResult}"/> 
        /// that defines the transformation logic.
        /// </param>
        /// <returns>
        /// An array of elements of type <typeparamref name="TResult"/> 
        /// resulting from applying the transformation to each element in the source array.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="source"/> or <paramref name="transformer"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="source"/> is an empty array.
        /// </exception>
        public static TResult[] Transform<TSource, TResult>(this TSource[] source, ITransformer<TSource, TResult> transformer)
        {
            if (source is null || transformer is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            var result = Array.ConvertAll(source, transformer.Transform);

            return result;
        }

        public static string SplitCamelCase(this string sender) =>
            string.Join(" ", CamelCasePattern().Matches(sender)
                .Select(m => m.Value));

        [GeneratedRegex(@"([A-Z][a-z]+)")]
        private static partial Regex CamelCasePattern();
    }
}