using PesquisaLixeiraGed.Platform.Authentication.Login;
using PesquisaLixeiraGed.Platform.ErrorDefault;

namespace PesquisaLixeiraGed.Platform.Authentication.LoginResult;

public class Authentication
{
    public LoginOutput? LoginOutput { get; set; }
    public Error? Error { get; set; }
}
