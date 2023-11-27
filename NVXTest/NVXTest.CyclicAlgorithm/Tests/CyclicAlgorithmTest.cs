using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NVXTest.CyclicAlgorithm.Tests;

[TestClass]
public class CyclicAlgorithmTest
{
    [TestMethod]
    public void CyclicTest()
    {
        var text = GetTextForCyclicAlgorithm();
        var textChanged = GetTextChangedWithCyclicAlgorithm();

        var resultService = GetServiceCyclicAlgorithm(text);
        
        SoAreEquals(textChanged, resultService);
    }

    [TestMethod]
    public void CyclicInvertedTest()
    {
        var text = GetTextForCyclicInvertedAlgorithm();
        var textChanged = GetTextChangedWithCyclicInvertedAlgorithm();

        var resultService = GetServiceCyclicInvertedAlgorithm(text);
        
        SoAreEquals(textChanged, resultService);
    }

    private string GetTextForCyclicAlgorithm()
    {
        return "maceniworu";
    }

    private string GetTextChangedWithCyclicAlgorithm()
    {
        return "mecinowura";
    }


    private string GetServiceCyclicInvertedAlgorithm(string text)
    {
        return CyclicAlgorithm.Get(text, true);
    }

    private string GetTextChangedWithCyclicInvertedAlgorithm()
    {
        return "maceniworu";
    }

    private string GetTextForCyclicInvertedAlgorithm()
    {
        return "mecinowura";
    }

    private string GetServiceCyclicAlgorithm(string text)
    {
        return CyclicAlgorithm.Get(text);
    }

    private void SoAreEquals(string textEncrypted, string resultTextEncrypted)
    {
        Assert.AreEqual(textEncrypted, resultTextEncrypted);
    }
}