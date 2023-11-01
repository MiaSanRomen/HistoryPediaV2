using System.Diagnostics;
using HistoryPediaV2.Core.Repositories;
using HistoryPediaV2.Data.Models;
using HistoryPediaV2.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HistoryPediaV2.MVC.Controllers;

public class BlocksController: Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBlocksRepository _blocksRepository;

    public BlocksController(ILogger<HomeController> logger, IBlocksRepository blocksRepository)
    {
        _logger = logger;
        _blocksRepository = blocksRepository;
    }

    //[Authorize]
    public async Task<IActionResult> Edit(int id)
    {
        if (id != 0)
        {
            var block = await _blocksRepository.GetEditDetailsAsync(id);
            return View(block);
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
    
    //[Authorize]
    [HttpGet, ActionName("Delete")]
    public async Task<IActionResult> ConfirmDelete(int id)
    {
        if (id != 0)
        {
            BlockInfo article = await _blocksRepository.GetAsync<BlockInfo>(id);
            return View(article);
        }

        return NotFound();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        _logger.Log(LogLevel.Error, "Error thrown: {errorId}", requestId);
        return View(new ErrorViewModel { RequestId = requestId});
    }
}