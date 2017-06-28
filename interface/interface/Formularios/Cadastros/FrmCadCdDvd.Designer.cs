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
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtLingua = new MetroFramework.Controls.MetroTextBox();
            this.lblLingua = new System.Windows.Forms.Label();
            this.txtArea = new MetroFramework.Controls.MetroTextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtLocalizacao = new MetroFramework.Controls.MetroTextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblDataPublicacao = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblForm
            // 
            this.lblForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblForm.Size = new System.Drawing.Size(129, 20);
            this.lblForm.Text = "Cadastro: Aluno";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.TabIndex = 0;
            // 
            // pnlBase
            // 
            this.pnlBase.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(321, 372);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.TabIndex = 8;
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(199, 372);
            this.btnAcao.Margin = new System.Windows.Forms.Padding(5);
            this.btnAcao.TabIndex = 7;
            this.btnAcao.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.TabIndex = 1;
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtTitulo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(35, 126);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(161, 28);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(31, 106);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 17);
            this.lblTitulo.TabIndex = 107;
            this.lblTitulo.Text = "Título:";
            // 
            // txtLingua
            // 
            // 
            // 
            // 
            this.txtLingua.CustomButton.Image = null;
            this.txtLingua.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtLingua.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtLingua.CustomButton.Name = "";
            this.txtLingua.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLingua.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLingua.CustomButton.TabIndex = 1;
            this.txtLingua.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLingua.CustomButton.UseSelectable = true;
            this.txtLingua.CustomButton.Visible = false;
            this.txtLingua.Lines = new string[0];
            this.txtLingua.Location = new System.Drawing.Point(35, 190);
            this.txtLingua.Margin = new System.Windows.Forms.Padding(4);
            this.txtLingua.MaxLength = 32767;
            this.txtLingua.Name = "txtLingua";
            this.txtLingua.PasswordChar = '\0';
            this.txtLingua.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLingua.SelectedText = "";
            this.txtLingua.SelectionLength = 0;
            this.txtLingua.SelectionStart = 0;
            this.txtLingua.ShortcutsEnabled = true;
            this.txtLingua.Size = new System.Drawing.Size(161, 28);
            this.txtLingua.TabIndex = 3;
            this.txtLingua.UseSelectable = true;
            this.txtLingua.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLingua.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(31, 170);
            this.lblLingua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(55, 17);
            this.lblLingua.TabIndex = 109;
            this.lblLingua.Text = "Língua:";
            // 
            // txtArea
            // 
            // 
            // 
            // 
            this.txtArea.CustomButton.Image = null;
            this.txtArea.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtArea.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.CustomButton.Name = "";
            this.txtArea.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArea.CustomButton.TabIndex = 1;
            this.txtArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArea.CustomButton.UseSelectable = true;
            this.txtArea.CustomButton.Visible = false;
            this.txtArea.Lines = new string[0];
            this.txtArea.Location = new System.Drawing.Point(35, 252);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.MaxLength = 32767;
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArea.SelectedText = "";
            this.txtArea.SelectionLength = 0;
            this.txtArea.SelectionStart = 0;
            this.txtArea.ShortcutsEnabled = true;
            this.txtArea.Size = new System.Drawing.Size(161, 28);
            this.txtArea.TabIndex = 5;
            this.txtArea.UseSelectable = true;
            this.txtArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(31, 233);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 111;
            this.lblArea.Text = "Área:";
            // 
            // txtLocalizacao
            // 
            // 
            // 
            // 
            this.txtLocalizacao.CustomButton.Image = null;
            this.txtLocalizacao.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtLocalizacao.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalizacao.CustomButton.Name = "";
            this.txtLocalizacao.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLocalizacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocalizacao.CustomButton.TabIndex = 1;
            this.txtLocalizacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocalizacao.CustomButton.UseSelectable = true;
            this.txtLocalizacao.CustomButton.Visible = false;
            this.txtLocalizacao.Lines = new string[0];
            this.txtLocalizacao.Location = new System.Drawing.Point(247, 126);
            this.txtLocalizacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalizacao.MaxLength = 32767;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.PasswordChar = '\0';
            this.txtLocalizacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocalizacao.SelectedText = "";
            this.txtLocalizacao.SelectionLength = 0;
            this.txtLocalizacao.SelectionStart = 0;
            this.txtLocalizacao.ShortcutsEnabled = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(161, 28);
            this.txtLocalizacao.TabIndex = 2;
            this.txtLocalizacao.UseSelectable = true;
            this.txtLocalizacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocalizacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(243, 106);
            this.lblLocalizacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(87, 17);
            this.lblLocalizacao.TabIndex = 113;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Location = new System.Drawing.Point(243, 170);
            this.lblDataPublicacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(135, 17);
            this.lblDataPublicacao.TabIndex = 115;
            this.lblDataPublicacao.Text = "Data de Publicação:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(31, 298);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(89, 17);
            this.lblObservacao.TabIndex = 117;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(35, 318);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(385, 27);
            this.txtObservacao.TabIndex = 6;
            this.txtObservacao.Click += new System.EventHandler(this.txtObservacao_Click);
            this.txtObservacao.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 193);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // FrmCadCdDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 428);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCadCdDvd";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Cadastro: CD e DVD";
            this.Load += new System.EventHandler(this.FrmCadCdDvd_Load);
            this.Controls.SetChildIndex(this.pnlPrincipal, 0);
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

        public MetroFramework.Controls.MetroTextBox txtTitulo;
        public System.Windows.Forms.Label lblTitulo;
        public MetroFramework.Controls.MetroTextBox txtLingua;
        public System.Windows.Forms.Label lblLingua;
        public MetroFramework.Controls.MetroTextBox txtArea;
        public System.Windows.Forms.Label lblArea;
        public MetroFramework.Controls.MetroTextBox txtLocalizacao;
        public System.Windows.Forms.Label lblLocalizacao;
        public System.Windows.Forms.Label lblDataPublicacao;
        public System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}