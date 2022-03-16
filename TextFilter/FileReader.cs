using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextFilter
{
    public static class FileReader
    {
        public static string TextFileReader(string input, bool removeSpecChar = false)
        {
            var list = new List<string>();

            var fileStream = new FileStream(input, FileMode.Open, FileAccess.Read);

            using (StreamReader file = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            if (removeSpecChar)
            {
                return Filter.RemoveSpecialChars(String.Join(' ', list));
            }

            return String.Join(' ', list);
        }
    }
}
