using System;

namespace Text
{
    /// <summary>
    /// String class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// checks for palindrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns> true or false </returns>
        public static bool IsPalindrome(string s)
        {    
            if (s == null || s.Length == 0)
            {
                return true;
            }
            s = s.Replace(":", "");
            s = s.Replace(" ", "");
            s = s.Replace(",", "");
            s = s.Replace(".", "");
            s = s.ToLower();
            Console.WriteLine(s);
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
