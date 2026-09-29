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

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void Greet_NullEmptyOrWhitespace_ReturnsHelloWorld(string? name)
    {
        Assert.Equal("Hello, World!", Greeter.Greet(name));
    }
}
