using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Authentication.Login;

public class LoginOutput
{
    [JsonPropertyName("jsonToken")]
    public string? JsonToken { get; set; }
    [JsonPropertyName("mfaInfo")]
    public LoginMfaInfo? MfaInfo { get; set; }
    [JsonPropertyName("resetPasswordInfo")]
    public LoginResetPasswordInfo? ResetPasswordInfo { get; set; }
}
