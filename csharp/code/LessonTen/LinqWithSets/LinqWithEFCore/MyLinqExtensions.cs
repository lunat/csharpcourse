namespace LinqWithEFCore;

public static class MyLinqExtensions
{
    // this is a chainable "fluent" LINQ extension method
    public static IEnumerable<T> ProcessSequence<T>
        (this IEnumerable<T> sequence)
    {
        // here you can do some processing
        return sequence;
    }

    public static IQueryable<T> ProcessSequence<T>
        (this IQueryable<T> sequence)
    {
        // here you can do some processing
        return sequence;
    }

    // these are scalar LINQ extension methods
    public static int? Median(this IEnumerable<int?> sequence)
    {
        var ordered = sequence.OrderBy(item => item);
        int middlePosition = ordered.Count() / 2;
        return ordered.ElementAt(middlePosition);
    }

    public static int? Median<T>(this IEnumerable<T> sequence,
        Func<T, int?> selector)
    {
        return sequence.Select(selector).Median();
    }

    public static decimal? Median(this IEnumerable<decimal?> sequence)
    {
        var ordered = sequence.OrderBy(item => item);
        int middlePosition = ordered.Count() / 2;
        return ordered.ElementAt(middlePosition);
    }

    public static decimal? Median<T>(this IEnumerable<T> sequence,
        Func<T, decimal?> selector)
    {
        return sequence.Select(selector).Median();
    }

}