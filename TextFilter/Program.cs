using System;
using System.Collections.Generic;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = @"..\..\..\input.txt";

            var text = FileReader.TextFileReader(input);

            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            List<string> words = text.Split(' ').ToList();

            for(int i = words.Count - 1; i >= 0; i--)
            {
                string word = words[i];

                if (Filter.ContainsVowel(word, vowels))
                {
                    words.Remove(word);
                    continue;
                }

                if (Filter.LengthCheck(word, 3))
                {
                    words.RemoveAt(i);
                    continue;
                }

                if (Filter.ContainsLetter(word, "t"))
                {
                    words.Remove(word);
                    continue;
                }
            }

            Console.WriteLine(String.Join(' ', words));
        }
    }
}
