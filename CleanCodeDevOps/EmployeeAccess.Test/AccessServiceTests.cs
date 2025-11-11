using EmployeeAccess.Models;
using EmployeeAccess.Services;
using EmployeeAccess.TestData;

namespace EmployeeAccess.Test;

public class AccessServiceTests
{
    private readonly AccessService _sut = new AccessService();

    [Theory]
    [ClassData(typeof(EmployeeAccessTestData))]
    public void FromClass_CanAccessRestrictedArea_ReturnsExpected(Employee employee, bool expected)
    {
        var actual = _sut.CanAccessRestrictedArea(employee);
        Assert.Equal(expected, actual);
    }
    
}