using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HistoryPediaV2.MVC.Models;

namespace HistoryPediaV2.MVC.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        _logger.Log(LogLevel.Error, "Error thrown: {errorId}", requestId);
        return View(new ErrorViewModel { RequestId = requestId});
    }
}
