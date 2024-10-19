using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemoved;

public class ListDocumentsRemovedOut
{
    [JsonPropertyName("documents")]
    public ListDocumentsRemovedDocument[]? Documents { get; set; }
    [JsonPropertyName("totalDocuments")]
    public int TotalDocuments { get; set; }
    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }

}
