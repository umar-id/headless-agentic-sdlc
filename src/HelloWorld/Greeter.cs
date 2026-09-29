namespace HelloWorld;

public static class Greeter
{
    public static string Greet() => "Hello, World!";

    public static string Greet(string? name) =>
        string.IsNullOrWhiteSpace(name) ? Greet() : $"Hello, {name.Trim()}!";

    public static string Farewell() => "Goodbye!";

    public static string Farewell(string? name) =>
        string.IsNullOrWhiteSpace(name) ? Farewell() : $"Goodbye, {name.Trim()}!";
}
