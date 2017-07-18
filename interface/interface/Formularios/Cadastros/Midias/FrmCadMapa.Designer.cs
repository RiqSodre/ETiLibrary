namespace Interface.Formularios.Cadastros
{
    partial class FrmCadMapa
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
            this.lblTombo = new MetroFramework.Controls.MetroLabel();
            this.txtTombo = new MetroFramework.Controls.MetroTextBox();
            this.checkDisponivel = new System.Windows.Forms.CheckBox();
            this.lblDisponivel = new MetroFramework.Controls.MetroLabel();
            this.cbTipoTombo = new System.Windows.Forms.ComboBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObs = new MetroFramework.Controls.MetroLabel();
            this.lblTipoTombo = new MetroFramework.Controls.MetroLabel();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.lblLocalizacao = new MetroFramework.Controls.MetroLabel();
            this.txtLocalizacao = new MetroFramework.Controls.MetroTextBox();
            this.lblEspecifica = new MetroFramework.Controls.MetroLabel();
            this.txtEspecifica = new MetroFramework.Controls.MetroTextBox();
            this.lblArea = new MetroFramework.Controls.MetroLabel();
            this.cbLingua = new System.Windows.Forms.ComboBox();
            this.lblLingua = new MetroFramework.Controls.MetroLabel();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.TabIndex = 3;
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(104, 16);
            this.lblForm.Text = "Cadastro: Mapa";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.TabIndex = 0;
            // 
            // pnlBase
            // 
            this.pnlBase.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 355);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(149, 355);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblTombo);
            this.pnlPrincipal.Controls.Add(this.txtTombo);
            this.pnlPrincipal.Controls.Add(this.checkDisponivel);
            this.pnlPrincipal.Controls.Add(this.lblDisponivel);
            this.pnlPrincipal.Controls.Add(this.cbTipoTombo);
            this.pnlPrincipal.Controls.Add(this.txtObservacao);
            this.pnlPrincipal.Controls.Add(this.lblObs);
            this.pnlPrincipal.Controls.Add(this.lblTipoTombo);
            this.pnlPrincipal.Controls.Add(this.cbArea);
            this.pnlPrincipal.Controls.Add(this.lblLocalizacao);
            this.pnlPrincipal.Controls.Add(this.txtLocalizacao);
            this.pnlPrincipal.Controls.Add(this.lblEspecifica);
            this.pnlPrincipal.Controls.Add(this.txtEspecifica);
            this.pnlPrincipal.Controls.Add(this.lblArea);
            this.pnlPrincipal.Controls.Add(this.cbLingua);
            this.pnlPrincipal.Controls.Add(this.lblLingua);
            this.pnlPrincipal.Size = new System.Drawing.Size(326, 270);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(16, 58);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(53, 19);
            this.lblTombo.TabIndex = 238;
            this.lblTombo.Text = "Tombo:";
            // 
            // txtTombo
            // 
            // 
            // 
            // 
            this.txtTombo.CustomButton.Image = null;
            this.txtTombo.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtTombo.CustomButton.Name = "";
            this.txtTombo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTombo.CustomButton.TabIndex = 1;
            this.txtTombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTombo.CustomButton.UseSelectable = true;
            this.txtTombo.CustomButton.Visible = false;
            this.txtTombo.Lines = new string[0];
            this.txtTombo.Location = new System.Drawing.Point(21, 80);
            this.txtTombo.MaxLength = 32767;
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.PasswordChar = '\0';
            this.txtTombo.ReadOnly = true;
            this.txtTombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTombo.SelectedText = "";
            this.txtTombo.SelectionLength = 0;
            this.txtTombo.SelectionStart = 0;
            this.txtTombo.ShortcutsEnabled = true;
            this.txtTombo.Size = new System.Drawing.Size(95, 23);
            this.txtTombo.TabIndex = 1;
            this.txtTombo.TabStop = false;
            this.txtTombo.UseSelectable = true;
            this.txtTombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkDisponivel
            // 
            this.checkDisponivel.AutoSize = true;
            this.checkDisponivel.Checked = true;
            this.checkDisponivel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisponivel.Location = new System.Drawing.Point(256, 159);
            this.checkDisponivel.Name = "checkDisponivel";
            this.checkDisponivel.Size = new System.Drawing.Size(15, 14);
            this.checkDisponivel.TabIndex = 235;
            this.checkDisponivel.TabStop = false;
            this.checkDisponivel.UseVisualStyleBackColor = true;
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.Location = new System.Drawing.Point(169, 155);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(71, 19);
            this.lblDisponivel.TabIndex = 236;
            this.lblDisponivel.Text = "Disponível:";
            // 
            // cbTipoTombo
            // 
            this.cbTipoTombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTombo.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbTipoTombo.FormattingEnabled = true;
            this.cbTipoTombo.Items.AddRange(new object[] {
            "Doação",
            "Compra",
            "Permuta"});
            this.cbTipoTombo.Location = new System.Drawing.Point(174, 132);
            this.cbTipoTombo.Name = "cbTipoTombo";
            this.cbTipoTombo.Size = new System.Drawing.Size(100, 23);
            this.cbTipoTombo.TabIndex = 4;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txtObservacao.Location = new System.Drawing.Point(21, 243);
            this.txtObservacao.MaxLength = 140;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(290, 25);
            this.txtObservacao.TabIndex = 6;
            this.txtObservacao.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 221);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(83, 19);
            this.lblObs.TabIndex = 234;
            this.lblObs.Text = "Observação:";
            // 
            // lblTipoTombo
            // 
            this.lblTipoTombo.AutoSize = true;
            this.lblTipoTombo.Location = new System.Drawing.Point(169, 110);
            this.lblTipoTombo.Name = "lblTipoTombo";
            this.lblTipoTombo.Size = new System.Drawing.Size(102, 19);
            this.lblTipoTombo.TabIndex = 229;
            this.lblTipoTombo.Text = "Tipo de Tombo:";
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.SystemColors.Window;
            this.cbArea.DisplayMember = "Descricao";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(21, 184);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(142, 23);
            this.cbArea.TabIndex = 5;
            this.cbArea.ValueMember = "CodArea";
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(169, 58);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(79, 19);
            this.lblLocalizacao.TabIndex = 233;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // txtLocalizacao
            // 
            // 
            // 
            // 
            this.txtLocalizacao.CustomButton.Image = null;
            this.txtLocalizacao.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.txtLocalizacao.CustomButton.Name = "";
            this.txtLocalizacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocalizacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocalizacao.CustomButton.TabIndex = 1;
            this.txtLocalizacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocalizacao.CustomButton.UseSelectable = true;
            this.txtLocalizacao.CustomButton.Visible = false;
            this.txtLocalizacao.Lines = new string[0];
            this.txtLocalizacao.Location = new System.Drawing.Point(174, 80);
            this.txtLocalizacao.MaxLength = 40;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.PasswordChar = '\0';
            this.txtLocalizacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocalizacao.SelectedText = "";
            this.txtLocalizacao.SelectionLength = 0;
            this.txtLocalizacao.SelectionStart = 0;
            this.txtLocalizacao.ShortcutsEnabled = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(124, 23);
            this.txtLocalizacao.TabIndex = 2;
            this.txtLocalizacao.UseSelectable = true;
            this.txtLocalizacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocalizacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEspecifica
            // 
            this.lblEspecifica.AutoSize = true;
            this.lblEspecifica.Location = new System.Drawing.Point(16, 6);
            this.lblEspecifica.Name = "lblEspecifica";
            this.lblEspecifica.Size = new System.Drawing.Size(89, 19);
            this.lblEspecifica.TabIndex = 232;
            this.lblEspecifica.Text = "Especificação:";
            // 
            // txtEspecifica
            // 
            // 
            // 
            // 
            this.txtEspecifica.CustomButton.Image = null;
            this.txtEspecifica.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtEspecifica.CustomButton.Name = "";
            this.txtEspecifica.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEspecifica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEspecifica.CustomButton.TabIndex = 1;
            this.txtEspecifica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEspecifica.CustomButton.UseSelectable = true;
            this.txtEspecifica.CustomButton.Visible = false;
            this.txtEspecifica.Lines = new string[0];
            this.txtEspecifica.Location = new System.Drawing.Point(21, 28);
            this.txtEspecifica.MaxLength = 50;
            this.txtEspecifica.Name = "txtEspecifica";
            this.txtEspecifica.PasswordChar = '\0';
            this.txtEspecifica.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEspecifica.SelectedText = "";
            this.txtEspecifica.SelectionLength = 0;
            this.txtEspecifica.SelectionStart = 0;
            this.txtEspecifica.ShortcutsEnabled = true;
            this.txtEspecifica.Size = new System.Drawing.Size(219, 23);
            this.txtEspecifica.TabIndex = 0;
            this.txtEspecifica.UseSelectable = true;
            this.txtEspecifica.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEspecifica.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(16, 162);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 231;
            this.lblArea.Text = "Área:";
            // 
            // cbLingua
            // 
            this.cbLingua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLingua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLingua.FormattingEnabled = true;
            this.cbLingua.Items.AddRange(new object[] {
            "Albanês ",
            "Alemão ",
            "Árabe ",
            "Arménio ",
            "Bielorrusso ",
            "Bósnio",
            "Búlgaro ",
            "Coreano ",
            "Croata ",
            "Dinamarquês ",
            "Eslovaco",
            "Esloveno ",
            "Espanhol",
            "Estoniano ",
            "Filipino ",
            "Finlandês ",
            "Francês",
            "Georgiano",
            "Grego",
            "Guarani ",
            "Hebraico ",
            "Hindi ",
            "Holandês",
            "Húngaro ",
            "Indonésio ",
            "Inglês",
            "Irlandês ",
            "Italiano ",
            "Japonês ",
            "Latim ",
            "Letão ",
            "Lituano ",
            "Macedônio",
            "Malaio ",
            "Malaiala",
            "Maori ",
            "Mongol ",
            "Nepalês ",
            "Norueguês ",
            "Persa",
            "Polonês ",
            "Português-PT",
            "Português-BR",
            "Romeno ",
            "Russo ",
            "Sérvio ",
            "Somali ",
            "Soto ",
            "Suaíli ",
            "Suázi ",
            "Sueco ",
            "Turco",
            "Turcomeno ",
            "Ucraniano ",
            "Vietnamita "});
            this.cbLingua.Location = new System.Drawing.Point(21, 132);
            this.cbLingua.Name = "cbLingua";
            this.cbLingua.Size = new System.Drawing.Size(100, 23);
            this.cbLingua.TabIndex = 3;
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(16, 110);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(50, 19);
            this.lblLingua.TabIndex = 230;
            this.lblLingua.Text = "Lingua:";
            // 
            // FrmCadMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(339, 397);
            this.Name = "FrmCadMapa";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTombo;
        private MetroFramework.Controls.MetroTextBox txtTombo;
        private System.Windows.Forms.CheckBox checkDisponivel;
        private MetroFramework.Controls.MetroLabel lblDisponivel;
        private System.Windows.Forms.ComboBox cbTipoTombo;
        private System.Windows.Forms.TextBox txtObservacao;
        private MetroFramework.Controls.MetroLabel lblObs;
        private MetroFramework.Controls.MetroLabel lblTipoTombo;
        private System.Windows.Forms.ComboBox cbArea;
        private MetroFramework.Controls.MetroLabel lblLocalizacao;
        private MetroFramework.Controls.MetroTextBox txtLocalizacao;
        private MetroFramework.Controls.MetroLabel lblEspecifica;
        private MetroFramework.Controls.MetroTextBox txtEspecifica;
        private MetroFramework.Controls.MetroLabel lblArea;
        private System.Windows.Forms.ComboBox cbLingua;
        private MetroFramework.Controls.MetroLabel lblLingua;
    }
}
