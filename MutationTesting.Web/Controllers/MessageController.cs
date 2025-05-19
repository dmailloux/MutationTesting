using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MutationTesting.Application.Interfaces;

namespace MutationTesting.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly IMessageApplication _messageApplication;

    public MessageController(IMessageApplication messageApplication)
    {
        _messageApplication = messageApplication;
    }

    [HttpPost]
    public async Task<IActionResult> Index([FromBody] string message)
    {
        await _messageApplication.HandleMessage(message);
        return Ok(message);
    }
}