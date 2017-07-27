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
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbLingua = new System.Windows.Forms.ComboBox();
            this.lblLingua = new MetroFramework.Controls.MetroLabel();
            this.lblArea = new MetroFramework.Controls.MetroLabel();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.lblLocaliza = new MetroFramework.Controls.MetroLabel();
            this.txtLocaliza = new MetroFramework.Controls.MetroTextBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.lblTipoTombo = new MetroFramework.Controls.MetroLabel();
            this.lblObs = new MetroFramework.Controls.MetroLabel();
            this.cbTipoTombo = new System.Windows.Forms.ComboBox();
            this.checkDisp = new System.Windows.Forms.CheckBox();
            this.lblDisp = new MetroFramework.Controls.MetroLabel();
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
            this.lblForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForm.Size = new System.Drawing.Size(131, 16);
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
            this.btnCancelar.Location = new System.Drawing.Point(241, 303);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.TabIndex = 2;
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(149, 303);
            this.btnAcao.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblTombo);
            this.pnlPrincipal.Controls.Add(this.txtTombo);
            this.pnlPrincipal.Controls.Add(this.checkDisp);
            this.pnlPrincipal.Controls.Add(this.lblDisp);
            this.pnlPrincipal.Controls.Add(this.cbTipoTombo);
            this.pnlPrincipal.Controls.Add(this.txtObs);
            this.pnlPrincipal.Controls.Add(this.lblObs);
            this.pnlPrincipal.Controls.Add(this.lblTipoTombo);
            this.pnlPrincipal.Controls.Add(this.cbArea);
            this.pnlPrincipal.Controls.Add(this.lblLocaliza);
            this.pnlPrincipal.Controls.Add(this.txtLocaliza);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Controls.Add(this.txtTitulo);
            this.pnlPrincipal.Controls.Add(this.lblArea);
            this.pnlPrincipal.Controls.Add(this.cbLingua);
            this.pnlPrincipal.Controls.Add(this.lblLingua);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Size = new System.Drawing.Size(326, 223);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txtObs.Location = new System.Drawing.Point(21, 191);
            this.txtObs.MaxLength = 140;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(290, 25);
            this.txtObs.TabIndex = 5;
            this.txtObs.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // cbLingua
            // 
            this.cbLingua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLingua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbLingua.Location = new System.Drawing.Point(21, 80);
            this.cbLingua.Name = "cbLingua";
            this.cbLingua.Size = new System.Drawing.Size(100, 23);
            this.cbLingua.TabIndex = 1;
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(16, 58);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(50, 19);
            this.lblLingua.TabIndex = 209;
            this.lblLingua.Text = "Lingua:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(16, 110);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 210;
            this.lblArea.Text = "Área:";
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(21, 28);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(128, 23);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 19);
            this.lblTitulo.TabIndex = 212;
            this.lblTitulo.Text = "Título:";
            // 
            // lblLocaliza
            // 
            this.lblLocaliza.AutoSize = true;
            this.lblLocaliza.Location = new System.Drawing.Point(169, 58);
            this.lblLocaliza.Name = "lblLocaliza";
            this.lblLocaliza.Size = new System.Drawing.Size(79, 19);
            this.lblLocaliza.TabIndex = 214;
            this.lblLocaliza.Text = "Localização:";
            // 
            // txtLocaliza
            // 
            // 
            // 
            // 
            this.txtLocaliza.CustomButton.Image = null;
            this.txtLocaliza.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.txtLocaliza.CustomButton.Name = "";
            this.txtLocaliza.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocaliza.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocaliza.CustomButton.TabIndex = 1;
            this.txtLocaliza.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocaliza.CustomButton.UseSelectable = true;
            this.txtLocaliza.CustomButton.Visible = false;
            this.txtLocaliza.Lines = new string[0];
            this.txtLocaliza.Location = new System.Drawing.Point(174, 80);
            this.txtLocaliza.MaxLength = 40;
            this.txtLocaliza.Name = "txtLocaliza";
            this.txtLocaliza.PasswordChar = '\0';
            this.txtLocaliza.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocaliza.SelectedText = "";
            this.txtLocaliza.SelectionLength = 0;
            this.txtLocaliza.SelectionStart = 0;
            this.txtLocaliza.ShortcutsEnabled = true;
            this.txtLocaliza.Size = new System.Drawing.Size(124, 23);
            this.txtLocaliza.TabIndex = 2;
            this.txtLocaliza.UseSelectable = true;
            this.txtLocaliza.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocaliza.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.SystemColors.Window;
            this.cbArea.DisplayMember = "Descricao";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(21, 132);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(142, 23);
            this.cbArea.TabIndex = 3;
            this.cbArea.ValueMember = "CodArea";
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // lblTipoTombo
            // 
            this.lblTipoTombo.AutoSize = true;
            this.lblTipoTombo.Location = new System.Drawing.Point(169, 110);
            this.lblTipoTombo.Name = "lblTipoTombo";
            this.lblTipoTombo.Size = new System.Drawing.Size(102, 19);
            this.lblTipoTombo.TabIndex = 202;
            this.lblTipoTombo.Text = "Tipo de Tombo:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 169);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(83, 19);
            this.lblObs.TabIndex = 217;
            this.lblObs.Text = "Observação:";
            // 
            // cbTipoTombo
            // 
            this.cbTipoTombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTombo.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbTipoTombo.FormattingEnabled = true;
            this.cbTipoTombo.Items.AddRange(new object[] {
            "Doação",
            "Compra",
            "Permuta"});
            this.cbTipoTombo.Location = new System.Drawing.Point(174, 132);
            this.cbTipoTombo.Name = "cbTipoTombo";
            this.cbTipoTombo.Size = new System.Drawing.Size(100, 23);
            this.cbTipoTombo.TabIndex = 4;
            // 
            // checkDisp
            // 
            this.checkDisp.AutoSize = true;
            this.checkDisp.Checked = true;
            this.checkDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisp.Location = new System.Drawing.Point(256, 159);
            this.checkDisp.Name = "checkDisp";
            this.checkDisp.Size = new System.Drawing.Size(15, 14);
            this.checkDisp.TabIndex = 219;
            this.checkDisp.TabStop = false;
            this.checkDisp.UseVisualStyleBackColor = true;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(169, 155);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(71, 19);
            this.lblDisp.TabIndex = 220;
            this.lblDisp.Text = "Disponível:";
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(169, 9);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(53, 19);
            this.lblTombo.TabIndex = 222;
            this.lblTombo.Text = "Tombo:";
            // 
            // txtTombo
            // 
            // 
            // 
            // 
            this.txtTombo.CustomButton.Image = null;
            this.txtTombo.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtTombo.CustomButton.Name = "";
            this.txtTombo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTombo.CustomButton.TabIndex = 1;
            this.txtTombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTombo.CustomButton.UseSelectable = true;
            this.txtTombo.CustomButton.Visible = false;
            this.txtTombo.Lines = new string[0];
            this.txtTombo.Location = new System.Drawing.Point(174, 28);
            this.txtTombo.MaxLength = 32767;
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.PasswordChar = '\0';
            this.txtTombo.ReadOnly = true;
            this.txtTombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTombo.SelectedText = "";
            this.txtTombo.SelectionLength = 0;
            this.txtTombo.SelectionStart = 0;
            this.txtTombo.ShortcutsEnabled = true;
            this.txtTombo.Size = new System.Drawing.Size(95, 23);
            this.txtTombo.TabIndex = 221;
            this.txtTombo.TabStop = false;
            this.txtTombo.UseSelectable = true;
            this.txtTombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmCadCdDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 345);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadCdDvd";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Cadastro: CD e DVD";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cbLingua;
        private MetroFramework.Controls.MetroLabel lblLingua;
        private MetroFramework.Controls.MetroLabel lblArea;
        private MetroFramework.Controls.MetroLabel lblLocaliza;
        private MetroFramework.Controls.MetroTextBox txtLocaliza;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroTextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbArea;
        private MetroFramework.Controls.MetroLabel lblObs;
        private MetroFramework.Controls.MetroLabel lblTipoTombo;
        private System.Windows.Forms.ComboBox cbTipoTombo;
        private System.Windows.Forms.CheckBox checkDisp;
        private MetroFramework.Controls.MetroLabel lblDisp;
        private MetroFramework.Controls.MetroLabel lblTombo;
        private MetroFramework.Controls.MetroTextBox txtTombo;
    }
}