using System;

namespace Text
{
    /// <summary>
    /// string class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// find the first occurrence of a substring
        /// </summary>
        /// <param name="s"></param>
        /// <returns> index of first occurence </returns>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
                return -1;

            char rep;

            rep = s[0];
            foreach (char c in s)
            {
                if (c != rep)
                {
                    return s.IndexOf(c);
                }
                else
                {
                    rep = c;
                }
            }

            return -1;
        }
    }
}
