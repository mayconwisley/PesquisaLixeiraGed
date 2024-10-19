namespace PesquisaLixeiraGed
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BtnAcessar = new Button();
            label2 = new Label();
            TxtSenha = new TextBox();
            label1 = new Label();
            TxtEmail = new TextBox();
            GbPesquisa = new GroupBox();
            label4 = new Label();
            NumPageEnd = new NumericUpDown();
            NumPagStart = new NumericUpDown();
            label3 = new Label();
            S = new Button();
            TxtPesquisa = new TextBox();
            groupBox3 = new GroupBox();
            LblInfo = new Label();
            GbInfo = new GroupBox();
            BtnResturar = new Button();
            DgvListTrashFound = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            id = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            parentFolder = new DataGridViewTextBoxColumn();
            kind = new DataGridViewTextBoxColumn();
            createdBy = new DataGridViewTextBoxColumn();
            deleteBy = new DataGridViewTextBoxColumn();
            lastModifiedDate = new DataGridViewTextBoxColumn();
            signatureStatus = new DataGridViewTextBoxColumn();
            mimetype = new DataGridViewTextBoxColumn();
            documentStatus = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            GbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumPageEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumPagStart).BeginInit();
            groupBox3.SuspendLayout();
            GbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListTrashFound).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnAcessar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtSenha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Senior X";
            // 
            // BtnAcessar
            // 
            BtnAcessar.Location = new Point(243, 110);
            BtnAcessar.Name = "BtnAcessar";
            BtnAcessar.Size = new Size(116, 23);
            BtnAcessar.TabIndex = 2;
            BtnAcessar.Text = "Acessar";
            BtnAcessar.UseVisualStyleBackColor = true;
            BtnAcessar.Click += BtnAcessar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(6, 81);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(353, 23);
            TxtSenha.TabIndex = 1;
            TxtSenha.UseSystemPasswordChar = true;
            TxtSenha.KeyDown += TxtSenha_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "E-mail";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(6, 37);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(353, 23);
            TxtEmail.TabIndex = 0;
            // 
            // GbPesquisa
            // 
            GbPesquisa.Controls.Add(label4);
            GbPesquisa.Controls.Add(NumPageEnd);
            GbPesquisa.Controls.Add(NumPagStart);
            GbPesquisa.Controls.Add(label3);
            GbPesquisa.Controls.Add(S);
            GbPesquisa.Controls.Add(TxtPesquisa);
            GbPesquisa.Enabled = false;
            GbPesquisa.Location = new Point(12, 160);
            GbPesquisa.Name = "GbPesquisa";
            GbPesquisa.Size = new Size(989, 59);
            GbPesquisa.TabIndex = 1;
            GbPesquisa.TabStop = false;
            GbPesquisa.Text = "Pesquisa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(746, 24);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 4;
            label4.Text = "a";
            // 
            // NumPageEnd
            // 
            NumPageEnd.Location = new Point(765, 22);
            NumPageEnd.Name = "NumPageEnd";
            NumPageEnd.Size = new Size(69, 23);
            NumPageEnd.TabIndex = 2;
            // 
            // NumPagStart
            // 
            NumPagStart.Location = new Point(671, 22);
            NumPagStart.Name = "NumPagStart";
            NumPagStart.Size = new Size(69, 23);
            NumPagStart.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(617, 25);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Páginas";
            // 
            // S
            // 
            S.Location = new Point(875, 22);
            S.Name = "S";
            S.Size = new Size(108, 23);
            S.TabIndex = 3;
            S.Text = "Pesquisa";
            S.UseVisualStyleBackColor = true;
            S.Click += BtnPesquisa_Click;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(6, 22);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(605, 23);
            TxtPesquisa.TabIndex = 0;
            TxtPesquisa.KeyDown += TxtPesquisa_KeyDown;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LblInfo);
            groupBox3.Location = new Point(383, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(618, 138);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados Lixeira";
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Location = new Point(6, 19);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(16, 15);
            LblInfo.TabIndex = 0;
            LblInfo.Text = "...";
            // 
            // GbInfo
            // 
            GbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GbInfo.Controls.Add(BtnResturar);
            GbInfo.Controls.Add(DgvListTrashFound);
            GbInfo.Enabled = false;
            GbInfo.Location = new Point(12, 225);
            GbInfo.Name = "GbInfo";
            GbInfo.Size = new Size(989, 402);
            GbInfo.TabIndex = 3;
            GbInfo.TabStop = false;
            GbInfo.Text = "Dados Encontrados";
            // 
            // BtnResturar
            // 
            BtnResturar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnResturar.Enabled = false;
            BtnResturar.Location = new Point(6, 358);
            BtnResturar.Name = "BtnResturar";
            BtnResturar.Size = new Size(168, 38);
            BtnResturar.TabIndex = 0;
            BtnResturar.Text = "Restaurar Itens";
            BtnResturar.UseVisualStyleBackColor = true;
            BtnResturar.Click += BtnResturar_Click;
            // 
            // DgvListTrashFound
            // 
            DgvListTrashFound.AllowUserToAddRows = false;
            DgvListTrashFound.AllowUserToDeleteRows = false;
            DgvListTrashFound.AllowUserToOrderColumns = true;
            DgvListTrashFound.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvListTrashFound.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListTrashFound.BackgroundColor = SystemColors.Control;
            DgvListTrashFound.BorderStyle = BorderStyle.Fixed3D;
            DgvListTrashFound.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListTrashFound.Columns.AddRange(new DataGridViewColumn[] { Check, id, title, parentFolder, kind, createdBy, deleteBy, lastModifiedDate, signatureStatus, mimetype, documentStatus });
            DgvListTrashFound.Location = new Point(3, 19);
            DgvListTrashFound.MultiSelect = false;
            DgvListTrashFound.Name = "DgvListTrashFound";
            DgvListTrashFound.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListTrashFound.Size = new Size(983, 333);
            DgvListTrashFound.TabIndex = 1;
            // 
            // Check
            // 
            Check.HeaderText = "seleção";
            Check.Name = "Check";
            Check.Width = 52;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 42;
            // 
            // title
            // 
            title.DataPropertyName = "title";
            title.HeaderText = "title";
            title.Name = "title";
            title.ReadOnly = true;
            title.Width = 52;
            // 
            // parentFolder
            // 
            parentFolder.DataPropertyName = "parentFolder";
            parentFolder.HeaderText = "parentFolder";
            parentFolder.Name = "parentFolder";
            parentFolder.ReadOnly = true;
            parentFolder.Width = 99;
            // 
            // kind
            // 
            kind.DataPropertyName = "kind";
            kind.HeaderText = "kind";
            kind.Name = "kind";
            kind.Width = 55;
            // 
            // createdBy
            // 
            createdBy.DataPropertyName = "createdBy";
            createdBy.HeaderText = "createdBy";
            createdBy.Name = "createdBy";
            createdBy.ReadOnly = true;
            createdBy.Width = 84;
            // 
            // deleteBy
            // 
            deleteBy.DataPropertyName = "deleteBy";
            deleteBy.HeaderText = "deleteBy";
            deleteBy.Name = "deleteBy";
            deleteBy.ReadOnly = true;
            deleteBy.Width = 77;
            // 
            // lastModifiedDate
            // 
            lastModifiedDate.DataPropertyName = "lastModifiedDate";
            lastModifiedDate.HeaderText = "lastModifiedDate";
            lastModifiedDate.Name = "lastModifiedDate";
            lastModifiedDate.ReadOnly = true;
            lastModifiedDate.Width = 122;
            // 
            // signatureStatus
            // 
            signatureStatus.DataPropertyName = "signatureStatus";
            signatureStatus.HeaderText = "signatureStatus";
            signatureStatus.Name = "signatureStatus";
            signatureStatus.ReadOnly = true;
            signatureStatus.Width = 113;
            // 
            // mimetype
            // 
            mimetype.DataPropertyName = "mimetype";
            mimetype.HeaderText = "mimetype";
            mimetype.Name = "mimetype";
            mimetype.ReadOnly = true;
            mimetype.Width = 86;
            // 
            // documentStatus
            // 
            documentStatus.DataPropertyName = "documentStatus";
            documentStatus.HeaderText = "documentStatus";
            documentStatus.Name = "documentStatus";
            documentStatus.ReadOnly = true;
            documentStatus.Width = 119;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 639);
            Controls.Add(GbInfo);
            Controls.Add(groupBox3);
            Controls.Add(GbPesquisa);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar na Lixeira Senior X - Feito por: Maycon Wisley";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GbPesquisa.ResumeLayout(false);
            GbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumPageEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumPagStart).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            GbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListTrashFound).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnAcessar;
        private Label label2;
        private TextBox TxtSenha;
        private Label label1;
        private TextBox TxtEmail;
        private GroupBox GbPesquisa;
        private TextBox TxtPesquisa;
        private GroupBox groupBox3;
        private Button S;
        private GroupBox GbInfo;
        private DataGridView DgvListTrashFound;
        private Label label3;
        private Label label4;
        private NumericUpDown NumPageEnd;
        private NumericUpDown NumPagStart;
        private Label LblInfo;
        private Button BtnResturar;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn parentFolder;
        private DataGridViewTextBoxColumn kind;
        private DataGridViewTextBoxColumn createdBy;
        private DataGridViewTextBoxColumn deleteBy;
        private DataGridViewTextBoxColumn lastModifiedDate;
        private DataGridViewTextBoxColumn signatureStatus;
        private DataGridViewTextBoxColumn mimetype;
        private DataGridViewTextBoxColumn documentStatus;
    }
}
