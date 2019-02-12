using System;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Orion.Api.Extensions
{
    public static class QueryCollectionExtensions
    {
        public static T GetValueOrDefault<T>(this IQueryCollection source, string key, T @default = default)
            => source.TryGetValue(key, out var value) ? (T) Convert.ChangeType((string) value, typeof(T)) : @default;

        public static T[] GetArray<T>(this IQueryCollection source, string key)
            => source.TryGetValue(key, out var values) ? ((string[]) values).Select(value => (T) Convert.ChangeType(value, typeof(T))).ToArray() : Array.Empty<T>();
    }
}