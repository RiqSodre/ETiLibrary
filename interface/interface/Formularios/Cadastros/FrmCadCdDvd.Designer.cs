namespace Interface.Formularios.Cadastros
{
    partial class FrmCadCdDvd
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
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cbLingua = new System.Windows.Forms.ComboBox();
            this.lblLingua = new MetroFramework.Controls.MetroLabel();
            this.lblArea = new MetroFramework.Controls.MetroLabel();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.lblLocalizacao = new MetroFramework.Controls.MetroLabel();
            this.txtLocalizacao = new MetroFramework.Controls.MetroTextBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.lblTipoTombo = new MetroFramework.Controls.MetroLabel();
            this.lblObs = new MetroFramework.Controls.MetroLabel();
            this.cbTipoTombo = new System.Windows.Forms.ComboBox();
            this.checkDisponivel = new System.Windows.Forms.CheckBox();
            this.lblDisponivel = new MetroFramework.Controls.MetroLabel();
            this.lblTombo = new MetroFramework.Controls.MetroLabel();
            this.txtTombo = new MetroFramework.Controls.MetroTextBox();
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
            this.lblForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblForm.Size = new System.Drawing.Size(168, 20);
            this.lblForm.Text = "Cadastro: CD e DVD";
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
            this.btnCancelar.Location = new System.Drawing.Point(321, 373);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(199, 373);
            this.btnAcao.Margin = new System.Windows.Forms.Padding(5);
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
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Controls.Add(this.txtTitulo);
            this.pnlPrincipal.Controls.Add(this.lblArea);
            this.pnlPrincipal.Controls.Add(this.cbLingua);
            this.pnlPrincipal.Controls.Add(this.lblLingua);
            this.pnlPrincipal.Size = new System.Drawing.Size(435, 274);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(28, 235);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.MaxLength = 140;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(385, 30);
            this.txtObservacao.TabIndex = 5;
            this.txtObservacao.Click += new System.EventHandler(this.txtObservacao_Click);
            this.txtObservacao.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // cbLingua
            // 
            this.cbLingua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbLingua.Location = new System.Drawing.Point(28, 99);
            this.cbLingua.Margin = new System.Windows.Forms.Padding(4);
            this.cbLingua.Name = "cbLingua";
            this.cbLingua.Size = new System.Drawing.Size(163, 24);
            this.cbLingua.TabIndex = 2;
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(21, 72);
            this.lblLingua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(53, 20);
            this.lblLingua.TabIndex = 209;
            this.lblLingua.Text = "Lingua:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(21, 136);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(41, 20);
            this.lblArea.TabIndex = 210;
            this.lblArea.Text = "Área:";
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.txtTitulo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(28, 35);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(164, 28);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 8);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 20);
            this.lblTitulo.TabIndex = 212;
            this.lblTitulo.Text = "Título:";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(225, 72);
            this.lblLocalizacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(83, 20);
            this.lblLocalizacao.TabIndex = 214;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // txtLocalizacao
            // 
            // 
            // 
            // 
            this.txtLocalizacao.CustomButton.Image = null;
            this.txtLocalizacao.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.txtLocalizacao.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalizacao.CustomButton.Name = "";
            this.txtLocalizacao.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLocalizacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocalizacao.CustomButton.TabIndex = 1;
            this.txtLocalizacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocalizacao.CustomButton.UseSelectable = true;
            this.txtLocalizacao.CustomButton.Visible = false;
            this.txtLocalizacao.Lines = new string[0];
            this.txtLocalizacao.Location = new System.Drawing.Point(232, 99);
            this.txtLocalizacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalizacao.MaxLength = 40;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.PasswordChar = '\0';
            this.txtLocalizacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocalizacao.SelectedText = "";
            this.txtLocalizacao.SelectionLength = 0;
            this.txtLocalizacao.SelectionStart = 0;
            this.txtLocalizacao.ShortcutsEnabled = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(164, 28);
            this.txtLocalizacao.TabIndex = 1;
            this.txtLocalizacao.UseSelectable = true;
            this.txtLocalizacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocalizacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.SystemColors.Window;
            this.cbArea.DisplayMember = "Descricao";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(28, 163);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(163, 24);
            this.cbArea.TabIndex = 4;
            this.cbArea.ValueMember = "CodArea";
            // 
            // lblTipoTombo
            // 
            this.lblTipoTombo.AutoSize = true;
            this.lblTipoTombo.Location = new System.Drawing.Point(225, 136);
            this.lblTipoTombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTombo.Name = "lblTipoTombo";
            this.lblTipoTombo.Size = new System.Drawing.Size(105, 20);
            this.lblTipoTombo.TabIndex = 202;
            this.lblTipoTombo.Text = "Tipo de Tombo:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(21, 208);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(87, 20);
            this.lblObs.TabIndex = 217;
            this.lblObs.Text = "Observação:";
            // 
            // cbTipoTombo
            // 
            this.cbTipoTombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTombo.FormattingEnabled = true;
            this.cbTipoTombo.Items.AddRange(new object[] {
            "Doação",
            "Compra",
            "Permuta"});
            this.cbTipoTombo.Location = new System.Drawing.Point(232, 163);
            this.cbTipoTombo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoTombo.Name = "cbTipoTombo";
            this.cbTipoTombo.Size = new System.Drawing.Size(163, 24);
            this.cbTipoTombo.TabIndex = 3;
            // 
            // checkDisponivel
            // 
            this.checkDisponivel.AutoSize = true;
            this.checkDisponivel.Checked = true;
            this.checkDisponivel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisponivel.Location = new System.Drawing.Point(341, 196);
            this.checkDisponivel.Margin = new System.Windows.Forms.Padding(4);
            this.checkDisponivel.Name = "checkDisponivel";
            this.checkDisponivel.Size = new System.Drawing.Size(18, 17);
            this.checkDisponivel.TabIndex = 219;
            this.checkDisponivel.TabStop = false;
            this.checkDisponivel.UseVisualStyleBackColor = true;
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.Location = new System.Drawing.Point(225, 191);
            this.lblDisponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(76, 20);
            this.lblDisponivel.TabIndex = 220;
            this.lblDisponivel.Text = "Disponivel:";
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(225, 11);
            this.lblTombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(54, 20);
            this.lblTombo.TabIndex = 222;
            this.lblTombo.Text = "Tombo:";
            // 
            // txtTombo
            // 
            // 
            // 
            // 
            this.txtTombo.CustomButton.Image = null;
            this.txtTombo.CustomButton.Location = new System.Drawing.Point(101, 2);
            this.txtTombo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTombo.CustomButton.Name = "";
            this.txtTombo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTombo.CustomButton.TabIndex = 1;
            this.txtTombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTombo.CustomButton.UseSelectable = true;
            this.txtTombo.CustomButton.Visible = false;
            this.txtTombo.Lines = new string[0];
            this.txtTombo.Location = new System.Drawing.Point(232, 35);
            this.txtTombo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTombo.MaxLength = 32767;
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.PasswordChar = '\0';
            this.txtTombo.ReadOnly = true;
            this.txtTombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTombo.SelectedText = "";
            this.txtTombo.SelectionLength = 0;
            this.txtTombo.SelectionStart = 0;
            this.txtTombo.ShortcutsEnabled = true;
            this.txtTombo.Size = new System.Drawing.Size(127, 28);
            this.txtTombo.TabIndex = 221;
            this.txtTombo.TabStop = false;
            this.txtTombo.UseSelectable = true;
            this.txtTombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmCadCdDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 425);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCadCdDvd";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Cadastro: CD e DVD";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cbLingua;
        private MetroFramework.Controls.MetroLabel lblLingua;
        private MetroFramework.Controls.MetroLabel lblArea;
        private MetroFramework.Controls.MetroLabel lblLocalizacao;
        private MetroFramework.Controls.MetroTextBox txtLocalizacao;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroTextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbArea;
        private MetroFramework.Controls.MetroLabel lblObs;
        private MetroFramework.Controls.MetroLabel lblTipoTombo;
        private System.Windows.Forms.ComboBox cbTipoTombo;
        private System.Windows.Forms.CheckBox checkDisponivel;
        private MetroFramework.Controls.MetroLabel lblDisponivel;
        private MetroFramework.Controls.MetroLabel lblTombo;
        private MetroFramework.Controls.MetroTextBox txtTombo;
    }
}