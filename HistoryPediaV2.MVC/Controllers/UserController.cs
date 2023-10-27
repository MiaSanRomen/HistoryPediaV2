using System.Diagnostics;
using HistoryPediaV2.Core.Repositories;
using HistoryPediaV2.Data.Models;
using HistoryPediaV2.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HistoryPediaV2.MVC.Controllers;

public class UserController: Controller
{
    private readonly ILogger<HomeController> _logger;

    public UserController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public ActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> AddToFavorite(int id)
    {
        return RedirectToAction("Index");
    }
}