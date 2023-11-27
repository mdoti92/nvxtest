using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NVXTest.Core.Tests;

[TestClass]
public class WizardServiceTest
{
    [TestMethod]
    public async Task EncryptTest()
    {
        var textToEncrypt = GetTextToEncrypt();
        var textEncrypted = GetTextEncrypted(textToEncrypt);

        var resultTextEncrypted = await EncryptText(textToEncrypt);

        SoAreEquals(textEncrypted, resultTextEncrypted);
    }
    
    [TestMethod]
    public async Task DecryptTest()
    {
        var textToDecrypt = GetTextToDecrypt();
        var textDecrypted = GetTextDecrypted(textToDecrypt);

        var resultTextDecrypted = await DecryptText(textToDecrypt);

        SoAreEquals(textDecrypted, resultTextDecrypted);
    }

    private async Task<string> DecryptText(string textToDecrypt)
    {
        var wizardService = new WizardService();
        return await wizardService.Decrypt(textToDecrypt);
    }

    private string GetTextDecrypted(string textToDecrypt)
    {
        return "Prueba";
    }

    private string GetTextToDecrypt()
    {
        return "Prueba";
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

    private string GetTextEncrypted(string textToEncrypt)
    {
        return "prueba";
    }

    private string GetTextToEncrypt()
    {
        return "prueba";
    }
}