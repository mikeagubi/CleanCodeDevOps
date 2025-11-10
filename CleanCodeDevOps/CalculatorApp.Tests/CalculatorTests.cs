namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _sut = new();
    
    [Fact]
    public void Add_TwoPlusTwo_ReturnsFour()
    {
        //Arrange - forbered testdata och objekt
        int a = 2;
        int b = 2;
        int expected = 4;

        //Act
        int actual = _sut.Add(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Subtract_FiveMinusThree_ReturnsTwo()
    {
        //Arrange
        int a = 5;
        int b = 3;
        int expected = 2;

        //Act
        int actual = _sut.Subtract(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Multiply_threeTimesFour_ReturnsTwelve()
    {
        //Arrange
        int a = 3; 
        int b = 4;
        int expected = 12;

        //Act
        int actual = _sut.Multiply(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_SixDivideByTwo_ReturnsThree()
    {
        //Arrange
        int a = 6;
        int b = 2;
        double expected = 3;

        //Act
        double actual = _sut.Divide(a, b);


        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Divide_ByZero_ThrowDivideByZeroException()
    {
        //Arrange
        int a = 5;
        int b = 0;
        
       //Assert
       Assert.Throws<DivideByZeroException>(() => _sut.Divide(a, b));
    }


    [Theory]
    [InlineData(3, 2, 5)]
    [InlineData(1, 2, 3)]
    [InlineData(57, 13, 70)]
    public void CanAdd(int a, int b, int sum)
    {
        //Arrange
        var expected = sum;

        //Act
        var actual = _sut.Add(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    
    
    
    
    
    
}