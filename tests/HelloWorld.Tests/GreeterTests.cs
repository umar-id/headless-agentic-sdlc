using HelloWorld;

namespace HelloWorld.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsHelloWorld()
    {
        Assert.Equal("Hello, World!", Greeter.Greet());
    }

    [Fact]
    public void Greet_WithName_ReturnsPersonalGreeting()
    {
        Assert.Equal("Hello, Umar!", Greeter.Greet("Umar"));
    }

    [Fact]
    public void Greet_NameWithSurroundingSpaces_TrimsName()
    {
        Assert.Equal("Hello, Umar!", Greeter.Greet("  Umar  "));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void Greet_NullEmptyOrWhitespace_ReturnsHelloWorld(string? name)
    {
        Assert.Equal("Hello, World!", Greeter.Greet(name));
    }

    [Fact]
    public void Farewell_ReturnsGoodbye()
    {
        Assert.Equal("Goodbye!", Greeter.Farewell());
    }

    [Fact]
    public void Farewell_WithName_ReturnsPersonalFarewell()
    {
        Assert.Equal("Goodbye, Umar!", Greeter.Farewell("Umar"));
    }

    [Fact]
    public void Farewell_NameWithSurroundingSpaces_TrimsName()
    {
        Assert.Equal("Goodbye, Umar!", Greeter.Farewell("  Umar  "));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void Farewell_NullEmptyOrWhitespace_ReturnsGoodbye(string? name)
    {
        Assert.Equal("Goodbye!", Greeter.Farewell(name));
    }
}
