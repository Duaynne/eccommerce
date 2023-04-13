using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

public class ShoppingController : Controller
{
    private readonly ILogger<ShoppingController> _logger;

    public ShoppingController(ILogger<ShoppingController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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