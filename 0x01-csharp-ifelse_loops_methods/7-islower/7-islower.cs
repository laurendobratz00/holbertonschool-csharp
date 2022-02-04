using System;

    /// <summary> class Character </summary>
    class Character
    {
        /// <summary> return true if lowercase letters </summary>
        public static bool IsLower(char c)
        {
            if (c >= 'a' && c <= 'z')
                return (true);
            else
                return (false);
        }
    }

