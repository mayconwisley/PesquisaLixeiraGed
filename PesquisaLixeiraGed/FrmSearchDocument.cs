using PesquisaLixeiraGed.Platform.Authentication.Login;
using PesquisaLixeiraGed.Platform.Ecm_Ged.RestoreDocumentsRemoved;
using PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties;
using PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties.Enum;
using PesquisaLixeiraGed.Platform.ErrorDefault;
using PesquisaLixeiraGed.Services;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed;

public partial class FrmSearchDocument : Form
{
    private readonly JsonSerializerOptions _serializerOptions;
    LoginJsonToken _loginJsonToken = new();
    RestoreDocumentsRemovedIn _restoreDocumentsRemovedIn;

    public FrmSearchDocument(LoginJsonToken loginJsonToken, RestoreDocumentsRemovedIn restoreDocumentsRemovedIn)
    {
        InitializeComponent();
        _loginJsonToken = loginJsonToken;
        _restoreDocumentsRemovedIn = restoreDocumentsRemovedIn;
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = false,
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
    private static void HandleError(Error? error)
    {
        string message = $"Código: {error?.ErrorCode}\n" +
                         $"Mensagem: {error?.Message}\n" +
                         $"Razão: {error?.Reason}\n" +
                         $"Dominio: {error?.Domain}\n" +
                         $"Serviço: {error?.Service}";

        throw new Exception(message);
    }

    private async Task SearchDocument()
    {
        try
        {
            EcmGedSearchDocumentByProperties ecmGedSearchDocument = new();
            List<SearchDocumentByPropertiesResult> searchDocumentByPropertiesResult = [];

            SearchDocumentByPropertiesIn searchDocumentByPropertiesIn = new()
            {
                FilterType = FilterTypeEnum.ALL,
                IncludeSubfolders = true
            };

            var searchDocumentByProperties = await ecmGedSearchDocument.SearchResultAsync(searchDocumentByPropertiesIn, _loginJsonToken.Access_token!);
            if (searchDocumentByProperties.Error is not null)
            {
                HandleError(searchDocumentByProperties.Error);
            }
            else if (searchDocumentByProperties.SearchDocumentByPropertiesOut is not null)
            {
                foreach (var item in searchDocumentByProperties.SearchDocumentByPropertiesOut.SearchResult!)
                {
                    if (item.Kind == FilterTypeEnum.FOLDER)
                    {
                        searchDocumentByPropertiesResult.Add(new SearchDocumentByPropertiesResult { Id = item.Id, Title = item.Title });
                    }

                }

                CbxListFolder.DataSource = searchDocumentByPropertiesResult;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private async Task RestoreDocumentTrash()
    {
        List<string> documentsRestored = [];
        EcmGedDocumentRestored ecmGedDocumentRestored = new();
        _restoreDocumentsRemovedIn = new()
        {
            FolderId = CbxListFolder.SelectedValue!.ToString()
        };

        var restored = await ecmGedDocumentRestored.RestoreDocumentRemoved(_restoreDocumentsRemovedIn, _loginJsonToken.Access_token!);

        if (restored.Error is not null)
        {
            HandleError(restored.Error);
        }
        else if (restored.Accepted)
        {
            documentsRestored.Add($"Documento Restaurado");
        }
        else
        {
            documentsRestored.Add($"Documento Não Restaurado");
        }
    }
    private async void FrmSearchDocument_Load(object sender, EventArgs e)
    {
        await SearchDocument();
    }

    private async void BtnRestaured_Click(object sender, EventArgs e)
    {
        await RestoreDocumentTrash();
    }
}
