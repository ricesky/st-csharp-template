using NUnit.Framework;
using SampleApp;

namespace SampleApp.Tests;

public class CalculatorTests
{
    [Test]
    public void Add_Works()
    {
        var calc = new Calculator();
        Assert.AreEqual(7, calc.Add(3, 4));
    }

    [Test]
    public void Subtract_Works()
    {
        var calc = new Calculator();
        Assert.AreEqual(1, calc.Subtract(5, 4));
    }

    [Test]
    public void Multiply_Works()
    {
        var calc = new Calculator();
        Assert.AreEqual(12, calc.Multiply(3, 4));
    }

    [Test]
    public void Divide_Works()
    {
        var calc = new Calculator();
        Assert.AreEqual(2, calc.Divide(10, 5));
    }

    [Test]
    public void Divide_ByZero_Throws()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(1, 0));
    }

    [TestCase(-2, "negative")]
    [TestCase(0, "zero")]
    [TestCase(3, "positive-odd")]
    [TestCase(4, "positive-even")]
    public void CategoryOf_CoversBranches(int input, string expected)
    {
        var calc = new Calculator();
        Assert.AreEqual(expected, calc.CategoryOf(input));
    }
}
