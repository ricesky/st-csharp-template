using NUnit.Framework;
using SampleApp;

namespace SampleApp.Tests;

public class GreeterTests
{
    [TestCase(null, 9, "Good morning, there!")]
    [TestCase("  Rizky  ", 14, "Good afternoon, Rizky!")]
    [TestCase("", 20, "Good evening, there!")]
    [TestCase("Dev", 3, "Good evening, Dev!")]
    public void Greet_ReturnsExpected(string? name, int hour, string expected)
    {
        var g = new Greeter();
        Assert.AreEqual(expected, g.Greet(name, hour));
    }
}
