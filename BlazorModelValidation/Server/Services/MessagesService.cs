using BlazorModelValidation.Shared;
using System.Text.Json;

namespace BlazorModelValidation.Server.Services;

public class MessagesService : IMessagesService
{
    private readonly ILogger<MessagesService> logger;

    public MessagesService(ILogger<MessagesService> logger)
    {
        this.logger = logger;
    }

    public Task SendMessage(Message message)
    {
        logger.LogInformation($"Sending message: {JsonSerializer.Serialize(message)}");
        return Task.CompletedTask;
    }
}
