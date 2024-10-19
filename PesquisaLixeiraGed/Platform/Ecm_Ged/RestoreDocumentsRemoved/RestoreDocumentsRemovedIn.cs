using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.RestoreDocumentsRemoved;

public class RestoreDocumentsRemovedIn
{
    [JsonPropertyName("documents")]
    public List<string>? Documents { get; set; }
    [JsonPropertyName("folderId")]
    public string? FolderId { get; set; }

}
