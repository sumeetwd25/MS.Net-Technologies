//Kestral Web Server
//Cross platform web server
//Lightweight server
//Linux, MacOS, Windows
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//HTTP Get request has been mapped with respective arrow function
//app.MapGet(urlendpoint, callback function)
app.MapGet("/", () => "Hello World!");
app.MapGet("/aboutus", () => "Welcome to IET");

app.Run();