using Questions;
using Xunit;

namespace Tests;

public class UnitTests
{
    [Theory]
    [InlineData("es", "test")]
    [InlineData("t", "testing")]
    [InlineData("dd", "middle")]
    [InlineData("A", "A")]
    [InlineData("", "")]
    public void GetMiddleShouldReturnMiddleCharacters(string expected, string text)
    {
        var result = Question1.GetMiddle(text);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("<h1>h</h1>", "# h")]
    [InlineData("<h2>Header</h2>", "## Header")]
    [InlineData("<h3>Header</h3>", "### Header")]
    [InlineData("<h4>Header</h4>", "#### Header")]
    [InlineData("<h5>Header  </h5>", "##### Header  ")]
    [InlineData("<h6>H e a d e r</h6>", "###### H e a d e r")]
    [InlineData("<h6>###h###</h6>", "###### ###h###")]
    [InlineData("", "")]
    public void ParseToHtmlShouldReturnCorrectHeader(string expected, string atxHeader)
    {
        var result = Question2.ParseToHtml(atxHeader);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("####### too many hashes")]
    [InlineData("##  too many spaces between")]
    [InlineData("  ## spaces before")]
    [InlineData("no hashes")]
    public void ParseToHtmlShouldReturnInputBack(string incorrectAtxHeader)
    {
        var result = Question2.ParseToHtml(incorrectAtxHeader);

        Assert.Equal(incorrectAtxHeader, result);
    }
}