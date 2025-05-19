using Moq;
using MutationTesting.Application.Interfaces;

namespace MutationTesting.Application.Test;

public class MessageApplicationTests
{
    // ========================================================================
    // Original Test
    // ========================================================================
    // [Test]
    // public async Task HandleMessage_ShouldSendEmail()
    // {
    //     // Arrange
    //     var emailSenderMock = new Mock<IEmailSender>();
    //     var sut = new MessageApplication(emailSenderMock.Object);
    //     const string messageBodyInput = "some important message";
    //
    //     // Act
    //     await sut.HandleMessage(messageBodyInput);
    //
    //     // Assert
    //     emailSenderMock.Verify(x => x.SendEmailAsync(It.IsAny<string>()), Times.Once);
    // }

    // ========================================================================
    // Improved Test
    // ========================================================================
    [Test]
    public async Task HandleMessage_ShouldSendEmailWithProcessedMessageBody()
    {
        // Arrange
        var emailSenderMock = new Mock<IEmailSender>();
        var sut = new MessageApplication(emailSenderMock.Object);
        const string messageBodyInput = "some important message";

        // Act
        await sut.HandleMessage(messageBodyInput);

        // Assert
        const string expectedSendEmailCalledWithMessage = "SOME IMPORTANT MESSAGE";
        emailSenderMock.Verify(
            x => x.SendEmailAsync(
                It.Is<string>(message => message == expectedSendEmailCalledWithMessage)
            ),
            Times.Once
        );
    }
}