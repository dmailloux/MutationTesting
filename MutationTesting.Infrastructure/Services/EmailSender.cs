using Microsoft.Extensions.Logging;
using MutationTesting.Application.Interfaces;

namespace MutationTesting.Infrastructure.Services;

public class EmailSender(ILogger<EmailSender> logger) : IEmailSender
{
    public Task SendEmailAsync(string messageBody)
    {
        logger.LogInformation("{MessageBody}", messageBody);
        return Task.CompletedTask;
    }
}