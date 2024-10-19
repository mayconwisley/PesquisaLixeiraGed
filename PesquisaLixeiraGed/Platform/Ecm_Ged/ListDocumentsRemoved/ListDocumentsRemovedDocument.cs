using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemoved;

public class ListDocumentsRemovedDocument
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("parentFolder")]
    public string? ParentFolder { get; set; }
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }
    [JsonPropertyName("deleteBy")]
    public string? DeleteBy { get; set; }
    [JsonPropertyName("lastModifiedDate")]
    public DateTime LastModifiedDate { get; set; }
    [JsonPropertyName("signatureStatus")]
    public string? SignatureStatus { get; set; }
    [JsonPropertyName("mimetype")]
    public string? Mimetype { get; set; }
    [JsonPropertyName("documentStatus")]
    public string? DocumentStatus { get; set; }
    [JsonPropertyName("path")]
    public ListDocumentRemovedPath[]? Path { get; set; }

}
