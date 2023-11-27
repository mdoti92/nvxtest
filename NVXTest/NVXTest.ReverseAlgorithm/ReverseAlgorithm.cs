namespace NVXTest.ReverseAlgorithm;

public static class ReverseAlgorithm
{
    public static string Get(string textToEncrypt)
    {
        var length = textToEncrypt.Length;
        
        return textToEncrypt.Select((t, i) => length - i - 1)
            .Aggregate("", (current, reverseIndex) => current + textToEncrypt[reverseIndex]);
    }
}