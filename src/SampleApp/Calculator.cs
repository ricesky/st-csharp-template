namespace SampleApp;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }

    // Simple branching to contribute to branch coverage
    public string CategoryOf(int x)
    {
        if (x < 0) return "negative";
        if (x == 0) return "zero";
        return (x % 2 == 0) ? "positive-even" : "positive-odd";
    }
}
