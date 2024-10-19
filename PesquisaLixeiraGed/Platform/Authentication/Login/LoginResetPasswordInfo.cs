using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Authentication.Login;

public class LoginResetPasswordInfo
{
    [JsonPropertyName("temporaryToken")]
    public string? TemporaryToken { get; set; }
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
    [JsonPropertyName("expiredPassword")]
    public bool? ExpiredPassword { get; set; }
    [JsonPropertyName("passwordExpiryAt")]
    public DateTime? PasswordExpiryAt { get; set; }
}
