//Create a Kestral web server
Console.WriteLine("asp.net web app is initiated");
var builder = WebApplication.CreateBuilder(args);
Console.WriteLine("Kestral web server is created");

// Add services to the container.
builder.Services.AddControllersWithViews();
Console.WriteLine("ControllerViews service is added to Kestral");

var app = builder.Build();
Console.WriteLine("Kestral server is built successfully");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

Console.WriteLine("asp.net web app HTTP pipeline is being constructed");
app.UseHttpsRedirection();
app.UseStaticFiles();
Console.WriteLine("Static resources folder has been mapped");

app.UseRouting();
Console.WriteLine("Routing is enabled");

app.UseAuthorization();
Console.WriteLine("Route configuration is done");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
Console.WriteLine("Kestral server is listening on port");
