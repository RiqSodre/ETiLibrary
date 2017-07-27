namespace Interface.Formularios.Cadastros.Infraestrutura
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
            this.lblJornal = new MetroFramework.Controls.MetroLabel();
            this.txtJornal = new MetroFramework.Controls.MetroTextBox();
            this.cbJornal = new System.Windows.Forms.ComboBox();
            this.lblcbJornal = new MetroFramework.Controls.MetroLabel();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Size = new System.Drawing.Size(358, 26);
            this.pnl.TabIndex = 4;
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(106, 16);
            this.lblForm.Text = "Cadastro: Jornal";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Location = new System.Drawing.Point(323, 1);
            this.btnFechar.TabIndex = 0;
            // 
            // pnlBase
            // 
            this.pnlBase.Size = new System.Drawing.Size(350, 36);
            this.pnlBase.TabIndex = 3;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(221, -3);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(130, -3);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(39, -3);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(256, 177);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(164, 177);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblJornal);
            this.pnlPrincipal.Controls.Add(this.txtJornal);
            this.pnlPrincipal.Controls.Add(this.cbJornal);
            this.pnlPrincipal.Controls.Add(this.lblcbJornal);
            this.pnlPrincipal.Size = new System.Drawing.Size(338, 100);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // lblJornal
            // 
            this.lblJornal.AutoSize = true;
            this.lblJornal.Location = new System.Drawing.Point(13, 10);
            this.lblJornal.Name = "lblJornal";
            this.lblJornal.Size = new System.Drawing.Size(47, 19);
            this.lblJornal.TabIndex = 236;
            this.lblJornal.Text = "Jornal:";
            // 
            // txtJornal
            // 
            // 
            // 
            // 
            this.txtJornal.CustomButton.Image = null;
            this.txtJornal.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtJornal.CustomButton.Name = "";
            this.txtJornal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJornal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJornal.CustomButton.TabIndex = 1;
            this.txtJornal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJornal.CustomButton.UseSelectable = true;
            this.txtJornal.CustomButton.Visible = false;
            this.txtJornal.Lines = new string[0];
            this.txtJornal.Location = new System.Drawing.Point(18, 31);
            this.txtJornal.MaxLength = 50;
            this.txtJornal.Name = "txtJornal";
            this.txtJornal.PasswordChar = '\0';
            this.txtJornal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJornal.SelectedText = "";
            this.txtJornal.SelectionLength = 0;
            this.txtJornal.SelectionStart = 0;
            this.txtJornal.ShortcutsEnabled = true;
            this.txtJornal.Size = new System.Drawing.Size(149, 23);
            this.txtJornal.TabIndex = 0;
            this.txtJornal.UseSelectable = true;
            this.txtJornal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJornal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtJornal.Click += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbJornal
            // 
            this.cbJornal.DisplayMember = "Descricao";
            this.cbJornal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJornal.FormattingEnabled = true;
            this.cbJornal.Location = new System.Drawing.Point(177, 31);
            this.cbJornal.Name = "cbJornal";
            this.cbJornal.Size = new System.Drawing.Size(149, 23);
            this.cbJornal.TabIndex = 1;
            this.cbJornal.Text = "DIGITE O JORNAL";
            this.cbJornal.ValueMember = "CodArea";
            this.cbJornal.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            this.cbJornal.Leave += new System.EventHandler(this.cbJornal_Leave);
            // 
            // lblcbJornal
            // 
            this.lblcbJornal.AutoSize = true;
            this.lblcbJornal.Location = new System.Drawing.Point(172, 9);
            this.lblcbJornal.Name = "lblcbJornal";
            this.lblcbJornal.Size = new System.Drawing.Size(129, 19);
            this.lblcbJornal.TabIndex = 235;
            this.lblcbJornal.Text = "Jornais Cadastrados:";
            // 
            // FrmCadJornal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 225);
            this.Name = "FrmCadJornal";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblJornal;
        private MetroFramework.Controls.MetroTextBox txtJornal;
        private System.Windows.Forms.ComboBox cbJornal;
        private MetroFramework.Controls.MetroLabel lblcbJornal;
    }
}
