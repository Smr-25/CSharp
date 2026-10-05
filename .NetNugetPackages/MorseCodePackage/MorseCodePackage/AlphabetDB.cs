namespace MorseCodePackage;

public static class AlphabetDB
{
    public static Dictionary<string, string> MorseAlphabetDB { get; set; } = new Dictionary<string, string>
    {
        { "a", ".-" },
        { "b", "-..." },
        { "c", "-.-." },
        { "d", "-.." },
        { "e", "." },
        { "f", "..-." },
        { "g", "--." },
        { "h", "...." },
        { "i", ".." },
        { "j", ".---" },
        { "k", "-.-" },
        { "l", ".-.." },
        { "m", "--" },
        { "n", "-." },
        { "o", "---" },
        { "p", ".--." },
        { "q", "--.-" },
        { "r", ".-." },
        { "s", "..." },
        { "t", "-" },
        { "u", "..-" },
        { "v", "...-" },
        { "w", ".--" },
        { "x", "-..-" },
        { "y", "-.--" },
        { "z", "--.." }
    };
}