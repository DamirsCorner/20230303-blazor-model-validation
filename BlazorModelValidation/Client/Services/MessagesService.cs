using BlazorModelValidation.Shared;
using System.Net.Http.Json;

namespace BlazorModelValidation.Client.Services;

public class MessagesService : IMessagesService
{
    private readonly HttpClient http;
    private readonly ILogger<MessagesService> logger;

    public MessagesService(HttpClient http, ILogger<MessagesService> logger)
    {
        this.http = http;
        this.logger = logger;
    }

    public async Task SendMessage(Message message)
    {
        var response = await http.PostAsJsonAsync("messages", message);
        if (!response.IsSuccessStatusCode)
        {
            var errorMessage = $"Failed to send message: {await response.Content.ReadAsStringAsync()}";
            logger.LogInformation(errorMessage);
            throw new Exception(errorMessage);
        }

    }
}
