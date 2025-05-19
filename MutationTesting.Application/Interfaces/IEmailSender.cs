namespace MutationTesting.Application.Interfaces;

public interface IEmailSender
{
    public Task SendEmailAsync(string messageBody);
}