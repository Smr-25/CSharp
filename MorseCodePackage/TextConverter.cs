namespace MorseCodePackage;

public static class TextConverter
{
    public static string ToMorse(this string text)
    {
        if (text is null)
        {
            throw new ArgumentNullException(nameof(text));
        }

        var morseText = "";
        var words = text.Split(' ');
        for (int w = 0; w < words.Length; w++)
        {
            var word = words[w];
            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i].ToString().ToLower();
                if (AlphabetDB.MorseAlphabetDB.TryGetValue(letter, out var morse))
                {
                    morseText += morse;
                }
                else
                {
                   
                }
                if (i < word.Length - 1)
                {
                    morseText += " "; 
                }
            }
            if (w < words.Length - 1)
            {
                morseText += "   "; 
            }
        }
        return morseText;
    }

    public static string ToText(this string morseCode)
    {
        if (morseCode is null)
        {
            throw new ArgumentNullException(nameof(morseCode));
        }
        var decodedMessage = "";
        var words = morseCode.Trim().Split("   "); 
        for (int w = 0; w < words.Length; w++)
        {
            var letters = words[w].Split(' ');
            foreach (var code in letters)
            {
                if (AlphabetDB.MorseAlphabetDB.ContainsValue(code))
                {
                    var letter = AlphabetDB.MorseAlphabetDB.FirstOrDefault(l => l.Value == code).Key;
                    decodedMessage += letter;
                }
               
            }
            if (w < words.Length - 1)
            {
                decodedMessage += " "; 
            }
        }
        return decodedMessage;
    }
}