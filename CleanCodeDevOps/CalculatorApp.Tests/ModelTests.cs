namespace CalculatorApp.Tests;
[Collection(nameof(AdvancedCalculatorCollection))]
public class ModelTests
{
    private readonly AdvancedCalculatorFixture _fixture;

    public ModelTests(AdvancedCalculatorFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Model_ContainsTI()
    {
        //Arrange
        var expected = "TI";

        //Act
        var actual = _fixture.Calculator.Model;

        //Assert
        Assert.Contains(expected, actual);
    }

    [Fact]
    public void Model_IsScientific_ReturnsTrue()
    {
        var act = _fixture.Calculator.IsScientific;
        Assert.True(act);
    }
    
    
    
    
    
    
}