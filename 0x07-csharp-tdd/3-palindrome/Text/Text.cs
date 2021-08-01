using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = s.Replace(" ", String.Empty);
            s = s.Replace(".", String.Empty);
            s = s.Replace(":", String.Empty);
            s = s.Replace(",", String.Empty);
            if (s.Length <= 1)
            {
                return true;
            }
            else
            {
                if (s[0] != s[s.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(s.Substring(1, s.Length - 2));
                }
            }
        }
    }
}
