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
    
    
    
    
    
    
    
    
    
    
}