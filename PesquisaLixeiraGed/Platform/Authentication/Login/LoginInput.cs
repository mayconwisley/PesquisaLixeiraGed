using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Authentication.Login;

public class LoginInput
{
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    [JsonPropertyName("password")]
    public string? Password { get; set; }
    [JsonPropertyName("code")]
    public string? Code { get; set; }
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
    [JsonPropertyName("recaptcha")]
    public string? Recaptcha { get; set; }
}
