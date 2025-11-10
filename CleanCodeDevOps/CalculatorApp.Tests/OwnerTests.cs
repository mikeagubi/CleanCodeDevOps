namespace CalculatorApp.Tests;

[Collection(nameof(AdvancedCalculatorCollection))]
public class OwnerTests
{
    private readonly AdvancedCalculatorFixture _fixture;

    public OwnerTests(AdvancedCalculatorFixture fixture)
    {
        _fixture = fixture;
    }
    
    [Fact]
    public void Owner_Returns_Daniel()=> Assert.Equal("Daniel", _fixture.Calculator.Owner);
    
    
    
    
}