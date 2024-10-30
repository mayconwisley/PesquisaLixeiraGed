using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties;

public class SearchDocumentByPropertiesOut
{
    [JsonPropertyName("totalElements")]
    public int? TotalElements { get; set; }
    [JsonPropertyName("totalPages")]
    public int? TotalPages { get; set; }
    [JsonPropertyName("searchResult")]
    public SearchDocumentByPropertiesResult[]? SearchResult { get; set; }
}
