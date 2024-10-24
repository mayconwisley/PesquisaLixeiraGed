using PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemoved;
using PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemovedResult;
using PesquisaLixeiraGed.Platform.ErrorDefault;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Services;

public class EcmGedDocumentRemoved
{
    private readonly string _endpoint = "https://platform.senior.com.br/t/senior.com.br/bridge/1.0/rest/platform/ecm_ged/queries/listDocumentsRemoved";
    private readonly JsonSerializerOptions _serializerOptions;

    public EcmGedDocumentRemoved()
    {
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = false,
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }

    public async Task<ListResult> ListDocumentRemoved(ListDocumentRemovedIn listDocumentRemovedIn, string token)
    {
        HttpClient httpClient = new();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        StringContent sc = new(JsonSerializer.Serialize(listDocumentRemovedIn, _serializerOptions), Encoding.UTF8, "application/json");

        using var response = await httpClient.PostAsync(_endpoint, sc);
        if (response.IsSuccessStatusCode)
        {
            using Stream strem = await response.Content.ReadAsStreamAsync();
            var documentsRemovedOut = await JsonSerializer.DeserializeAsync<ListDocumentsRemovedOut>(strem);

            if (documentsRemovedOut is not null)
            {
                return new ListResult { ListDocumentsRemovedOut = documentsRemovedOut };
            }
        }
        else
        {
            var err = await response.Content.ReadAsStringAsync();
            var error = JsonSerializer.Deserialize<Error>(err, _serializerOptions);
            return new ListResult { Error = error };
        }

        return new ListResult { Error = new Error { Message = "Erro desconhecido" } };
    }
}
