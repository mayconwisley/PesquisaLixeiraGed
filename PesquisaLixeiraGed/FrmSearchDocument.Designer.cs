namespace PesquisaLixeiraGed
{
    partial class FrmSearchDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CbxListFolder = new ComboBox();
            groupBox1 = new GroupBox();
            BtnRestaured = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CbxListFolder
            // 
            CbxListFolder.DisplayMember = "Title";
            CbxListFolder.FormattingEnabled = true;
            CbxListFolder.Location = new Point(6, 22);
            CbxListFolder.Name = "CbxListFolder";
            CbxListFolder.Size = new Size(439, 23);
            CbxListFolder.TabIndex = 0;
            CbxListFolder.ValueMember = "Id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbxListFolder);
            groupBox1.Location = new Point(13, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pastas";
            // 
            // BtnRestaured
            // 
            BtnRestaured.Location = new Point(470, 25);
            BtnRestaured.Name = "BtnRestaured";
            BtnRestaured.Size = new Size(139, 45);
            BtnRestaured.TabIndex = 2;
            BtnRestaured.Text = "Restaurar";
            BtnRestaured.UseVisualStyleBackColor = true;
            BtnRestaured.Click += BtnRestaured_Click;
            // 
            // FrmSearchDocument
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 91);
            Controls.Add(BtnRestaured);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSearchDocument";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Document - Folder";
            Load += FrmSearchDocument_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CbxListFolder;
        private GroupBox groupBox1;
        private Button BtnRestaured;
    }
}