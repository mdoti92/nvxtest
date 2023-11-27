namespace NVXTest.Core;

public class WizardService
{
    public async Task<string> Encrypt(string textToEncrypt)
    {
        var textEncrypted = ReverseAlgorithm.ReverseAlgorithm.Get(textToEncrypt);
        textEncrypted = CyclicAlgorithm.CyclicAlgorithm.Get(textEncrypted);
        textEncrypted = RecursiveAlgorithm(textEncrypted);
        return textEncrypted;
    }

    public async Task<string> Decrypt(string text)
    {
        var textDecrypted = RecursiveAlgorithm(text, true);
        textDecrypted = ReverseAlgorithm.ReverseAlgorithm.Get(textDecrypted);
        textDecrypted = CyclicAlgorithm.CyclicAlgorithm.Get(textDecrypted, true);
        return textDecrypted;
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