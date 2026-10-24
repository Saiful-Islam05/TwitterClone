using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static bool IsLong(this string  value)
        {
            return value.Length > 10;
        }

        public static string ToHashtag(this string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return word;
            }
            else if(word.StartsWith("#"))
            {
                return word;
            }
            else
            {
                return $"#{word}";
            }

        }
    }
}
