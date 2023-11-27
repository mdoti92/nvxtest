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
        return "abeurp";
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
        return "prueba";
    }

    private string GetTextToEncrypt()
    {
        return "prueba";
    }
}