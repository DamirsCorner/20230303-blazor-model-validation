using System.ComponentModel.DataAnnotations;

namespace BlazorModelValidation.Shared;

public class Message
{
    [Required(AllowEmptyStrings = false)]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false)]
    [MaxLength(100)]
    public string Subject { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false)]
    public string Body { get; set; } = string.Empty;
}
