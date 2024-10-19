using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemoved;

public class ListDocumentRemovedIn
{
    [JsonPropertyName("page")]
    public string? Page { get; set; }
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}
