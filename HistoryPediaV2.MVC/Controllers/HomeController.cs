using System.Diagnostics;
using HistoryPediaV2.Core.Repositories;
using HistoryPediaV2.Data.Models;
using Microsoft.AspNetCore.Mvc;
using HistoryPediaV2.MVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace HistoryPediaV2.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IArticlesRepository _articlesRepository;

    public HomeController(ILogger<HomeController> logger, IArticlesRepository articlesRepository)
    {
        _logger = logger;
        _articlesRepository = articlesRepository;
    }

    public async Task<IActionResult> Index(string name)
    {
        var articles = await _articlesRepository.GetByNameAsync(name);
        return View(articles);
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

    [HttpPost]
    public IActionResult Edit(BlockInfo blockInfo)
    {
        return RedirectToAction("Edit", "Articles");
    }
}
