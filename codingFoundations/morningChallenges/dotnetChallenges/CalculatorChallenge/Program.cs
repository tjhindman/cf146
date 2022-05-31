Calculator calculator = new Calculator();

System.Console.WriteLine($"Add(int num1, int num2) result: {calculator.Add(6,2)}");
// expected: 8
System.Console.WriteLine($"Add(double num1, int num2) result: {calculator.Add(6.5,2)}");
// expected: 8.5
System.Console.WriteLine($"Add(double num1, double num2) result: {calculator.Add(6.7,2.8)}");
// expected: 9.5
System.Console.WriteLine($"Add(params int[] values) result: {calculator.Add(6, 2, 10, 20, 30, 12)}");
// expected: 80
System.Console.WriteLine($"Add(params int[] values) result: {calculator.Add(10)}");
// expected: 10
System.Console.WriteLine($"Subtract(int num1, int num2) result: {calculator.Subtract(6,2)}");
// expected: 4
System.Console.WriteLine($"Multiply(int num1, int num2) result: {calculator.Multiply(6,2)}");
// expected: 12
System.Console.WriteLine($"Divide(int num1, int num2) result: {calculator.Divide(6,2)}");
// expected: 3

public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // ! overloading class methods
    // type conversion ex
    public double Add(double num1, int num2)
    {
        return num1 + (double)num2;
    }

    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // ! accepting arguments based on user input
    public int Add(params int[] values)
    {
        int sum = 0;

        foreach (int value in values)
        {
            sum += value; // "+=" is shorthand for "sum = sum + value" in this case
        }

        return sum;
    }

    
    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    
    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}