using System.Net.Mail;
using HistoryPediaV2.Core.Configurations;
using MimeKit;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace HistoryPediaV2.Core.AdditionalServices
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;
        private readonly SmtpClient _smtpClient = new SmtpClient();

        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
            _smtpClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, false);
            
            _smtpClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
        }

        public async Task SendEmailAsync(string login, string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("HistoryPedia V2", _emailConfiguration.SmtpUsername));
            emailMessage.To.Add(new MailboxAddress(login, email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            await _smtpClient.SendAsync(emailMessage);

            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 465, true);
            await client.AuthenticateAsync("msr.personal.work@gmail.com", "Rr12345678");
            await client.SendAsync(emailMessage);
            
            await client.DisconnectAsync(true);
        }
    }
}