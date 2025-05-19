using MutationTesting.Application.Interfaces;

namespace MutationTesting.Application;

public class MessageApplication(IEmailSender emailSender) : IMessageApplication
{
    public async Task HandleMessage(string messageBody)
    {
        // do some important processing or whatever...
        string newMessageBody = messageBody.ToUpper();

        await emailSender.SendEmailAsync(newMessageBody);

        // do some other stuff maybe...
    }
}