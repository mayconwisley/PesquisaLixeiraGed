using PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemoved;
using PesquisaLixeiraGed.Platform.ErrorDefault;

namespace PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemovedResult;

public class ListResult
{
    public ListDocumentsRemovedOut? ListDocumentsRemovedOut { get; set; }
    public Error? Error { get; set; }
}
