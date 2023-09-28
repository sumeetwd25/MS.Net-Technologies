using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIWebApp.Models;
using DIWebApp.Interfaces;

namespace DIWebApp.Controllers;

public class HomeController : Controller
{
    //Data members for invoking services
    //Data members are defined by interfaces & not by their concrete classes
    private readonly IHelloWorldService _helloWorldService;

    public HomeController(IHelloWorldService helloWorldService)
    {
        Console.WriteLine("Home controller instance is initialized");
        this._helloWorldService = helloWorldService;
    }

    public IActionResult Index()
    {
        Console.WriteLine("HomeController Index method is invoked");
        string message = this._helloWorldService.SayHello();
        ViewData["message"] = message;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
