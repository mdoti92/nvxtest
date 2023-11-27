namespace NVXTest.Recursion;

public static class RecursiveAlgorithm
{

    public static string Get(string text, bool reverse = false)
    {
        if (text.Length > 0)
        {
            var move = reverse ? -2 : 2; 
            return (char)((int)text[0] + move) + Get(text.Remove(0, 1), reverse);   
        }

        return "";
    }
}