using System.Diagnostics;
using HistoryPediaV2.Core.Repositories;
using HistoryPediaV2.Core.ViewModels.Articles;
using HistoryPediaV2.Data.Models;
using HistoryPediaV2.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HistoryPediaV2.MVC.Controllers;

public class ArticlesController: Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IArticlesRepository _articlesRepository;

    public ArticlesController(ILogger<HomeController> logger, IArticlesRepository articlesRepository)
    {
        _logger = logger;
        _articlesRepository = articlesRepository;
    }

    public async Task<IActionResult> Details(long id)
    {
        var article = await _articlesRepository.GetDetailsAsync(id);
        return View(article);
    }

    [Authorize]
    public async Task<IActionResult> Edit(long id)
    {
        if (id != -1)
        {
            var article = await _articlesRepository.GetEditDetailsAsync(id);
            return View(article);
        }
        else
        {
            ArticleEditViewModel article = new ArticleEditViewModel(id,
                "New article",
                "Short description",
                "Details",
                -1);
            return View();
        }

        return NotFound();
    }
    
    [Authorize]
    [HttpGet, ActionName("Delete")]
    public async Task<IActionResult> ConfirmDelete(long id)
    {
        if (id != 0)
            return NotFound();
        
        Article article = await _articlesRepository.GetAsync<Article>(id);
        return View(article);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        _logger.Log(LogLevel.Error, "Error thrown: {errorId}", requestId);
        return View(new ErrorViewModel { RequestId = requestId});
    }
}