using System.Text.RegularExpressions;

namespace CalculatorApp.Tests;

public class StringServiceTest
{
    [Fact]
    public void Greet_IsExact()
    {
        var sut = new StringService();
        var expected = "Hello world";
        var actual = sut.Greet();
        Assert.Equal(actual.ToLower(), expected.ToLower());
    }
    
    [Fact]
    public void Echo_IgnoreCase()
    {
        var sut = new StringService();
        string expected = "test";
        var actual = sut.Echo("TEST");
        Assert.Equal(expected, actual, ignoreCase: true);
    }

    [Fact]
    public void Greet_ContainsHello()
    {
        var sut = new StringService();
        string actual = sut.Greet();
        Assert.Contains("Hello", actual);
        
    }

    [Fact]
    public void Greet_EndsWithWord()
    {
        StringService sut = new();
        var actual = sut.Greet();
        Assert.EndsWith("d", actual);
    }

    [Fact]
    public void Echo_MatchesRegex()
    {
        var sut = new StringService();
        string actual = sut.Echo("Test123");
        Assert.Matches(@"^[A-Za-z]{4}[1-9]{3}$", actual);
    }
    
    
    
    
    
    
    
    
    
    
}