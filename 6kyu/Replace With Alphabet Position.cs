using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarConsoleApp._6kyu
{
    public class Replace_With_Alphabet_Position
    {
        public static void AlphabetPosition(string text)
        {
            string numberstring;
            List<int> numbers = new List<int>();
            int characterPosition;
            foreach (char character in text)
            {
                characterPosition = char.ToLower(character) - 'a' + 1;
                if (characterPosition > 0)
                    numbers.Add(characterPosition);
            }
            numberstring = string.Join(" ", numbers);


            Console.WriteLine(numberstring);
        }

        public static void AlphabetPositionVersion2(string text)
        {
            Console.WriteLine(string.Join(" ",text.ToLower().Where(char.IsLetter).Select(x=> x- 'a'+1)));
        }

    }
}
