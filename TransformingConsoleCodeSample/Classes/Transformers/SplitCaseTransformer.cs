using TransformingConsoleCodeSample.Interfaces;
using TransformingConsoleCodeSample.LanguageExtensions;

namespace TransformingConsoleCodeSample.Classes.Transformers
{
    /// <summary>
    /// Provides functionality to transform strings into a camel-case-separated format.
    /// </summary>
    /// <remarks>
    /// This class implements the <see cref="TransformingConsoleCodeSample.Interfaces.ITransformer{TSource, TResult}"/> interface,
    /// specifically transforming strings by splitting camel-case words into separate words.
    /// </remarks>
    public class SplitCaseTransformer :  ITransformer<string, string>
    {
        public string Transform(string source) => source.SplitCamelCase();
    }
}