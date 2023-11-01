using System.ComponentModel.DataAnnotations.Schema;
using HistoryPediaV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Core.ViewModels.Articles;

public sealed record ArticleShortViewModel(
    long ArticleId,
    string Name,
    string ShortInfo);