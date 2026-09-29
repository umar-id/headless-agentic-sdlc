using HelloWorld;
using Xunit;

namespace HelloWorld.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsHelloWorld()
    {
        Assert.Equal("Hello, World!", Greeter.Greet());
    }
}
