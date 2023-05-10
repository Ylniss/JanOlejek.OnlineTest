namespace Questions;

public static class Question1
{
    public static string GetMiddle(string text)
    {
        if (text.Length == 0)
            return text;

        var isEven = text.Length % 2 == 0;
        var halfLength = text.Length / 2;
        return text.Substring(isEven ? halfLength - 1 : halfLength, isEven ? 2 : 1);
    }
}