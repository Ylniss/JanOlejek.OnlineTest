namespace Questions;

public static class Question2
{
    public static string ParseToHtml(string atxHeader)
    {
        if (!atxHeader.StartsWith("#"))
            return atxHeader;

        var headerValue = GetHeaderValue(atxHeader);

        if (headerValue > 6 || char.IsWhiteSpace(atxHeader[headerValue + 1]))
            return atxHeader;

        var headerText = atxHeader[(headerValue + 1)..];
        return $"<h{headerValue}>{headerText}</h{headerValue}>";
    }

    private static int GetHeaderValue(string atxHeader)
    {
        for (var i = 0; i < atxHeader.Length; ++i)
            if (atxHeader[i] != '#')
                return i;
        return 0;
    }
}