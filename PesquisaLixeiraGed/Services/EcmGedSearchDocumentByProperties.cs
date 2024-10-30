using PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByProperties;
using PesquisaLixeiraGed.Platform.Ecm_Ged.SearchDocumentByPropertiesResult;
using PesquisaLixeiraGed.Platform.ErrorDefault;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Services;

public class EcmGedSearchDocumentByProperties
{
    private readonly string _endpoint = "https://platform.senior.com.br/t/senior.com.br/bridge/1.0/rest/platform/ecm_ged/queries/searchDocumentByProperties";
    private readonly JsonSerializerOptions _serializerOptions;

    public EcmGedSearchDocumentByProperties()
    {
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = false,
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }

    public async Task<SearchDocumentResult> SearchResultAsync(SearchDocumentByPropertiesIn searchDocumentByPropertiesIn, string token)
    {
        HttpClient httpClient = new();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        StringContent sc = new(JsonSerializer.Serialize(searchDocumentByPropertiesIn, _serializerOptions), Encoding.UTF8, "application/json");

        using var response = await httpClient.PostAsync(_endpoint, sc);
        if (response.IsSuccessStatusCode)
        {
            using Stream stream = await response.Content.ReadAsStreamAsync();
            var searchDocumentByPropertiesOut = await JsonSerializer.DeserializeAsync<SearchDocumentByPropertiesOut>(stream, _serializerOptions);
            if (searchDocumentByPropertiesOut is not null)
            {
                return new SearchDocumentResult { SearchDocumentByPropertiesOut = searchDocumentByPropertiesOut };
            }
        }
        else
        {
            var err = await response.Content.ReadAsStringAsync();
            var error = JsonSerializer.Deserialize<Error>(err, _serializerOptions);
            return new SearchDocumentResult { Error = error };
        }
        return new SearchDocumentResult { Error = new Error { Message = "Erro desconhecido" } };
    }
}
