using DIWebApp.Interfaces;
using DIWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

//Register dependencies which are essential at runtime for execution
//Configure services needed at runtime
//Possible services creation contexts: AddTransient, AddScope, AddSingleton
builder.Services.AddSingleton<IHelloWorldService, HelloWorldService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
