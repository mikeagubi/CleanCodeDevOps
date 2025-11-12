using Xunit.Abstractions;

namespace CalculatorApp.Tests;

public class AdvancedCalculatorTests : IClassFixture<AdvancedCalculatorFixture>
{
    private readonly AdvancedCalculatorFixture _calculatorFixture;
    private readonly AdvancedCalculator _sut; 

    public AdvancedCalculatorTests(AdvancedCalculatorFixture calculatorFixture)
    {
        _calculatorFixture = calculatorFixture;
        _sut = _calculatorFixture.Calculator;
    }
    
    [Fact]
    public void Owner_IsDaniel()
    {
        string expected = "Daniel";
        Assert.Equal(expected, _sut.Owner);
    }
    
    [Fact]
    public void Model_Contains_TI() => Assert.Contains("TI", _sut.Model);
    
    [Fact]
    public void Calculator_IsScientific_IsTrue() => Assert.True(_sut.IsScientific);

    [Fact]
    public void Add_TwoPlusFive_ReturnsSeven() => Assert.Equal(7, _sut.Add(2, 5));







}