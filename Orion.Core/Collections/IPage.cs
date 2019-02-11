using System.Collections.Generic;

namespace Orion.Collections
{
    public interface IPage<out T>
    {
        int Index { get; }

        int Size { get; }

        int Count { get; }

        IReadOnlyList<T> Items { get; }
    }
}