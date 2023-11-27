using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }

    private string GetTextToObtenForRecursiveAlgorithm()
    {
        return GetText();
    }

    private string GetTextForRecursiveAlgorithm()
    {
        return GetTextToObtain();
    }

    private string GetSericeRecursiveReverseAlgorithm(string text)
    {
        var wizardSerice = new WizardService();
        return wizardSerice.RecursiveAlgorithm(text, true);
    }

    private string GetSericeRecursiveAlgorithm(string text)
    {
        var wizardSerice = new WizardService();
        return wizardSerice.RecursiveAlgorithm(text);
    }

    private string GetTextToObtain()
    {
        return "rtwgdc";
    }
    
    private string GetText()
    {
        return "prueba";
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
        return "gdkctr";
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
        return "gdkctr";
    }

    private string GetTextToEncrypt()
    {
        return "prueba";
    }
}