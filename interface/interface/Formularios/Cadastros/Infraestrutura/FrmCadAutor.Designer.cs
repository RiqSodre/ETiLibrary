namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmCadAutor
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
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.lblcbAutor = new MetroFramework.Controls.MetroLabel();
            this.lblNotacao = new MetroFramework.Controls.MetroLabel();
            this.txtNotacao = new MetroFramework.Controls.MetroTextBox();
            this.lblSobrenome = new MetroFramework.Controls.MetroLabel();
            this.txtSobrenome = new MetroFramework.Controls.MetroTextBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Size = new System.Drawing.Size(358, 26);
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(100, 16);
            this.lblForm.Text = "Cadastro: Autor";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Location = new System.Drawing.Point(323, 1);
            // 
            // pnlBase
            // 
            this.pnlBase.Size = new System.Drawing.Size(350, 36);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(221, -3);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(130, -3);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(39, -3);
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(256, 252);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(164, 252);
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblLinha);
            this.pnlPrincipal.Controls.Add(this.lblSobrenome);
            this.pnlPrincipal.Controls.Add(this.txtSobrenome);
            this.pnlPrincipal.Controls.Add(this.lblNotacao);
            this.pnlPrincipal.Controls.Add(this.txtNotacao);
            this.pnlPrincipal.Controls.Add(this.lblNome);
            this.pnlPrincipal.Controls.Add(this.txtNome);
            this.pnlPrincipal.Controls.Add(this.cbAutor);
            this.pnlPrincipal.Controls.Add(this.lblcbAutor);
            this.pnlPrincipal.Size = new System.Drawing.Size(338, 175);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 19);
            this.lblNome.TabIndex = 228;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(21, 93);
            this.txtNome.MaxLength = 25;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(102, 23);
            this.txtNome.TabIndex = 225;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbAutor
            // 
            this.cbAutor.DisplayMember = "Descricao";
            this.cbAutor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(21, 31);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(149, 23);
            this.cbAutor.TabIndex = 226;
            this.cbAutor.Text = "Digite o nome do autor";
            this.cbAutor.ValueMember = "CodArea";
            this.cbAutor.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblcbAutor
            // 
            this.lblcbAutor.AutoSize = true;
            this.lblcbAutor.Location = new System.Drawing.Point(16, 9);
            this.lblcbAutor.Name = "lblcbAutor";
            this.lblcbAutor.Size = new System.Drawing.Size(134, 19);
            this.lblcbAutor.TabIndex = 227;
            this.lblcbAutor.Text = "Autores Cadastrados:";
            // 
            // lblNotacao
            // 
            this.lblNotacao.AutoSize = true;
            this.lblNotacao.Location = new System.Drawing.Point(17, 123);
            this.lblNotacao.Name = "lblNotacao";
            this.lblNotacao.Size = new System.Drawing.Size(62, 19);
            this.lblNotacao.TabIndex = 230;
            this.lblNotacao.Text = "Notação:";
            // 
            // txtNotacao
            // 
            // 
            // 
            // 
            this.txtNotacao.CustomButton.Image = null;
            this.txtNotacao.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtNotacao.CustomButton.Name = "";
            this.txtNotacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNotacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotacao.CustomButton.TabIndex = 1;
            this.txtNotacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotacao.CustomButton.UseSelectable = true;
            this.txtNotacao.CustomButton.Visible = false;
            this.txtNotacao.Lines = new string[0];
            this.txtNotacao.Location = new System.Drawing.Point(22, 144);
            this.txtNotacao.MaxLength = 50;
            this.txtNotacao.Name = "txtNotacao";
            this.txtNotacao.PasswordChar = '\0';
            this.txtNotacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotacao.SelectedText = "";
            this.txtNotacao.SelectionLength = 0;
            this.txtNotacao.SelectionStart = 0;
            this.txtNotacao.ShortcutsEnabled = true;
            this.txtNotacao.Size = new System.Drawing.Size(149, 23);
            this.txtNotacao.TabIndex = 229;
            this.txtNotacao.UseSelectable = true;
            this.txtNotacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(168, 72);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(81, 19);
            this.lblSobrenome.TabIndex = 232;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            // 
            // 
            // 
            this.txtSobrenome.CustomButton.Image = null;
            this.txtSobrenome.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtSobrenome.CustomButton.Name = "";
            this.txtSobrenome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSobrenome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobrenome.CustomButton.TabIndex = 1;
            this.txtSobrenome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobrenome.CustomButton.UseSelectable = true;
            this.txtSobrenome.CustomButton.Visible = false;
            this.txtSobrenome.Lines = new string[0];
            this.txtSobrenome.Location = new System.Drawing.Point(173, 93);
            this.txtSobrenome.MaxLength = 40;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.PasswordChar = '\0';
            this.txtSobrenome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobrenome.SelectedText = "";
            this.txtSobrenome.SelectionLength = 0;
            this.txtSobrenome.SelectionStart = 0;
            this.txtSobrenome.ShortcutsEnabled = true;
            this.txtSobrenome.Size = new System.Drawing.Size(149, 23);
            this.txtSobrenome.TabIndex = 231;
            this.txtSobrenome.UseSelectable = true;
            this.txtSobrenome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobrenome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSobrenome.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Location = new System.Drawing.Point(22, 65);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(300, 2);
            this.lblLinha.TabIndex = 233;
            // 
            // FrmCadAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Name = "FrmCadAutor";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.ComboBox cbAutor;
        private MetroFramework.Controls.MetroLabel lblcbAutor;
        private MetroFramework.Controls.MetroLabel lblSobrenome;
        private MetroFramework.Controls.MetroTextBox txtSobrenome;
        private MetroFramework.Controls.MetroLabel lblNotacao;
        private MetroFramework.Controls.MetroTextBox txtNotacao;
        private System.Windows.Forms.Label lblLinha;
    }
}
