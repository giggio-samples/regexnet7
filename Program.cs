using System.Text.RegularExpressions;
Console.WriteLine(OldRegex.Bar("abc"));
Console.WriteLine(NewRegex.Bar("abc"));

public class OldRegex
{
    private static readonly Regex regex = new(@"abc|def", RegexOptions.IgnoreCase);
    public static bool Bar(string input) => regex.IsMatch(input);
}

public partial class NewRegex
{
    [GeneratedRegex(@"abc|def", RegexOptions.IgnoreCase)]
    private static partial Regex MyRegex();
    public static bool Bar(string input) => MyRegex().IsMatch(input);
}