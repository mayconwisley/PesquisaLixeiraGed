using PesquisaLixeiraGed.Platform.Ecm_Ged.RestoreDocumentsRemoved;
using PesquisaLixeiraGed.Platform.Ecm_Ged.RestoreDocumentsRemovedResult;
using PesquisaLixeiraGed.Platform.ErrorDefault;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Services;

public class EcmGedDocumentRestored
{
    private readonly string _endpoint = "https://platform.senior.com.br/t/senior.com.br/bridge/1.0/rest/platform/ecm_ged/signals/restoreDocumentsRemoved";
    private readonly JsonSerializerOptions _serializerOptions;
    public List<string> ListErros { get; set; } = [];

    public EcmGedDocumentRestored()
    {
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = false,
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
    public async Task<RestoreResult> RestoreDocumentRemoved(RestoreDocumentsRemovedIn restoreDocumentsRemovedIn, string token)
    {
        HttpClient httpClient = new();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        StringContent sc = new(JsonSerializer.Serialize(restoreDocumentsRemovedIn, _serializerOptions), Encoding.UTF8, "application/json");

        using var response = await httpClient.PostAsync(_endpoint, sc);
        if (response.IsSuccessStatusCode)
        {
            return new RestoreResult { Accepted = true };
        }
        else
        {
            var err = await response.Content.ReadAsStringAsync();
            var error = JsonSerializer.Deserialize<Error>(err, _serializerOptions);
            return new RestoreResult { Error = error };
        }
    }
}
