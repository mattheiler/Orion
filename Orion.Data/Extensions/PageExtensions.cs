using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orion.Collections;

namespace Orion.Data.Extensions
{
    public static class PageExtensions
    {
        public static Page<TSource> ToPage<TSource>(this IOrderedQueryable<TSource> queryable, int index, int size)
        {
            if (queryable == null) throw new ArgumentNullException(nameof(queryable));
            if (index < 0) throw new ArgumentException("Index must be greater than or equal to 0.", nameof(index));
            if (size <= 0) throw new ArgumentException("Size must be greater than 0.", nameof(size));

            var count = queryable.Count();
            var items = queryable.Skip(index * size).Take(size).ToList();

            return new Page<TSource>(index, size, count, items);
        }

        public static Page<TResult> ToPage<TSource, TResult>(this IOrderedQueryable<TSource> queryable, int index, int size, Expression<Func<TSource, TResult>> resultSelector)
        {
            if (queryable == null) throw new ArgumentNullException(nameof(queryable));
            if (index < 0) throw new ArgumentException("Index must be greater than or equal to 0.", nameof(index));
            if (size <= 0) throw new ArgumentException("Size must be greater than 0.", nameof(size));

            var count = queryable.Count();
            var items = queryable.Skip(index * size).Take(size).Select(resultSelector).ToList();

            return new Page<TResult>(index, size, count, items);
        }

        public static async Task<Page<TSource>> ToPageAsync<TSource>(this IOrderedQueryable<TSource> queryable, int index, int size)
        {
            if (queryable == null) throw new ArgumentNullException(nameof(queryable));
            if (index < 0) throw new ArgumentException("Index must be greater than or equal to 0.", nameof(index));
            if (size <= 0) throw new ArgumentException("Size must be greater than 0.", nameof(size));

            var count = queryable.CountAsync();
            var items = queryable.Skip(index * size).Take(size).ToListAsync();

            return new Page<TSource>(index, size, await count, await items);
        }

        public static async Task<Page<TResult>> ToPageAsync<TSource, TResult>(this IOrderedQueryable<TSource> queryable, int index, int size, Expression<Func<TSource, TResult>> resultSelector)
        {
            if (queryable == null) throw new ArgumentNullException(nameof(queryable));
            if (index < 0) throw new ArgumentException("Index must be greater than or equal to 0.", nameof(index));
            if (size <= 0) throw new ArgumentException("Size must be greater than 0.", nameof(size));

            var count = queryable.CountAsync();
            var items = queryable.Skip(index * size).Take(size).Select(resultSelector).ToListAsync();

            return new Page<TResult>(index, size, await count, await items);
        }
    }
}