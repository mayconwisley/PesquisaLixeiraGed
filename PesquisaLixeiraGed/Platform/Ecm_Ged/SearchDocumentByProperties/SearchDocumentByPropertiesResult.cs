using PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties.Enum;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties;

public class SearchDocumentByPropertiesResult
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("kind")]
    public FilterTypeEnum? Kind { get; set; }
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }
    [JsonPropertyName("author")]
    public string? Author { get; set; }
    [JsonPropertyName("lastModifiedDate")]
    public string? LastModifiedDate { get; set; }
    [JsonPropertyName("canEdit")]
    public bool? CanEdit { get; set; }
    [JsonPropertyName("canDownload")]
    public bool? CanDownload { get; set; }
    [JsonPropertyName("signatureStatus")]
    public SignatureStatusEnum? SignatureStatus { get; set; }
    [JsonPropertyName("mimetype")]
    public string? Mimetype { get; set; }
    [JsonPropertyName("documentStatus")]
    public DocumentStatusEnum? DocumentStatus { get; set; }
    [JsonPropertyName("path")]
    public SearchDocumentByPropertiesPath[]? Path { get; set; }
    [JsonPropertyName("inheritedPermission")]
    public bool? InheritedPermission { get; set; }
}
