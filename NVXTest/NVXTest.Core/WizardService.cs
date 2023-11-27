using NVXTest.Recursion;

namespace NVXTest.Core;

public class WizardService
{
    public async Task<string> Encrypt(string textToEncrypt)
    {
        var textEncrypted = ReverseAlgorithm.ReverseAlgorithm.Get(textToEncrypt);
        textEncrypted = CyclicAlgorithm.CyclicAlgorithm.Get(textEncrypted);
        textEncrypted = RecursiveAlgorithm.Get(textEncrypted);
        return textEncrypted;
    }

    public async Task<string> Decrypt(string text)
    {
        var textDecrypted = RecursiveAlgorithm.Get(text, true);
        textDecrypted = ReverseAlgorithm.ReverseAlgorithm.Get(textDecrypted);
        textDecrypted = CyclicAlgorithm.CyclicAlgorithm.Get(textDecrypted, true);
        return textDecrypted;
    }
}