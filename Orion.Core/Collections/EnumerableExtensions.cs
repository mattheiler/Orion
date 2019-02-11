using System;
using System.Collections.Generic;
using System.Linq;

namespace Orion.Collections
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Compact<T>(this IEnumerable<T> items) where T : class
            => items.Where(item => item != null);

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
            => source.DistinctBy(keySelector, EqualityComparer<TKey>.Default);

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
        {
            var keys = new HashSet<TKey>(keyComparer);
            foreach (var element in source)
                if (keys.Add(keySelector(element)))
                    yield return element;
        }

        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items)
            => items.SelectMany(elements => elements);

        public static IEnumerable<T> Yield<T>(this T item)
        {
            yield return item;
        }
    }
}
