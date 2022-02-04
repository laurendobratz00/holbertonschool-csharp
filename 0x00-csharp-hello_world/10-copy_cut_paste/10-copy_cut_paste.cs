using System;

/// <summary> class Program </summary>
class Program
{
        /// <summary> copy, cut, paste - not allowed to use any loops or conditional statements </summary>
        static void Main(string[] args)
        {
		string word = "Holberton";
		string word_first_3 = word.Substring(0, 3);
        string word_last_2 = word.Substring(word.Length - 2,2);
        string middle_word = word.Substring(1, word.Length - 2);
		Console.WriteLine("First 3 letters: {0}", word_first_3);
		Console.WriteLine("Last 2 letters: {0}", word_last_2);
		Console.WriteLine("Middle word: {0}", middle_word);
        }
}