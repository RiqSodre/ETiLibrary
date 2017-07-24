namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmCadAssunto
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
            this.lblAssunto = new MetroFramework.Controls.MetroLabel();
            this.txtAssunto = new MetroFramework.Controls.MetroTextBox();
            this.cbAssunto = new System.Windows.Forms.ComboBox();
            this.lblcbAssunto = new MetroFramework.Controls.MetroLabel();
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
            this.lblForm.Size = new System.Drawing.Size(117, 16);
            this.lblForm.Text = "Cadastro: Assunto";
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
            this.pnlPrincipal.Controls.Add(this.lblAssunto);
            this.pnlPrincipal.Controls.Add(this.txtAssunto);
            this.pnlPrincipal.Controls.Add(this.cbAssunto);
            this.pnlPrincipal.Controls.Add(this.lblcbAssunto);
            this.pnlPrincipal.Size = new System.Drawing.Size(338, 100);
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(13, 10);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(57, 19);
            this.lblAssunto.TabIndex = 224;
            this.lblAssunto.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            // 
            // 
            // 
            this.txtAssunto.CustomButton.Image = null;
            this.txtAssunto.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtAssunto.CustomButton.Name = "";
            this.txtAssunto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAssunto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAssunto.CustomButton.TabIndex = 1;
            this.txtAssunto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAssunto.CustomButton.UseSelectable = true;
            this.txtAssunto.CustomButton.Visible = false;
            this.txtAssunto.Lines = new string[0];
            this.txtAssunto.Location = new System.Drawing.Point(18, 31);
            this.txtAssunto.MaxLength = 50;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.PasswordChar = '\0';
            this.txtAssunto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAssunto.SelectedText = "";
            this.txtAssunto.SelectionLength = 0;
            this.txtAssunto.SelectionStart = 0;
            this.txtAssunto.ShortcutsEnabled = true;
            this.txtAssunto.Size = new System.Drawing.Size(149, 23);
            this.txtAssunto.TabIndex = 221;
            this.txtAssunto.UseSelectable = true;
            this.txtAssunto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAssunto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAssunto.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbAssunto
            // 
            this.cbAssunto.DisplayMember = "Descricao";
            this.cbAssunto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssunto.FormattingEnabled = true;
            this.cbAssunto.Location = new System.Drawing.Point(177, 31);
            this.cbAssunto.Name = "cbAssunto";
            this.cbAssunto.Size = new System.Drawing.Size(149, 23);
            this.cbAssunto.TabIndex = 222;
            this.cbAssunto.Text = "Digite o assunto";
            this.cbAssunto.ValueMember = "CodArea";
            this.cbAssunto.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblcbAssunto
            // 
            this.lblcbAssunto.AutoSize = true;
            this.lblcbAssunto.Location = new System.Drawing.Point(172, 9);
            this.lblcbAssunto.Name = "lblcbAssunto";
            this.lblcbAssunto.Size = new System.Drawing.Size(139, 19);
            this.lblcbAssunto.TabIndex = 223;
            this.lblcbAssunto.Text = "Assuntos Cadastrados:";
            // 
            // FrmCadAssunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 225);
            this.Name = "FrmCadAssunto";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAssunto;
        private MetroFramework.Controls.MetroTextBox txtAssunto;
        private System.Windows.Forms.ComboBox cbAssunto;
        private MetroFramework.Controls.MetroLabel lblcbAssunto;
    }
}
