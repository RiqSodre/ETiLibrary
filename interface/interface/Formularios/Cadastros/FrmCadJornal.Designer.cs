namespace Interface.Formularios.Cadastros
{
    partial class FrmCadJornal
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
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblDataPublicacao = new System.Windows.Forms.Label();
            this.txtLocalizacao = new MetroFramework.Controls.MetroTextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.txtArea = new MetroFramework.Controls.MetroTextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtLingua = new MetroFramework.Controls.MetroTextBox();
            this.lblLingua = new System.Windows.Forms.Label();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(103, 16);
            this.lblForm.Text = "Cadastro: Aluno";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 302);
            // 
            // btnSalvar
            // 
            this.btnAcao.Location = new System.Drawing.Point(149, 302);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(26, 254);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(290, 23);
            this.txtObservacao.TabIndex = 130;
            this.txtObservacao.Click += new System.EventHandler(this.txtObservacao_Click);
            this.txtObservacao.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(23, 238);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 129;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Location = new System.Drawing.Point(179, 134);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(104, 13);
            this.lblDataPublicacao.TabIndex = 127;
            this.lblDataPublicacao.Text = "Data de Publicação:";
            // 
            // txtLocalizacao
            // 
            // 
            // 
            // 
            this.txtLocalizacao.CustomButton.Image = null;
            this.txtLocalizacao.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtLocalizacao.CustomButton.Name = "";
            this.txtLocalizacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocalizacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocalizacao.CustomButton.TabIndex = 1;
            this.txtLocalizacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocalizacao.CustomButton.UseSelectable = true;
            this.txtLocalizacao.CustomButton.Visible = false;
            this.txtLocalizacao.Lines = new string[0];
            this.txtLocalizacao.Location = new System.Drawing.Point(182, 102);
            this.txtLocalizacao.MaxLength = 32767;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.PasswordChar = '\0';
            this.txtLocalizacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocalizacao.SelectedText = "";
            this.txtLocalizacao.SelectionLength = 0;
            this.txtLocalizacao.SelectionStart = 0;
            this.txtLocalizacao.ShortcutsEnabled = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(121, 23);
            this.txtLocalizacao.TabIndex = 126;
            this.txtLocalizacao.UseSelectable = true;
            this.txtLocalizacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocalizacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(180, 86);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(67, 13);
            this.lblLocalizacao.TabIndex = 125;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // txtArea
            // 
            // 
            // 
            // 
            this.txtArea.CustomButton.Image = null;
            this.txtArea.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtArea.CustomButton.Name = "";
            this.txtArea.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArea.CustomButton.TabIndex = 1;
            this.txtArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArea.CustomButton.UseSelectable = true;
            this.txtArea.CustomButton.Visible = false;
            this.txtArea.Lines = new string[0];
            this.txtArea.Location = new System.Drawing.Point(26, 201);
            this.txtArea.MaxLength = 32767;
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArea.SelectedText = "";
            this.txtArea.SelectionLength = 0;
            this.txtArea.SelectionStart = 0;
            this.txtArea.ShortcutsEnabled = true;
            this.txtArea.Size = new System.Drawing.Size(121, 23);
            this.txtArea.TabIndex = 124;
            this.txtArea.UseSelectable = true;
            this.txtArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(23, 185);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 123;
            this.lblArea.Text = "Área:";
            // 
            // txtLingua
            // 
            // 
            // 
            // 
            this.txtLingua.CustomButton.Image = null;
            this.txtLingua.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtLingua.CustomButton.Name = "";
            this.txtLingua.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLingua.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLingua.CustomButton.TabIndex = 1;
            this.txtLingua.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLingua.CustomButton.UseSelectable = true;
            this.txtLingua.CustomButton.Visible = false;
            this.txtLingua.Lines = new string[0];
            this.txtLingua.Location = new System.Drawing.Point(26, 150);
            this.txtLingua.MaxLength = 32767;
            this.txtLingua.Name = "txtLingua";
            this.txtLingua.PasswordChar = '\0';
            this.txtLingua.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLingua.SelectedText = "";
            this.txtLingua.SelectionLength = 0;
            this.txtLingua.SelectionStart = 0;
            this.txtLingua.ShortcutsEnabled = true;
            this.txtLingua.Size = new System.Drawing.Size(121, 23);
            this.txtLingua.TabIndex = 122;
            this.txtLingua.UseSelectable = true;
            this.txtLingua.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLingua.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(23, 134);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(44, 13);
            this.lblLingua.TabIndex = 121;
            this.lblLingua.Text = "Língua:";
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(26, 102);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(121, 23);
            this.txtTitulo.TabIndex = 120;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(23, 86);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 119;
            this.lblTitulo.Text = "Título:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 131;
            // 
            // FrmCadJornal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 348);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblDataPublicacao);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtLingua);
            this.Controls.Add(this.lblLingua);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCadJornal";
            this.Text = "Cadastro: Jornal";
            this.Load += new System.EventHandler(this.FrmCadJornal_Load);
            this.Click += new System.EventHandler(this.txtObservacao_Click);
            this.Leave += new System.EventHandler(this.txtObservacao_Leave);
            this.Controls.SetChildIndex(this.pnlBase, 0);
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.btnAcao, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.lblLingua, 0);
            this.Controls.SetChildIndex(this.txtLingua, 0);
            this.Controls.SetChildIndex(this.lblArea, 0);
            this.Controls.SetChildIndex(this.txtArea, 0);
            this.Controls.SetChildIndex(this.lblLocalizacao, 0);
            this.Controls.SetChildIndex(this.txtLocalizacao, 0);
            this.Controls.SetChildIndex(this.lblDataPublicacao, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObservacao;
        public System.Windows.Forms.Label lblObservacao;
        public System.Windows.Forms.Label lblDataPublicacao;
        public MetroFramework.Controls.MetroTextBox txtLocalizacao;
        public System.Windows.Forms.Label lblLocalizacao;
        public MetroFramework.Controls.MetroTextBox txtArea;
        public System.Windows.Forms.Label lblArea;
        public MetroFramework.Controls.MetroTextBox txtLingua;
        public System.Windows.Forms.Label lblLingua;
        public MetroFramework.Controls.MetroTextBox txtTitulo;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}