using HistoryPediaV2.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HistoryPediaV2.MVC.ViewComponents;

public class ArticleCardViewComponent: ViewComponent
{
    public IViewComponentResult Invoke(Article article)
    {
        return View(article);
    }
}