using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            int count = 1;
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
