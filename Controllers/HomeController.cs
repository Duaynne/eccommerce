using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult about()
    {
        return View();
    }

    public IActionResult cart()
    {
        return View();
    }

    public IActionResult checkout()
    {
        return View();
    }

    public IActionResult contact()
    {
        return View();
    }
    
    public IActionResult faq()
    {
        return View();
    }
public IActionResult index()
    {
        return View();
    }

    public IActionResult login()
    {
        return View();
    }

    public IActionResult order()
    {
        return View();
    }

       public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult product()
    {
        return View();
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
