using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Authentication.Login;

public class LoginJsonToken
{
    [JsonPropertyName("version")]
    public int? Version { get; set; }
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
    [JsonPropertyName("expires_in")]
    public int? Expires_in { get; set; }
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    [JsonPropertyName("token_type")]
    public string? Token_type { get; set; }
    [JsonPropertyName("access_token")]
    public string? Access_token { get; set; }
    [JsonPropertyName("refresh_token")]
    public string? Refresh_token { get; set; }
}
