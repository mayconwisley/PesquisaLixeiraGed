using PesquisaLixeiraGed.Platform.Authentication.Login;
using PesquisaLixeiraGed.Platform.Ecm_Ged.ListDocumentsRemoved;
using PesquisaLixeiraGed.Platform.Ecm_Ged.RestoreDocumentsRemoved;
using PesquisaLixeiraGed.Platform.ErrorDefault;
using PesquisaLixeiraGed.Services;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PesquisaLixeiraGed;

public partial class FrmMain : Form
{
    private readonly JsonSerializerOptions _serializerOptions;
    public FrmMain()
    {
        InitializeComponent();

        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = false,
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }

    LoginJsonToken jsonToken = new();

    private void HandleError(Error? error)
    {
        string message = $"Código: {error?.ErrorCode}\n" +
                         $"Mensagem: {error?.Message}\n" +
                         $"Razão: {error?.Reason}\n" +
                         $"Dominio: {error?.Domain}\n" +
                         $"Serviço: {error?.Service}";

        throw new Exception(message);
    }
    private async Task<LoginJsonToken> LoginSeniorX(string username, string password)
    {
        LoginPlataforma loginPlataforma = new();

        var loginOutput = await loginPlataforma.Login(username, password);

        if (loginOutput.Error is not null)
        {
            HandleError(loginOutput.Error);
        }
        else if (loginOutput.LoginOutput is not null)
        {
            var loginJsonToken = JsonSerializer.Deserialize<LoginJsonToken>(loginOutput.LoginOutput.JsonToken!, _serializerOptions);

            if (loginJsonToken is not null)
            {
                return loginJsonToken;
            }
        }
        else
        {
            HandleError(loginOutput.Error);
        }

        return new();
    }
    private async Task ReturnDataTrash(LoginJsonToken loginJsonToken)
    {

        EcmGedDocumentRemoved ecmGedDocumentRemoved = new();

        ListDocumentRemovedIn listDocumentRemovedIn = new()
        {
            Page = "0",
            Size = "50"
        };

        var trash = await ecmGedDocumentRemoved.ListDocumentRemoved(listDocumentRemovedIn, loginJsonToken.Access_token!);
        if (trash.Error is not null)
        {
            HandleError(trash.Error);

        }
        else if (trash.ListDocumentsRemovedOut is not null)
        {
            LblInfo.Text = $"Total Itens: {trash.ListDocumentsRemovedOut?.TotalDocuments}\n" +
                           $"Total Páginas: {trash.ListDocumentsRemovedOut?.TotalPages}";
            NumPageEnd.Value = trash.ListDocumentsRemovedOut!.TotalPages;
        }
        else
        {
            HandleError(trash.Error);
        }

    }
    private async Task SearchTrash(string search, LoginJsonToken loginJsonToken)
    {
        this.Text = "Pesquisar na Lixeira Senior X - Feito por: Maycon Wisley - PESQUISANDO... AGUARDE";
        S.Enabled = false;
        TxtPesquisa.Enabled = false;
        NumPagStart.Enabled = false;
        NumPageEnd.Enabled = false;
        BtnResturar.Enabled = false;

        EcmGedDocumentRemoved ecmGedDocumentRemoved = new();
        var pageStart = int.Parse(NumPagStart.Value.ToString());
        var pageEnd = int.Parse(NumPageEnd.Value.ToString());
        ListDocumentRemovedIn listDocumentRemovedIn = new()
        {
            Size = "50"
        };

        if (!string.IsNullOrEmpty(loginJsonToken.Access_token))
        {
            List<ListDocumentsRemovedDocument> allDocumentsFound = [];

            for (int page = pageStart; page <= pageEnd; page++)
            {
                listDocumentRemovedIn.Page = page.ToString();
                var listDocument = await ecmGedDocumentRemoved.ListDocumentRemoved(listDocumentRemovedIn, loginJsonToken.Access_token);

                if (listDocument.Error is not null)
                {

                    HandleError(listDocument.Error);
                }
                else if (listDocument.ListDocumentsRemovedOut is not null)
                {
                    var documentFound = listDocument.ListDocumentsRemovedOut.Documents?.Where(w => (w.Id?.ToUpper().Contains(search.ToUpper()) ?? false) ||
                                                  (w.Title?.ToUpper().Contains(search.ToUpper()) ?? false) ||
                                                  (w.ParentFolder?.ToUpper().Contains(search.ToUpper()) ?? false) ||
                                                  (w.Kind?.ToUpper().Contains(search.ToUpper()) ?? false) ||
                                                  (w.CreatedBy?.ToUpper().Contains(search.ToUpper()) ?? false) ||
                                                  (w.DeleteBy?.ToUpper().Contains(search.ToUpper()) ?? false) ||
                                                  (w.LastModifiedDate.ToString().ToUpper().Contains(search.ToUpper())) ||
                                                  (w.Mimetype?.ToUpper().Contains(search.ToUpper()) ?? false) ||
                                                  (w.DocumentStatus?.ToUpper().Contains(search.ToUpper()) ?? false))
                                        .ToList();
                    if (documentFound is not null && documentFound.Any())
                    {
                        allDocumentsFound.AddRange(documentFound);
                    }
                }
                else
                {
                    HandleError(listDocument.Error);
                }
            }
            DgvListTrashFound.DataSource = allDocumentsFound.Any() ? allDocumentsFound : new List<ListDocumentsRemovedDocument>();
            GbInfo.Text = $"Dados Encontrados({DgvListTrashFound.RowCount:00})";
        }

        this.Text = "Pesquisar na Lixeira Senior X - Feito por: Maycon Wisley";
        S.Enabled = true;
        TxtPesquisa.Enabled = true;
        NumPagStart.Enabled = true;
        NumPageEnd.Enabled = true;
        BtnResturar.Enabled = true;
    }
    private async Task<bool> RestoreDocumentTrash(LoginJsonToken loginJsonToken)
    {

        EcmGedDocumentRemoved ecmGedDocumentRemoved = new();
        List<string> document = [];
        foreach (DataGridViewRow row in DgvListTrashFound.Rows)
        {
            var check = row.Cells["Check"].Value;
            if (check is not null)
            {
                document.Add(row.Cells["id"].Value.ToString()!);
            }

            RestoreDocumentsRemovedIn restoreDocumentsRemovedIn = new()
            {
                Documents = document,
                FolderId = row.Cells["parentFolder"].Value.ToString()

            };
            var restored = await ecmGedDocumentRemoved.RestoreDocumentRemoved(restoreDocumentsRemovedIn, loginJsonToken.Access_token!);

            if (restored.Error is not null)
            {
                HandleError(restored.Error);
            }
            else
            {
                return restored.Accepted;
            }
        }
        return false;
    }
    private async void BtnAcessar_Click(object sender, EventArgs e)
    {
        try
        {
            jsonToken = await LoginSeniorX(TxtEmail.Text.Trim(), TxtSenha.Text.Trim());
            if (!string.IsNullOrEmpty(jsonToken.Access_token))
            {
                await ReturnDataTrash(jsonToken);
                GbPesquisa.Enabled = true;
                GbInfo.Enabled = true;
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, this.Text);
        }
    }
    private async void BtnPesquisa_Click(object sender, EventArgs e)
    {
        try
        {
            await SearchTrash(TxtPesquisa.Text, jsonToken);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, this.Text);
        }
    }
    private async void BtnResturar_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(jsonToken.Access_token))
            {
                var isRestaured = await RestoreDocumentTrash(jsonToken);

                if (isRestaured)
                {
                    MessageBox.Show("Itens Restaurados", this.Text);
                }
                await SearchTrash(TxtPesquisa.Text.Trim(), jsonToken);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, this.Text);
        }
    }
    private async void TxtPesquisa_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {

            if (!string.IsNullOrEmpty(jsonToken.Access_token))
            {
                await SearchTrash(TxtPesquisa.Text.Trim(), jsonToken);
            }
        }
    }
    private async void TxtSenha_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            jsonToken = await LoginSeniorX(TxtEmail.Text.Trim(), TxtSenha.Text.Trim());
            if (!string.IsNullOrEmpty(jsonToken.Access_token))
            {
                await ReturnDataTrash(jsonToken);
                GbPesquisa.Enabled = true;
                GbInfo.Enabled = true;
            }
        }
    }
}
