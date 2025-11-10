namespace CalculatorApp.Tests;

public class AdvancedCalculatorTheoryTests
{
    
    //HELT FAIL TEST, VISAR PRECIS INGENTING OAVSETT VÄRDE!!!!
    [Theory]
    [InlineData("Daniel", false)]
    [InlineData("StudentCalc", false)]
    [InlineData("TI-84", false)]
    public void OwnerName_IsScientificGlafMatches(string owner, bool expectedScientific)
    {
        //Arrange
        var sut = new AdvancedCalculator()
        {
            Owner = owner,
            IsScientific = expectedScientific
        };

        //Act
        var actual = sut.IsScientific;

        //Assert
        Assert.Equal(expectedScientific, actual);

    }
}