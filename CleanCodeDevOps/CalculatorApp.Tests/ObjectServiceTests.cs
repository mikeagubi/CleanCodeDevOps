namespace CalculatorApp.Tests;

public class ObjectServiceTests
{
    // Assert.Null(obj);
    [Fact]
    public void Null_IsNull() {
        var sut = new ObjectService();
        var actual = sut.GetNull();
        Assert.Null(actual);
    }

    // Assert.True(condition);
    [Fact]
    public void True_IsTrue() {
        Assert.True(1 + 1 == 2);
    }

    // Assert.Same(expected, actual);
    [Fact]
    public void Same_IsSame() {
        var sut = new ObjectService();
        var expected = sut.GetSame();
        var actual = expected;
        Assert.Same(expected, actual);
    }

    // Assert.IsType<T>(obj);
    [Fact]
    public void Type_IsInt() {
        var actual = 123;
        Assert.IsType<int>(actual);
    }

    // Assert.Throws<SpectacularCrashException>(() => sut.Method());
    [Fact]
    public void Throws_Exception() {
        var sut = new ObjectService();
        Assert.Throws<InvalidOperationException>(() => sut.Crash());
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}