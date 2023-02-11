namespace BlazorModelValidation.Shared;

public interface IMessagesService
{
    Task SendMessage(Message message);
}
