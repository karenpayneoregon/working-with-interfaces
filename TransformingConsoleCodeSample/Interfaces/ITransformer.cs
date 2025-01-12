namespace TransformingConsoleCodeSample.Interfaces
{
    /// <summary>
    /// Defines a mechanism for transforming an input of type <typeparamref name="TSource"/> 
    /// into an output of type <typeparamref name="TResult"/>.
    /// </summary>
    /// <typeparam name="TSource">The type of the input to be transformed.</typeparam>
    /// <typeparam name="TResult">The type of the result after transformation.</typeparam>
    public interface ITransformer<in TSource, out TResult>
    {
        TResult Transform(TSource source);
    }
}
