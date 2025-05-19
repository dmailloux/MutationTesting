namespace MutationTesting.Application.Interfaces;

public interface IMessageApplication
{
    public Task HandleMessage(string messageBody);
}