using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Authentication.Login;

public class LoginMfaInfo
{
    [JsonPropertyName("temporaryToken")]
    public string? TemporaryToken { get; set; }
    [JsonPropertyName("mfaStatus")]
    public string? MfaStatus { get; set; }
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}
