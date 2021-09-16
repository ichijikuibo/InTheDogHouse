using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIII
{
    public static class StringManipulator
    {
        public static string firstLetterEachWordToUpper(string word)
        {
            if (word.Length == 0) return word;
            char[] array = word.ToCharArray();
            if (char.IsLower(array[0]))char.ToUpper(array[0]);

            for(int i=1;i<array.Length;i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
                else array[i] = char.ToLower(array[i]);

            }
            return new string(array);
        }
        public static string eachLetterToUpper(string word)
        {
            char[] array = word.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLower(array[i]))
                    array[i] = char.ToUpper(array[i]);
            }
            return new string(array);
        }
    }
}
