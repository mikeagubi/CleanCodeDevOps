namespace CalculatorApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoPlusTwo_ReturnsFour()
    {
        //Arrange - forbered testdata och objekt
        var sut = new Calculator();
        int a = 2;
        int b = 2;
        int expected = 4;

        //Act
        int actual = sut.Add(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Subtract_FiveMinusThree_ReturnsTwo()
    {
        //Arrange
        var sut = new Calculator();
        int a = 5;
        int b = 3;
        int expected = 2;

        //Act
        int actual = sut.Subtract(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Multiply_threeTimesFour_ReturnsTwelve()
    {
        //Arrange
        Calculator sut = new();
        int a = 3;
        int b = 4;
        int expected = 12;

        //Act
        int actual = sut.Multiply(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_SixDivideByTwo_ReturnsThree()
    {
        //Arrange
        Calculator sut = new();
        int a = 6;
        int b = 2;
        int expected = 3;

        //Act
        double actual = sut.Divide(a, b);


        //Assert
    }
    
    
}