namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmCadGenero
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
            this.lblGenero = new MetroFramework.Controls.MetroLabel();
            this.txtGenero = new MetroFramework.Controls.MetroTextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblcbGenero = new MetroFramework.Controls.MetroLabel();
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
            this.lblForm.Size = new System.Drawing.Size(114, 16);
            this.lblForm.Text = "Cadastro: Gênero";
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
            this.pnlPrincipal.Controls.Add(this.lblGenero);
            this.pnlPrincipal.Controls.Add(this.txtGenero);
            this.pnlPrincipal.Controls.Add(this.cbGenero);
            this.pnlPrincipal.Controls.Add(this.lblcbGenero);
            this.pnlPrincipal.Size = new System.Drawing.Size(338, 100);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(13, 10);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(55, 19);
            this.lblGenero.TabIndex = 232;
            this.lblGenero.Text = "Gênero:";
            // 
            // txtGenero
            // 
            // 
            // 
            // 
            this.txtGenero.CustomButton.Image = null;
            this.txtGenero.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtGenero.CustomButton.Name = "";
            this.txtGenero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGenero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenero.CustomButton.TabIndex = 1;
            this.txtGenero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenero.CustomButton.UseSelectable = true;
            this.txtGenero.CustomButton.Visible = false;
            this.txtGenero.Lines = new string[0];
            this.txtGenero.Location = new System.Drawing.Point(18, 31);
            this.txtGenero.MaxLength = 50;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.PasswordChar = '\0';
            this.txtGenero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenero.SelectedText = "";
            this.txtGenero.SelectionLength = 0;
            this.txtGenero.SelectionStart = 0;
            this.txtGenero.ShortcutsEnabled = true;
            this.txtGenero.Size = new System.Drawing.Size(149, 23);
            this.txtGenero.TabIndex = 229;
            this.txtGenero.UseSelectable = true;
            this.txtGenero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGenero.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbGenero
            // 
            this.cbGenero.DisplayMember = "Descricao";
            this.cbGenero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(177, 31);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(149, 23);
            this.cbGenero.TabIndex = 230;
            this.cbGenero.Text = "Digite a editora";
            this.cbGenero.ValueMember = "CodArea";
            this.cbGenero.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblcbGenero
            // 
            this.lblcbGenero.AutoSize = true;
            this.lblcbGenero.Location = new System.Drawing.Point(172, 9);
            this.lblcbGenero.Name = "lblcbGenero";
            this.lblcbGenero.Size = new System.Drawing.Size(137, 19);
            this.lblcbGenero.TabIndex = 231;
            this.lblcbGenero.Text = "Gêneros Cadastrados:";
            // 
            // FrmCadGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 225);
            this.Name = "FrmCadGenero";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblGenero;
        private MetroFramework.Controls.MetroTextBox txtGenero;
        private System.Windows.Forms.ComboBox cbGenero;
        private MetroFramework.Controls.MetroLabel lblcbGenero;
    }
}
