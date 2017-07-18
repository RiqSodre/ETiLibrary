namespace Interface.Formularios.Cadastros
{
    partial class FrmCadFuncionarioBiblioteca
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
            this.lblCelular = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lblTelefone = new MetroFramework.Controls.MetroLabel();
            this.lblCargo = new MetroFramework.Controls.MetroLabel();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new MetroFramework.Controls.MetroLabel();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblSexo = new MetroFramework.Controls.MetroLabel();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lblDadosP = new MetroFramework.Controls.MetroLabel();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblLogin = new MetroFramework.Controls.MetroLabel();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.checkMSenha = new System.Windows.Forms.CheckBox();
            this.lblMSenha = new MetroFramework.Controls.MetroLabel();
            this.lblAdmin = new MetroFramework.Controls.MetroLabel();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Margin = new System.Windows.Forms.Padding(2);
            this.pnl.Size = new System.Drawing.Size(422, 26);
            this.pnl.TabIndex = 3;
            // 
            // lblForm
            // 
            this.lblForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForm.Size = new System.Drawing.Size(202, 16);
            this.lblForm.Text = "Cadastro: Funcionário Biblioteca";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Location = new System.Drawing.Point(394, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.TabIndex = 0;
            // 
            // pnlBase
            // 
            this.pnlBase.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBase.Size = new System.Drawing.Size(417, 35);
            this.pnlBase.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(256, -3);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(164, -3);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(73, -3);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(328, 348);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(236, 348);
            this.btnAcao.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Text = "&Salvar";
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblAdmin);
            this.pnlPrincipal.Controls.Add(this.checkAdmin);
            this.pnlPrincipal.Controls.Add(this.lblMSenha);
            this.pnlPrincipal.Controls.Add(this.checkMSenha);
            this.pnlPrincipal.Controls.Add(this.lblSenha);
            this.pnlPrincipal.Controls.Add(this.txtSenha);
            this.pnlPrincipal.Controls.Add(this.lblLogin);
            this.pnlPrincipal.Controls.Add(this.txtLogin);
            this.pnlPrincipal.Controls.Add(this.metroLabel2);
            this.pnlPrincipal.Controls.Add(this.txtEmail);
            this.pnlPrincipal.Controls.Add(this.lblEmail);
            this.pnlPrincipal.Controls.Add(this.metroLabel1);
            this.pnlPrincipal.Controls.Add(this.lblCelular);
            this.pnlPrincipal.Controls.Add(this.txtNome);
            this.pnlPrincipal.Controls.Add(this.lblTelefone);
            this.pnlPrincipal.Controls.Add(this.lblCargo);
            this.pnlPrincipal.Controls.Add(this.txtCelular);
            this.pnlPrincipal.Controls.Add(this.txtTelefone);
            this.pnlPrincipal.Controls.Add(this.lblCPF);
            this.pnlPrincipal.Controls.Add(this.txtCpf);
            this.pnlPrincipal.Controls.Add(this.lblSexo);
            this.pnlPrincipal.Controls.Add(this.cbCargo);
            this.pnlPrincipal.Controls.Add(this.lblDadosP);
            this.pnlPrincipal.Controls.Add(this.cbSexo);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Size = new System.Drawing.Size(408, 271);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(13, 202);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 19);
            this.lblCelular.TabIndex = 35;
            this.lblCelular.Text = "Celular:";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(74, 37);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(148, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 169);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 19);
            this.lblTelefone.TabIndex = 34;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(13, 104);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 19);
            this.lblCargo.TabIndex = 33;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtCelular
            // 
            this.txtCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtCelular.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txtCelular.Location = new System.Drawing.Point(74, 202);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 23);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtTelefone
            // 
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtTelefone.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txtTelefone.Location = new System.Drawing.Point(74, 169);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 136);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(36, 19);
            this.lblCPF.TabIndex = 32;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtCpf.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txtCpf.Location = new System.Drawing.Point(74, 136);
            this.txtCpf.Mask = "000\\.000\\.000\\-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 23);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(13, 72);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 19);
            this.lblSexo.TabIndex = 31;
            this.lblSexo.Text = "Sexo:";
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.Enabled = false;
            this.cbCargo.Font = new System.Drawing.Font("Calibri", 8.68F);
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(74, 104);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(148, 22);
            this.cbCargo.TabIndex = 2;
            this.cbCargo.TabStop = false;
            // 
            // lblDadosP
            // 
            this.lblDadosP.AutoSize = true;
            this.lblDadosP.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDadosP.Location = new System.Drawing.Point(13, 11);
            this.lblDadosP.Name = "lblDadosP";
            this.lblDadosP.Size = new System.Drawing.Size(111, 19);
            this.lblDadosP.TabIndex = 30;
            this.lblDadosP.Text = "Dados Pessoais";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(74, 72);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(85, 23);
            this.cbSexo.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 19);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(74, 232);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(191, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(231, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Dados do Sistema";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(231, 39);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 19);
            this.lblLogin.TabIndex = 42;
            this.lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = null;
            this.txtLogin.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogin.CustomButton.TabIndex = 1;
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = false;
            this.txtLogin.Lines = new string[0];
            this.txtLogin.Location = new System.Drawing.Point(287, 37);
            this.txtLogin.MaxLength = 12;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(108, 23);
            this.txtLogin.TabIndex = 7;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(231, 74);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 19);
            this.lblSenha.TabIndex = 44;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(287, 72);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(108, 23);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // checkMSenha
            // 
            this.checkMSenha.AutoSize = true;
            this.checkMSenha.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMSenha.Location = new System.Drawing.Point(287, 99);
            this.checkMSenha.Margin = new System.Windows.Forms.Padding(2);
            this.checkMSenha.Name = "checkMSenha";
            this.checkMSenha.Size = new System.Drawing.Size(15, 14);
            this.checkMSenha.TabIndex = 9;
            this.checkMSenha.TabStop = false;
            this.checkMSenha.UseVisualStyleBackColor = true;
            this.checkMSenha.CheckedChanged += new System.EventHandler(this.checkMSenha_CheckedChanged);
            // 
            // lblMSenha
            // 
            this.lblMSenha.AutoSize = true;
            this.lblMSenha.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMSenha.Location = new System.Drawing.Point(306, 99);
            this.lblMSenha.Name = "lblMSenha";
            this.lblMSenha.Size = new System.Drawing.Size(80, 15);
            this.lblMSenha.TabIndex = 207;
            this.lblMSenha.Text = "Mostrar Senha";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAdmin.Location = new System.Drawing.Point(306, 120);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(79, 15);
            this.lblAdmin.TabIndex = 209;
            this.lblAdmin.Text = "Administrador";
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAdmin.Location = new System.Drawing.Point(287, 120);
            this.checkAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(15, 14);
            this.checkAdmin.TabIndex = 10;
            this.checkAdmin.TabStop = false;
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // FrmCadFuncionarioBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 394);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadFuncionarioBiblioteca";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "FrmCadFuncionarioBiblioteca";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCelular;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel lblTelefone;
        private MetroFramework.Controls.MetroLabel lblCargo;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private MetroFramework.Controls.MetroLabel lblCPF;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private MetroFramework.Controls.MetroLabel lblSexo;
        public System.Windows.Forms.ComboBox cbCargo;
        private MetroFramework.Controls.MetroLabel lblDadosP;
        public System.Windows.Forms.ComboBox cbSexo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel lblLogin;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.CheckBox checkMSenha;
        private MetroFramework.Controls.MetroLabel lblMSenha;
        private MetroFramework.Controls.MetroLabel lblAdmin;
        private System.Windows.Forms.CheckBox checkAdmin;
    }
}