namespace HistoryPediaV2.Core.Configurations
{
    public interface IEmailConfiguration
    {
        string? SmtpServer { get; set; }
        int SmtpPort { get; set; }
        string? SmtpUsername { get; set; }
        string? SmtpPassword { get; set; }
    }
}
