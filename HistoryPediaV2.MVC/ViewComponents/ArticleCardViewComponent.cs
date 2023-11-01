using HistoryPediaV2.Core.ViewModels.Articles;
using HistoryPediaV2.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HistoryPediaV2.MVC.ViewComponents;

public class ArticleCardViewComponent: ViewComponent
{
    public IViewComponentResult Invoke(ArticleWithImageViewModel article)
    {
        return View(article);
    }
}