using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRHomeWork
{
    static class Extensions
    {
        public static IEnumerable<T> GetByCondition<T>(this IEnumerable<T> list,
            Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }
}
