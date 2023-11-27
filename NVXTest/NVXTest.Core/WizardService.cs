namespace NVXTest.Core;

public class WizardService
{
    public async Task<string> Encrypt(string textToEncrypt)
    {
        return textToEncrypt;
    }

    public async Task<string> Decrypt(string text)
    {
        return ReverseAlgorithm(text);
    }

    public string ReverseAlgorithm(string textToEncrypt)
    {
        var length = textToEncrypt.Length;
        
        return textToEncrypt.Select((t, i) => length - i - 1)
            .Aggregate("", (current, reverseIndex) => current + textToEncrypt[reverseIndex]);
    }
}