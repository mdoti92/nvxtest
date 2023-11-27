using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NVXTest.ReverseAlgorithm.Tests;

[TestClass]
public class ReverseAlgorithmTest
{
    [TestMethod]
    public void ReverseTest()
    {
        var text = GetText();
        var reversedText = GetReversedText();

        var resultServiceReversed = GetServiceReverseAlgorithm(text);
        
        SoAreEquals(reversedText, resultServiceReversed);
    }

    private string GetText()
    {
        return "prueba";
    }

    private string GetReversedText()
    {
        return "abeurp";
    }

    private string GetServiceReverseAlgorithm(string textToEncrypt)
    {
        return ReverseAlgorithm.Get(textToEncrypt);
    }

    private void SoAreEquals(string textEncrypted, string resultTextEncrypted)
    {
        Assert.AreEqual(textEncrypted, resultTextEncrypted);
    }
}