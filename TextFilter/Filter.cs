using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextFilter
{
    public static class Filter
    {
        public static bool ContainsVowel(string word, List<char> chars)
        {
            int middleNumber = word.Length / 2;

            string middleLetters = word;

            if (!LengthCheck(word, 3))
            {
                if (word.Length % 2 == 0)
                {
                    middleLetters = word.Substring(middleNumber - 1, middleNumber);
                }
                else
                {
                    middleLetters = word[middleNumber].ToString();
                }
            }

            for(int i = 0; i < chars.Count; i++)
            {
                if(ContainsLetter(middleLetters.ToLower(), chars[i].ToString()))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool LengthCheck(string word, int length)
        {
            if (word.Length < length)
            {
                return true;
            }

            return false;
        }

        public static bool ContainsLetter(string word, string character)
        {
            if (word.Contains(character))
            {
                return true;
            }

            return false;
        }

        public static string RemoveSpecialChars(string input)
        {
            return Regex.Replace(input, @"[^A-Za-z0-9 -]", string.Empty);
        }
    }
}
