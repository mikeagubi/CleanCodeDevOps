using System.Collections;
using System.Text.Json;
using EmployeeAccess.Models;

namespace EmployeeAccess.TestData;

public class EmployeeAccessJsonTestData : IEnumerable<object[]>
{
    private const string FilePath = "TestData/employee_access_cases.json";
    private class EmployeeAccessCase
    {
        public Employee Employee { get; set; }
        public bool Expected { get; set; }
    }
    
    private static IEnumerable<EmployeeAccessCase> LoadFromJson()
    {

        if (!File.Exists(FilePath))
        {
            throw new FileNotFoundException($"File {FilePath} Saknas");
        }
        
        var json = File.ReadAllText(FilePath);
        var cases = JsonSerializer.Deserialize<List<EmployeeAccessCase>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return cases ?? new List<EmployeeAccessCase>();
    }
    
    public IEnumerator<object[]> GetEnumerator()
    {
        foreach(var testCase in LoadFromJson())
        {
            yield return new object[] { testCase.Employee, testCase.Expected };
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
}