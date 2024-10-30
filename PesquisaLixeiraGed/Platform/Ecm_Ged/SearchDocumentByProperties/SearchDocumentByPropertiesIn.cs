using PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties.Enum;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties;

public class SearchDocumentByPropertiesIn
{
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }
    [JsonPropertyName("size")]
    public int? Size { get; set; }
    [JsonPropertyName("filterType")]
    public FilterTypeEnum? FilterType { get; set; }
    [JsonPropertyName("documentName")]
    public string? DocumentName { get; set; }
    [JsonPropertyName("authorName")]
    public string? AuthorName { get; set; }
    [JsonPropertyName("signatureStatus")]
    public SignatureStatusEnum? SignatureStatus { get; set; }
    [JsonPropertyName("initialDate")]
    public string? InitialDate { get; set; }
    [JsonPropertyName("finalDate")]
    public string? FinalDate { get; set; }
    [JsonPropertyName("expInitialDate")]
    public string? ExpInitialDate { get; set; }
    [JsonPropertyName("expFinalDate")]
    public string? ExpFinalDate { get; set; }
    [JsonPropertyName("obsInitialDate")]
    public string? ObsInitialDate { get; set; }
    [JsonPropertyName("obsFinalDate")]
    public string? ObsFinalDate { get; set; }
    [JsonPropertyName("fileType")]
    public FileTypeEnum? FileType { get; set; }
    [JsonPropertyName("folderId")]
    public string? FolderId { get; set; }
    [JsonPropertyName("includeSubfolders")]
    public bool? IncludeSubfolders { get; set; }
}
