using PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties;
using PesquisaLixeiraGed.Platform.ErrorDefault;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByPropertiesResult;

public class SearchDocumentResult
{
    public SearchDocumentByPropertiesOut? SearchDocumentByPropertiesOut { get; set; }
    public Error? Error { get; set; }
}
