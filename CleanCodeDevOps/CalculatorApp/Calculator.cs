namespace CalculatorApp;

public class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"Adding {a} + {b}");
    }
    
    public void Subtract(int a, int b)
    {
        Log($"Subtracting {a} - {b}");
    }
    
    public void Multiply(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            throw new InvalidOperationException("Multiplication by zero is not allowed.");
        }
    }


    public void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero attempted");
        }
    }
    
    
    
    
    
    
    
    
    
    
    
}