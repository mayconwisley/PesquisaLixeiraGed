using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties;

public class SearchDocumentByPropertiesPath
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
    [JsonPropertyName("inheritedPermission")]
    public bool? InheritedPermission { get; set; }
    [JsonPropertyName("localPermissionLevel")]
    public int? LocalPermissionLevel { get; set; }
    [JsonPropertyName("inheritedPermissionLevel")]
    public int? InheritedPermissionLevel { get; set; }
    [JsonPropertyName("inheritedPermissionFrom")]
    public string? InheritedPermissionFrom { get; set; }
    [JsonPropertyName("isDeleting")]
    public bool? IsDeleting { get; set; }
}
