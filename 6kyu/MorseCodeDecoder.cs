namespace CodeWarConsoleApp._6kyu
{
    public class MorseCodeDecoder
    {

        private static readonly Dictionary<string, string> _map = new()
{
    { ".-", "A" }, { "-...", "B" }, { "-.-.", "C" },
    { "-..", "D" }, { ".", "E" }, { "..-.", "F" },
    { "--.", "G" }, { "....", "H" }, { "..", "I" },
    { ".---", "J" }, { "-.-", "K" }, { ".-..", "L" },
    { "--", "M" }, { "-.", "N" }, { "---", "O" },
    { ".--.", "P" }, { "--.-", "Q" }, { ".-.", "R" },
    { "...", "S" }, { "-", "T" }, { "..-", "U" },
    { "...-", "V" }, { ".--", "W" }, { "-..-", "X" },
    { "-.--", "Y" }, { "--..", "Z" }
};



        public static string Get(string code)
        {
            return _map.ContainsKey(code) ? _map[code] : "?";
        }

        public static string Decode(string morseCode)
        {
            List<string> morseAlphabetCodeString = new List<string>();
            string[] MorseCodeWordArray = morseCode.Trim().Split("   ");
            string[] MorseCodeCharacterArray;
            string alphabet;
            List<string> alphabetList = new List<string>();

            foreach (string MorseCodeLetter in MorseCodeWordArray)
            {
                MorseCodeCharacterArray = MorseCodeLetter.Split(" ");
                morseAlphabetCodeString.AddRange(MorseCodeCharacterArray);
                morseAlphabetCodeString.Add(" ");
            }

            foreach(string code in morseAlphabetCodeString)
            {
                alphabet = " ";
                if (code != " ") {
                    alphabet = Get(code);
                }
                    alphabetList.Add(alphabet);
                

            }
             string noSpaceAlphabet = string.Join("", alphabetList);


       
            return noSpaceAlphabet.Trim();
        }


        public static string DecodeVersion2(string morseCode)
        {
            var words = morseCode.Trim().Split(new[] { "   " }, StringSplitOptions.None);
            var translatedWords = words.Select(word => word.Split(' ')).Select(letters => string.Join("", letters.Select(Get))).ToList();
            return string.Join(" ", translatedWords);
        }
    }
}
