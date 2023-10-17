using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Data.Models;

[PrimaryKey("BlockInfoId")]
public sealed record BlockInfo(string BlockName,
    string Text,
    string BlockImageName,
    string ArticleName)
{
    public int BlockInfoId { get; set; }
    public string PrevName { get; set; }
    public Picture Image { get; set; }
    public int ArticleId { get; set; }

}