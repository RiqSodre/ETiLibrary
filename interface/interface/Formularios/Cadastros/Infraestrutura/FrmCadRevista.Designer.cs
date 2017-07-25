namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmCadRevista
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
            this.lblRevista = new MetroFramework.Controls.MetroLabel();
            this.txtRevista = new MetroFramework.Controls.MetroTextBox();
            this.cbRevista = new System.Windows.Forms.ComboBox();
            this.lblcbRevista = new MetroFramework.Controls.MetroLabel();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.lblEditora = new MetroFramework.Controls.MetroLabel();
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
            this.lblForm.Size = new System.Drawing.Size(115, 16);
            this.lblForm.Text = "Cadastro: Revista";
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
            this.btnCancelar.Location = new System.Drawing.Point(256, 202);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(164, 202);
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.cbEditora);
            this.pnlPrincipal.Controls.Add(this.lblEditora);
            this.pnlPrincipal.Controls.Add(this.lblRevista);
            this.pnlPrincipal.Controls.Add(this.txtRevista);
            this.pnlPrincipal.Controls.Add(this.cbRevista);
            this.pnlPrincipal.Controls.Add(this.lblcbRevista);
            this.pnlPrincipal.Size = new System.Drawing.Size(338, 125);
            // 
            // lblRevista
            // 
            this.lblRevista.AutoSize = true;
            this.lblRevista.Location = new System.Drawing.Point(13, 10);
            this.lblRevista.Name = "lblRevista";
            this.lblRevista.Size = new System.Drawing.Size(52, 19);
            this.lblRevista.TabIndex = 228;
            this.lblRevista.Text = "Revista:";
            // 
            // txtRevista
            // 
            // 
            // 
            // 
            this.txtRevista.CustomButton.Image = null;
            this.txtRevista.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtRevista.CustomButton.Name = "";
            this.txtRevista.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRevista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRevista.CustomButton.TabIndex = 1;
            this.txtRevista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRevista.CustomButton.UseSelectable = true;
            this.txtRevista.CustomButton.Visible = false;
            this.txtRevista.Lines = new string[0];
            this.txtRevista.Location = new System.Drawing.Point(18, 31);
            this.txtRevista.MaxLength = 50;
            this.txtRevista.Name = "txtRevista";
            this.txtRevista.PasswordChar = '\0';
            this.txtRevista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRevista.SelectedText = "";
            this.txtRevista.SelectionLength = 0;
            this.txtRevista.SelectionStart = 0;
            this.txtRevista.ShortcutsEnabled = true;
            this.txtRevista.Size = new System.Drawing.Size(149, 23);
            this.txtRevista.TabIndex = 225;
            this.txtRevista.UseSelectable = true;
            this.txtRevista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRevista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRevista.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbRevista
            // 
            this.cbRevista.DisplayMember = "Descricao";
            this.cbRevista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRevista.FormattingEnabled = true;
            this.cbRevista.Location = new System.Drawing.Point(177, 31);
            this.cbRevista.Name = "cbRevista";
            this.cbRevista.Size = new System.Drawing.Size(149, 23);
            this.cbRevista.TabIndex = 226;
            this.cbRevista.Text = "Digite a revista";
            this.cbRevista.ValueMember = "CodArea";
            this.cbRevista.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblcbRevista
            // 
            this.lblcbRevista.AutoSize = true;
            this.lblcbRevista.Location = new System.Drawing.Point(172, 9);
            this.lblcbRevista.Name = "lblcbRevista";
            this.lblcbRevista.Size = new System.Drawing.Size(128, 19);
            this.lblcbRevista.TabIndex = 227;
            this.lblcbRevista.Text = "Revista Cadastradas:";
            // 
            // cbEditora
            // 
            this.cbEditora.DisplayMember = "Descricao";
            this.cbEditora.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(177, 83);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(149, 23);
            this.cbEditora.TabIndex = 229;
            this.cbEditora.Text = "Digite a editora";
            this.cbEditora.ValueMember = "CodArea";
            this.cbEditora.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(172, 61);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(54, 19);
            this.lblEditora.TabIndex = 230;
            this.lblEditora.Text = "Editora:";
            // 
            // FrmCadRevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Name = "FrmCadRevista";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblRevista;
        private MetroFramework.Controls.MetroTextBox txtRevista;
        private System.Windows.Forms.ComboBox cbRevista;
        private MetroFramework.Controls.MetroLabel lblcbRevista;
        private System.Windows.Forms.ComboBox cbEditora;
        private MetroFramework.Controls.MetroLabel lblEditora;
    }
}
