namespace HistoryPediaV2.Core.AdditionalServices;

public interface IEmailService
{
    Task SendEmailAsync(string login, string email, string subject, string message);
}