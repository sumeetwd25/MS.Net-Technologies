namespace DIWebApp.Services;
using DIWebApp.Interfaces;

public class HelloWorldService : IHelloWorldService
{
    public HelloWorldService()
    {
        Console.WriteLine("HelloWorldService instance is initialized");
    }

    public string SayHello()
    {
        return "Hello World";
    }
}