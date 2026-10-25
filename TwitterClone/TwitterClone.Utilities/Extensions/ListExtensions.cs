using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Utilities.Extensions
{
    public static class ListExtensions
    {
        public static T? LastOrNull<T>(this List<T> items) where T : class
        {
            if (items == null || items.Count == 0)
            {
                return null;
            }
            else
            {
                return items[items.Count - 1];
            }
        }
    }
}
