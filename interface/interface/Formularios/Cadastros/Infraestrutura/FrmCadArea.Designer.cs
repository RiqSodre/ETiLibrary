namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmCadArea
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
            this.lblArea = new MetroFramework.Controls.MetroLabel();
            this.txtArea = new MetroFramework.Controls.MetroTextBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.lblcbArea = new MetroFramework.Controls.MetroLabel();
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
            this.lblForm.Size = new System.Drawing.Size(98, 16);
            this.lblForm.Text = "Cadastro: Área";
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
            this.pnlPrincipal.Controls.Add(this.lblArea);
            this.pnlPrincipal.Controls.Add(this.txtArea);
            this.pnlPrincipal.Controls.Add(this.cbArea);
            this.pnlPrincipal.Controls.Add(this.lblcbArea);
            this.pnlPrincipal.Size = new System.Drawing.Size(338, 100);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(13, 10);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 220;
            this.lblArea.Text = "Área:";
            // 
            // txtArea
            // 
            // 
            // 
            // 
            this.txtArea.CustomButton.Image = null;
            this.txtArea.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtArea.CustomButton.Name = "";
            this.txtArea.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArea.CustomButton.TabIndex = 1;
            this.txtArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArea.CustomButton.UseSelectable = true;
            this.txtArea.CustomButton.Visible = false;
            this.txtArea.Lines = new string[0];
            this.txtArea.Location = new System.Drawing.Point(18, 31);
            this.txtArea.MaxLength = 50;
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArea.SelectedText = "";
            this.txtArea.SelectionLength = 0;
            this.txtArea.SelectionStart = 0;
            this.txtArea.ShortcutsEnabled = true;
            this.txtArea.Size = new System.Drawing.Size(149, 23);
            this.txtArea.TabIndex = 217;
            this.txtArea.UseSelectable = true;
            this.txtArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtArea.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbArea
            // 
            this.cbArea.DisplayMember = "Descricao";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(177, 31);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(149, 23);
            this.cbArea.TabIndex = 218;
            this.cbArea.ValueMember = "CodArea";
            this.cbArea.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // lblcbArea
            // 
            this.lblcbArea.AutoSize = true;
            this.lblcbArea.Location = new System.Drawing.Point(172, 9);
            this.lblcbArea.Name = "lblcbArea";
            this.lblcbArea.Size = new System.Drawing.Size(121, 19);
            this.lblcbArea.TabIndex = 219;
            this.lblcbArea.Text = "Áreas Cadastradas:";
            // 
            // FrmCadArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 225);
            this.Name = "FrmCadArea";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblArea;
        private MetroFramework.Controls.MetroTextBox txtArea;
        private System.Windows.Forms.ComboBox cbArea;
        private MetroFramework.Controls.MetroLabel lblcbArea;
    }
}
