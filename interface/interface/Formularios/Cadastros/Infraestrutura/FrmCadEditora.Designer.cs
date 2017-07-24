namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmCadEditora
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
            this.lblEditora = new MetroFramework.Controls.MetroLabel();
            this.txtEditora = new MetroFramework.Controls.MetroTextBox();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.lblcbEditora = new MetroFramework.Controls.MetroLabel();
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
            this.lblForm.Size = new System.Drawing.Size(112, 16);
            this.lblForm.Text = "Cadastro: Editora";
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
            this.btnCancelar.Location = new System.Drawing.Point(256, 177);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(164, 177);
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblEditora);
            this.pnlPrincipal.Controls.Add(this.txtEditora);
            this.pnlPrincipal.Controls.Add(this.cbEditora);
            this.pnlPrincipal.Controls.Add(this.lblcbEditora);
            this.pnlPrincipal.Size = new System.Drawing.Size(338, 100);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(13, 10);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(54, 19);
            this.lblEditora.TabIndex = 228;
            this.lblEditora.Text = "Editora:";
            // 
            // txtEditora
            // 
            // 
            // 
            // 
            this.txtEditora.CustomButton.Image = null;
            this.txtEditora.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtEditora.CustomButton.Name = "";
            this.txtEditora.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEditora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditora.CustomButton.TabIndex = 1;
            this.txtEditora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEditora.CustomButton.UseSelectable = true;
            this.txtEditora.CustomButton.Visible = false;
            this.txtEditora.Lines = new string[0];
            this.txtEditora.Location = new System.Drawing.Point(18, 31);
            this.txtEditora.MaxLength = 50;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.PasswordChar = '\0';
            this.txtEditora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEditora.SelectedText = "";
            this.txtEditora.SelectionLength = 0;
            this.txtEditora.SelectionStart = 0;
            this.txtEditora.ShortcutsEnabled = true;
            this.txtEditora.Size = new System.Drawing.Size(149, 23);
            this.txtEditora.TabIndex = 225;
            this.txtEditora.UseSelectable = true;
            this.txtEditora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEditora.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditora.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbEditora
            // 
            this.cbEditora.DisplayMember = "Descricao";
            this.cbEditora.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(177, 31);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(149, 23);
            this.cbEditora.TabIndex = 226;
            this.cbEditora.Text = "Digite a editora";
            this.cbEditora.ValueMember = "CodArea";
            this.cbEditora.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblcbEditora
            // 
            this.lblcbEditora.AutoSize = true;
            this.lblcbEditora.Location = new System.Drawing.Point(172, 9);
            this.lblcbEditora.Name = "lblcbEditora";
            this.lblcbEditora.Size = new System.Drawing.Size(130, 19);
            this.lblcbEditora.TabIndex = 227;
            this.lblcbEditora.Text = "Editora Cadastradas:";
            // 
            // FrmCadEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 225);
            this.Name = "FrmCadEditora";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblEditora;
        private MetroFramework.Controls.MetroTextBox txtEditora;
        private System.Windows.Forms.ComboBox cbEditora;
        private MetroFramework.Controls.MetroLabel lblcbEditora;
    }
}
