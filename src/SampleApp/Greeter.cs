namespace SampleApp;

public class Greeter
{
    public string Greet(string? name, int hour)
    {
        string target = string.IsNullOrWhiteSpace(name) ? "there" : name!.Trim();
        string prefix = hour switch
        {
            >= 5 and < 12 => "Good morning",
            >= 12 and < 18 => "Good afternoon",
            >= 18 or < 5 => "Good evening",
            _ => "Hello"
        };
        return $"{prefix}, {target}!";
    }
}
