using BlazorModelValidation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorModelValidation.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class MessagesController : ControllerBase
{
    private readonly IMessagesService messageService;

    public MessagesController(IMessagesService messageService)
    {
        this.messageService = messageService;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Message message)
    {
        await messageService.SendMessage(message);
        return Ok();
    }
}
