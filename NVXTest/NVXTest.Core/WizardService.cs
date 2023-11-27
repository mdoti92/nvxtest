namespace NVXTest.Core;

public class WizardService
{
    public async Task<string> Encrypt(string textToEncrypt)
    {
        var textEncrypted = ReverseAlgorithm(textToEncrypt);
        textEncrypted = CyclicAlgorithm(textEncrypted);
        return textEncrypted;
    }

    public async Task<string> Decrypt(string text)
    {
        var textDecrypted = CyclicInvertedAlgorithm(text);
        textDecrypted = ReverseAlgorithm(textDecrypted);
        return textDecrypted;
    }

    public string ReverseAlgorithm(string textToEncrypt)
    {
        var length = textToEncrypt.Length;
        
        return textToEncrypt.Select((t, i) => length - i - 1)
            .Aggregate("", (current, reverseIndex) => current + textToEncrypt[reverseIndex]);
    }

    public string CyclicAlgorithm(string text)
    {
        var vocals = new Dictionary<char, char>();
        vocals.Add('a', 'e');
        vocals.Add('e', 'i');
        vocals.Add('i', 'o');
        vocals.Add('o', 'u');
        vocals.Add('u', 'a');

        var result = "";
        for (int index = 0; index < text.Length; index++)
        {
            if (vocals.ContainsKey(text[index]))
            {
                 result += vocals[text[index]];
            }
            else
            {
                result += text[index];
            }
        }

        return result;
    }

    public string CyclicInvertedAlgorithm(string text)
    {
        var vocals = new Dictionary<char, char>();
        vocals.Add('a', 'u');
        vocals.Add('e', 'a');
        vocals.Add('i', 'e');
        vocals.Add('o', 'i');
        vocals.Add('u', 'o');

        var result = "";
        for (int index = 0; index < text.Length; index++)
        {
            if (vocals.ContainsKey(text[index]))
            {
                result += vocals[text[index]];
            }
            else
            {
                result += text[index];
            }
        }

        return result;
    }
}