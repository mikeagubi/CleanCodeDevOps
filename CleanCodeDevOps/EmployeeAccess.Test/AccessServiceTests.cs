using EmployeeAccess.Models;
using EmployeeAccess.Services;
using EmployeeAccess.TestData;

namespace EmployeeAccess.Test;

public class AccessServiceTests
{
    private readonly AccessService _sut = new AccessService();

    
    public static IEnumerable<object[]> GetAccessCases()

    {
        yield return new object[] { new Employee { Name = "Anna", Role = "Manager", IsClockedIn = true }, true };
        yield return new object[] { new Employee { Name = "Erik", Role = "Staff", IsClockedIn = true }, false };
        yield return new object[] { new Employee { Name = "Lisa", Role = "Manager", IsClockedIn = false }, false };
    }
    
    
    
    [Theory]
    [ClassData(typeof(EmployeeAccessTestData))]
    public void FromClass_CanAccessRestrictedArea_ReturnsExpected(Employee employee, bool expected)
    {
        var actual = _sut.CanAccessRestrictedArea(employee);
        Assert.Equal(expected, actual);
    }


    [Theory]
    [MemberData(nameof(GetAccessCases))]
    public void FromMember_CanAccessRestrictedArea_ReturnsExpected(Employee employee, bool expected)
    {
        var actual = _sut.CanAccessRestrictedArea(employee);
        Assert.Equal(expected, actual);
    }
    
}