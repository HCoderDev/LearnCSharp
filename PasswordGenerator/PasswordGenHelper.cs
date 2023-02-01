using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator
{
    public enum CharType
    {
        Lowercase,
        Uppercase,
        Digits,
        Symbols
    }
    public class PasswordGenHelper
    {
        public static string GeneratePassword(GenerateConfig generateConfig)
        {
            string generatedPassword = string.Empty;
            List<char> characters= new List<char>();
            
            if (generateConfig.IsLowerCase) 
                characters.AddRange(GetCharacters(CharType.Lowercase));

            if (generateConfig.IsUpperCase)
                characters.AddRange(GetCharacters(CharType.Uppercase));

            if (generateConfig.IsDigits)
                characters.AddRange(GetCharacters(CharType.Digits));

            if (generateConfig.IsSymbols)
                characters.AddRange(GetCharacters(CharType.Symbols));

            Random random = new Random();

            List<char> selected = Enumerable.Range(0, generateConfig.Length)
                .Select(x => characters[random.Next(characters.Count)]).ToList();

            generatedPassword = string.Join("",selected);
            return generatedPassword;
        }

        private static List<char> GetCharacters(CharType charType)
        {
            if(charType==CharType.Lowercase)
                return Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToList();
            if(charType==CharType.Uppercase)
                return Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c).ToList();
            if (charType == CharType.Digits)
                return Enumerable.Range('0', '9' - '0' + 1).Select(c => (char)c).ToList();
            else
                return "!@#$%^&*()_+-={}[]\\|;:'\"<>,.?/~`".Where(c => char.IsSymbol(c)).ToList();
        }
    }
}
