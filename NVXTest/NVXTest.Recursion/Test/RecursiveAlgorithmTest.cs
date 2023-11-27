using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NVXTest.Recursion.Test;

[TestClass]
public class RecursiveAlgorithmTest
{
    [TestMethod]
    public void RecursionAlgorithmTest()
    {
        var text = GetText();
        var textToObtain = GetTextToObtain();

        var resultService = GetSericeRecursiveAlgorithm(text);
        
        SoAreEquals(textToObtain, resultService);
    }

    [TestMethod]
    public void RecursionReverseAlgorithmTest()
    {
        var text = GetTextForRecursiveAlgorithm();
        var textToObtain = GetTextToObtenForRecursiveAlgorithm();

        var resultService = GetSericeRecursiveReverseAlgorithm(text);
        
        SoAreEquals(textToObtain, resultService);
    }private string GetTextToObtenForRecursiveAlgorithm()
    {
        return GetText();
    }

    private string GetTextForRecursiveAlgorithm()
    {
        return GetTextToObtain();
    }

    private string GetSericeRecursiveReverseAlgorithm(string text)
    {
        return RecursiveAlgorithm.Get(text, true);
    }

    private string GetSericeRecursiveAlgorithm(string text)
    {
        return RecursiveAlgorithm.Get(text);
    }
    
    private string GetText()
    {
        return "prueba";
    }

    private string GetTextToObtain()
    {
        return "rtwgdc";
    }
    private void SoAreEquals(string textEncrypted, string resultTextEncrypted)
    {
        Assert.AreEqual(textEncrypted, resultTextEncrypted);
    }
}