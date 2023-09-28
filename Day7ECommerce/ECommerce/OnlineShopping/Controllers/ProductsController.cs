using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    //Set of action methods
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Update(int id)
    {
        return View();
    }

    public IActionResult Delete(int id)
    {
        return View();
    }
}