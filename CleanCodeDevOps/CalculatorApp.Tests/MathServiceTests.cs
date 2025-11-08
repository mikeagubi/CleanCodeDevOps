namespace CalculatorApp.Tests;

public class MathServiceTests
{
    [Fact]
    public void ReturnsSum()
    {
        var sut = new MathService();
        int a = 3;
        int b = 2;
        var expected = 5;
        var actual = sut.Add(a, b);
        Assert.Equal(expected, actual, actual);
    }

    [Fact]
    public void Pi_IsCloseEnough()
    {
        var sut = new MathService();
        var expected = 3.141;
        var actual = sut.GetPi();
        Assert.Equal(expected, actual, 3);
    }

    [Fact]
    public void Sum_IsInRange()
    {
        var sut = new MathService();
        var actual = sut.Add(6, 3);
        Assert.InRange(actual,8,9);
    }
    
    [Fact]
    public void Sum_IsNotInRange()
    {
        var sut = new MathService();
        var actual = sut.Add(6, 3);
        Assert.NotInRange(actual,11,12);
    }
    
    
    
    
    
    
}