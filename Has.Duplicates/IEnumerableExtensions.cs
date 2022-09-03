namespace Has.Duplicates
{
    public static class IEnumerableExtensions
    {
        public static int DuplicatesCount<TSource>(this IEnumerable<TSource> source)
        {
            return source.Duplicates(x => x).Count;
        }

        public static List<TSource> Duplicates<TSource>(this IEnumerable<TSource> source)
        {
            return source.Duplicates(x => x);
        }

        public static List<TSource> Duplicates<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            return source.GroupBy(selector).Where(x => x.IsMultiple()).SelectMany(x => x).ToList();
        }

        public static bool IsMultiple<TSource>(this IEnumerable<TSource> source)
        {
            var enumerator = source.GetEnumerator();
            return enumerator.MoveNext() && enumerator.MoveNext();
        }

        public static List<TSource> DistinctList<TSource>(this IEnumerable<TSource> source)
        {
            return source.Distinct().ToList();
        }

        public static List<TSource> DistinctList<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            return source.DistinctBy(selector).ToList();
        }

        public static List<TSource> OrderByList<TSource>(this IEnumerable<TSource> source)
        {
            return source.OrderBy(x => x).ToList();
        }

        public static List<TSource> OrderByList<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            return source.OrderBy(selector).ToList();
        }

        public static List<TSource> OrderByDescendingList<TSource>(this IEnumerable<TSource> source)
        {
            return source.OrderByDescending(x => x).ToList();
        }

        public static List<TSource> OrderByDescendingList<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            return source.OrderByDescending(selector).ToList();
        }
    }
}
