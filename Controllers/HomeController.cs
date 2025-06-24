using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EduConnect.Models;

namespace EduConnect.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Universities()
    {
        return View();
    }

    public IActionResult Programs()
    {
        return View();
    }

    public IActionResult Events()
    {
        return View();
    }

    public IActionResult Videos()
    {
        return View();
    }

    public IActionResult ApplyNow()
    {
        return View();
    }

    public IActionResult EventDetail(int id)
    {
        return View();
    }

    public IActionResult NewsDetail(int id)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
