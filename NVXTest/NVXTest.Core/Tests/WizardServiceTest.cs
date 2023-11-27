using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace NVXTest.Core.Tests;

[TestClass]
public class WizardServiceTest
{
    [TestMethod]
    public async Task EncryptTest()
    {
        var textToEncrypt = GetTextToEncrypt();
        var textEncrypted = GetTextEncrypted();

        var resultTextEncrypted = await EncryptText(textToEncrypt);

        SoAreEquals(textEncrypted, resultTextEncrypted);
    }
    
    [TestMethod]
    public async Task DecryptTest()
    {
        var textToDecrypt = GetTextToDecrypt();
        var textDecrypted = GetTextDecrypted();

        var resultTextDecrypted = await DecryptText(textToDecrypt);

        SoAreEquals(textDecrypted, resultTextDecrypted);
    }

    [TestMethod]
    public async Task ReverseAlgorithm()
    {
        var text = GetText();
        var reversedText = GetReversedText();

        var resultServiceReversed = GetServiceReverseAlgorithm(text);
        
        SoAreEquals(reversedText, resultServiceReversed);
    }

    [TestMethod]
    public async Task CyclicAlgorithmTest()
    {
        var text = GetTextForCyclicAlgorithm();
        var textChanged = GetTextChangedWithCyclicAlgorithm();

        var resultService = GetServiceCyclicAlgorithm(text);
        
        SoAreEquals(textChanged, resultService);
    }

    [TestMethod]
    public async Task CyclicInvertedAlgorithmTest()
    {
        var text = GetTextForCyclicInvertedAlgorithm();
        var textChanged = GetTextChangedWithCyclicInvertedAlgorithm();

        var resultService = GetServiceCyclicInvertedAlgorithm(text);
        
        SoAreEquals(textChanged, resultService);
    }

    private string GetServiceCyclicInvertedAlgorithm(string text)
    {
        var wizardService = new WizardService();

        return wizardService.CyclicAlgorithm(text, true);
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
        var wizardService = new WizardService();
        return wizardService.CyclicAlgorithm(text);
    }

    private string GetTextForCyclicAlgorithm()
    {
        return "maceniworu";
    }

    private string GetTextChangedWithCyclicAlgorithm()
    {
        return "mecinowura";
    }

    private string GetText()
    {
        return "prueba";
    }

    private string GetServiceReverseAlgorithm(string textToEncrypt)
    {
        var wizardService = new WizardService();

        return wizardService.ReverseAlgorithm(textToEncrypt);
    }

    private string GetReversedText()
    {
        return "abeurp";
    }

    private async Task<string> DecryptText(string textToDecrypt)
    {
        var wizardService = new WizardService();
        return await wizardService.Decrypt(textToDecrypt);
    }

    private string GetTextDecrypted()
    {
        return "prueba";
    }

    private string GetTextToDecrypt()
    {
        return "ebiarp";
    }

    private void SoAreEquals(string textEncrypted, string resultTextEncrypted)
    {
        Assert.AreEqual(textEncrypted, resultTextEncrypted);
    }

    private async Task<string> EncryptText(string textToEncrypt)
    {
        var wizardService = new WizardService();
        return await wizardService.Encrypt(textToEncrypt);
    }

    private string GetTextEncrypted()
    {
        return "ebiarp";
    }

    private string GetTextToEncrypt()
    {
        return "prueba";
    }
}