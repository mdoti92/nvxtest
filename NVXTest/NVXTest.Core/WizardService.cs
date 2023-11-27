namespace NVXTest.Core;

public class WizardService
{
    public async Task<string> Encrypt(string textToEncrypt)
    {
        var textEncrypted = ReverseAlgorithm.ReverseAlgorithm.Get(textToEncrypt);
        textEncrypted = CyclicAlgorithm(textEncrypted);
        textEncrypted = RecursiveAlgorithm(textEncrypted);
        return textEncrypted;
    }

    public async Task<string> Decrypt(string text)
    {
        var textDecrypted = RecursiveAlgorithm(text, true);
        textDecrypted = ReverseAlgorithm.ReverseAlgorithm.Get(textDecrypted);
        textDecrypted = CyclicAlgorithm(textDecrypted, true);
        return textDecrypted;
    }

    public string CyclicAlgorithm(string text, bool reverse = false)
    {
        var vocals = SetUpVocals(reverse);

        var result = "";
        foreach (var t in text)
        {
            if (vocals.TryGetValue(t, out var vocal))
            {
                result += vocal;
            }
            else
            {
                result += t;
            }
        }

        return result;
    }

    private static Dictionary<char, char> SetUpVocals(bool reverse)
    {
        var vocals = new Dictionary<char, char>();
        if (reverse)
        {
            vocals.Add('a', 'u');
            vocals.Add('e', 'a');
            vocals.Add('i', 'e');
            vocals.Add('o', 'i');
            vocals.Add('u', 'o');
            vocals.Add('A', 'U');
            vocals.Add('E', 'A');
            vocals.Add('I', 'E');
            vocals.Add('O', 'I');
            vocals.Add('U', 'O');
            
            return vocals;
        }
        
        vocals.Add('a', 'e');
        vocals.Add('e', 'i');
        vocals.Add('i', 'o');
        vocals.Add('o', 'u');
        vocals.Add('u', 'a');
        vocals.Add('A', 'E');
        vocals.Add('E', 'I');
        vocals.Add('I', 'O');
        vocals.Add('O', 'U');
        vocals.Add('U', 'A');
        return vocals;
    }

    public string RecursiveAlgorithm(string text, bool reverse = false)
    {
        if (text.Length > 0)
        {
            var move = reverse ? -2 : 2; 
            return (char)((int)text[0] + move) + RecursiveAlgorithm(text.Remove(0, 1), reverse);   
        }

        return "";
    }
}