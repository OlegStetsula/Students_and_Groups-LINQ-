using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
    public static class Extensions
    {
        public static bool IsPalindrome(this string s)
        {
            s = s.ToLower().Replace(" ", "");
            var reverse_s = s.Reverse();
            return s.SequenceEqual(reverse_s);
        }
    }
}
