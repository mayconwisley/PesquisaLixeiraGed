using PesquisaLixeiraGed.Platform.ErrorDefault;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.RestoreDocumentsRemovedResult;

public class RestoreResult
{
    public bool Accepted { get; set; }
    public Error? Error { get; set; }
}
