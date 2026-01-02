namespace CriptografiaPackage;

public static class Criptografia
{
    public static string ToEncrypt(this string message)
    {
        char[] messageChr = message.ToLower().ToCharArray();
        for (int i = 0; i < messageChr.Length; i++)
        {
            for (int j = 0; j < Alphabet.Letters.Length; j++)
            {
                if (messageChr[i] == Alphabet.Letters[j])
                {
                    messageChr[i] = Alphabet.Letters[(j + 3) % Alphabet.Letters.Length];
                    break;
                }
            }
        }

        return new string(messageChr);
    }
}