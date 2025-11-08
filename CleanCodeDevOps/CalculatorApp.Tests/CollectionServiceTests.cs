namespace CalculatorApp.Tests;

public class CollectionServiceTests
{
    [Fact]
    public void Items_ContainsTwo()
    {
        var sut = new CollectionService();
        var actual = sut.GetItems();
        Assert.Contains("two" , actual);
    }
    
    [Fact]
    public void Items_IsEmpty()
    {
        var sut = new CollectionService();
        var actual = sut.GetEmpty();
        Assert.Empty(actual);
    }

    [Fact]
    public void AllItems_AreLowerCase1()
    {
        var sut = new CollectionService();
        var actual = sut.GetItems();
        Assert.All(actual, item => Assert.True(item == item.ToLower()));
    }
    //Metoden ovan samma som denna
    [Fact]
    public void AllItems_AreLowerCase2()
    {
        var sut = new CollectionService();
        var actual = sut.GetItems();
        foreach (var item in actual)
        {
            Assert.True(item == item.ToLower());
        }
    }
}