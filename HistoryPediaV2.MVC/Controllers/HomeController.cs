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

    public async Task<IActionResult> Details(int id)
    {
        Article article = await _articlesRepository.GetAsync<Article>(id);
        return View(article);
    }

    [Authorize]
    public async Task<IActionResult> Edit(int id)
    {
        if (id != 0)
        {
            Article article = await _articlesRepository.GetAsync<Article>(id);
            return View(article);
        }
        else
        {
            // Article article = new Article();
            // article.Name = "New article";
            // article.Blocks = DataClass.BlocksTempList;
            // DataClass.TempArticle = article;
            // return View(article);
        }

        return NotFound();
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
