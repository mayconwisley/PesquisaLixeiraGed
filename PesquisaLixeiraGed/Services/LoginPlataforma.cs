using PesquisaLixeiraGed.Platform.Authentication.Login;
using PesquisaLixeiraGed.Platform.Authentication.LoginResult;
using PesquisaLixeiraGed.Platform.ErrorDefault;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed.Services;

public class LoginPlataforma
{
    private readonly string _endpoint = "https://platform.senior.com.br/t/senior.com.br/bridge/1.0/rest/platform/authentication/actions/login";
    private readonly JsonSerializerOptions _serializerOptions;

    public LoginPlataforma()
    {
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull

        };
    }

    public async Task<Authentication> Login(string username, string password)
    {
        HttpClient httpClient = new();

        LoginInput login = new()
        {
            Password = password,
            Username = username
        };

        StringContent sc = new(JsonSerializer.Serialize(login, _serializerOptions), Encoding.UTF8, "application/json");
        using (var response = await httpClient.PostAsync(_endpoint, sc))
        {
            if (response.IsSuccessStatusCode)
            {
                using Stream stream = await response.Content.ReadAsStreamAsync();
                var loginOutput = await JsonSerializer.DeserializeAsync<LoginOutput>(stream, _serializerOptions);
                if (loginOutput is not null)
                {
                    return new Authentication { LoginOutput = loginOutput };
                }
            }
            else
            {
                var err = await response.Content.ReadAsStringAsync();
                var error = JsonSerializer.Deserialize<Error>(err, _serializerOptions);
                return new Authentication { Error = error };
            }
        }
        return new Authentication { Error = new Error { Message = "Erro desconhecido" } };
    }
}
