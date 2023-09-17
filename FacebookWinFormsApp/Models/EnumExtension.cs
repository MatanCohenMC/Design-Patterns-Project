using System.Collections.Generic;
using System.Linq;

namespace FacebookApp.Models
{
    public static class EnumExtension
    {
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> i_Self)
            => i_Self.Select((i_Item, i_Index) => (item: i_Item, index: i_Index));
    }
}