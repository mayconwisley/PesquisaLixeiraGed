using PesquisaLixeiraGed.Platform.ErrorDefault.Enum;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.ErrorDefault;

public class Error
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }
    [JsonPropertyName("reason")]
    public ReasonEnum? Reason { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    [JsonPropertyName("service")]
    public string? Service { get; set; }


}
