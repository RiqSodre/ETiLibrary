﻿namespace Interface.Formularios.Cadastros
{
    partial class FrmCadJornalEx
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
            this.lblTombo = new MetroFramework.Controls.MetroLabel();
            this.txtTombo = new MetroFramework.Controls.MetroTextBox();
            this.checkDisp = new System.Windows.Forms.CheckBox();
            this.lblDisp = new MetroFramework.Controls.MetroLabel();
            this.cbTipoTombo = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new MetroFramework.Controls.MetroLabel();
            this.lblTipoTombo = new MetroFramework.Controls.MetroLabel();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.lblLocaliza = new MetroFramework.Controls.MetroLabel();
            this.txtLocaliza = new MetroFramework.Controls.MetroTextBox();
            this.lblManchete = new MetroFramework.Controls.MetroLabel();
            this.txtManchete = new MetroFramework.Controls.MetroTextBox();
            this.lblArea = new MetroFramework.Controls.MetroLabel();
            this.cbLingua = new System.Windows.Forms.ComboBox();
            this.lblLingua = new MetroFramework.Controls.MetroLabel();
            this.lblDataPublicacao = new MetroFramework.Controls.MetroLabel();
            this.dtDataPublicacao = new System.Windows.Forms.DateTimePicker();
            this.cbJornal = new System.Windows.Forms.ComboBox();
            this.lblJornal = new MetroFramework.Controls.MetroLabel();
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
            this.lblForm.Size = new System.Drawing.Size(106, 16);
            this.lblForm.Text = "Cadastro: Jornal";
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
            this.btnCancelar.Location = new System.Drawing.Point(241, 403);
            this.btnCancelar.TabIndex = 2;
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(149, 403);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.cbJornal);
            this.pnlPrincipal.Controls.Add(this.lblJornal);
            this.pnlPrincipal.Controls.Add(this.lblDataPublicacao);
            this.pnlPrincipal.Controls.Add(this.dtDataPublicacao);
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
            this.pnlPrincipal.Controls.Add(this.lblManchete);
            this.pnlPrincipal.Controls.Add(this.txtManchete);
            this.pnlPrincipal.Controls.Add(this.lblArea);
            this.pnlPrincipal.Controls.Add(this.cbLingua);
            this.pnlPrincipal.Controls.Add(this.lblLingua);
            this.pnlPrincipal.Size = new System.Drawing.Size(326, 323);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(169, 59);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(53, 19);
            this.lblTombo.TabIndex = 238;
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
            this.txtTombo.Location = new System.Drawing.Point(174, 78);
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
            this.txtTombo.TabIndex = 2;
            this.txtTombo.TabStop = false;
            this.txtTombo.UseSelectable = true;
            this.txtTombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkDisp
            // 
            this.checkDisp.AutoSize = true;
            this.checkDisp.Checked = true;
            this.checkDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisp.Location = new System.Drawing.Point(256, 209);
            this.checkDisp.Name = "checkDisp";
            this.checkDisp.Size = new System.Drawing.Size(15, 14);
            this.checkDisp.TabIndex = 235;
            this.checkDisp.TabStop = false;
            this.checkDisp.UseVisualStyleBackColor = true;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(169, 205);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(71, 19);
            this.lblDisp.TabIndex = 236;
            this.lblDisp.Text = "Disponivel:";
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
            this.cbTipoTombo.Location = new System.Drawing.Point(174, 182);
            this.cbTipoTombo.Name = "cbTipoTombo";
            this.cbTipoTombo.Size = new System.Drawing.Size(100, 23);
            this.cbTipoTombo.TabIndex = 6;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(21, 291);
            this.txtObs.MaxLength = 140;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(290, 25);
            this.txtObs.TabIndex = 8;
            this.txtObs.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 269);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(83, 19);
            this.lblObs.TabIndex = 234;
            this.lblObs.Text = "Observação:";
            // 
            // lblTipoTombo
            // 
            this.lblTipoTombo.AutoSize = true;
            this.lblTipoTombo.Location = new System.Drawing.Point(169, 160);
            this.lblTipoTombo.Name = "lblTipoTombo";
            this.lblTipoTombo.Size = new System.Drawing.Size(102, 19);
            this.lblTipoTombo.TabIndex = 229;
            this.lblTipoTombo.Text = "Tipo de Tombo:";
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.SystemColors.Window;
            this.cbArea.DisplayMember = "Descricao";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(21, 182);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(142, 23);
            this.cbArea.TabIndex = 5;
            this.cbArea.ValueMember = "CodArea";
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // lblLocaliza
            // 
            this.lblLocaliza.AutoSize = true;
            this.lblLocaliza.Location = new System.Drawing.Point(169, 108);
            this.lblLocaliza.Name = "lblLocaliza";
            this.lblLocaliza.Size = new System.Drawing.Size(79, 19);
            this.lblLocaliza.TabIndex = 233;
            this.lblLocaliza.Text = "Localização:";
            // 
            // txtLocaliza
            // 
            // 
            // 
            // 
            this.txtLocaliza.CustomButton.Image = null;
            this.txtLocaliza.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtLocaliza.CustomButton.Name = "";
            this.txtLocaliza.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocaliza.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocaliza.CustomButton.TabIndex = 1;
            this.txtLocaliza.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocaliza.CustomButton.UseSelectable = true;
            this.txtLocaliza.CustomButton.Visible = false;
            this.txtLocaliza.Lines = new string[0];
            this.txtLocaliza.Location = new System.Drawing.Point(174, 130);
            this.txtLocaliza.MaxLength = 40;
            this.txtLocaliza.Name = "txtLocaliza";
            this.txtLocaliza.PasswordChar = '\0';
            this.txtLocaliza.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocaliza.SelectedText = "";
            this.txtLocaliza.SelectionLength = 0;
            this.txtLocaliza.SelectionStart = 0;
            this.txtLocaliza.ShortcutsEnabled = true;
            this.txtLocaliza.Size = new System.Drawing.Size(123, 23);
            this.txtLocaliza.TabIndex = 4;
            this.txtLocaliza.UseSelectable = true;
            this.txtLocaliza.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocaliza.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblManchete
            // 
            this.lblManchete.AutoSize = true;
            this.lblManchete.Location = new System.Drawing.Point(16, 6);
            this.lblManchete.Name = "lblManchete";
            this.lblManchete.Size = new System.Drawing.Size(69, 19);
            this.lblManchete.TabIndex = 232;
            this.lblManchete.Text = "Manchete:";
            // 
            // txtManchete
            // 
            // 
            // 
            // 
            this.txtManchete.CustomButton.Image = null;
            this.txtManchete.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtManchete.CustomButton.Name = "";
            this.txtManchete.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManchete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManchete.CustomButton.TabIndex = 1;
            this.txtManchete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManchete.CustomButton.UseSelectable = true;
            this.txtManchete.CustomButton.Visible = false;
            this.txtManchete.Lines = new string[0];
            this.txtManchete.Location = new System.Drawing.Point(21, 28);
            this.txtManchete.MaxLength = 150;
            this.txtManchete.Name = "txtManchete";
            this.txtManchete.PasswordChar = '\0';
            this.txtManchete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManchete.SelectedText = "";
            this.txtManchete.SelectionLength = 0;
            this.txtManchete.SelectionStart = 0;
            this.txtManchete.ShortcutsEnabled = true;
            this.txtManchete.Size = new System.Drawing.Size(290, 23);
            this.txtManchete.TabIndex = 0;
            this.txtManchete.UseSelectable = true;
            this.txtManchete.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManchete.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(16, 160);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 231;
            this.lblArea.Text = "Área:";
            // 
            // cbLingua
            // 
            this.cbLingua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLingua.Font = new System.Drawing.Font("Calibri", 9.75F);
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
            this.cbLingua.Location = new System.Drawing.Point(21, 130);
            this.cbLingua.Name = "cbLingua";
            this.cbLingua.Size = new System.Drawing.Size(100, 23);
            this.cbLingua.TabIndex = 3;
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(16, 108);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(50, 19);
            this.lblLingua.TabIndex = 230;
            this.lblLingua.Text = "Lingua:";
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Location = new System.Drawing.Point(16, 59);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(125, 19);
            this.lblDataPublicacao.TabIndex = 240;
            this.lblDataPublicacao.Text = "Data de Publicação:";
            // 
            // dtDataPublicacao
            // 
            this.dtDataPublicacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPublicacao.Location = new System.Drawing.Point(21, 78);
            this.dtDataPublicacao.Name = "dtDataPublicacao";
            this.dtDataPublicacao.Size = new System.Drawing.Size(123, 23);
            this.dtDataPublicacao.TabIndex = 1;
            // 
            // cbJornal
            // 
            this.cbJornal.DisplayMember = "Nome";
            this.cbJornal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJornal.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbJornal.FormattingEnabled = true;
            this.cbJornal.Items.AddRange(new object[] {
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
            this.cbJornal.Location = new System.Drawing.Point(21, 234);
            this.cbJornal.Name = "cbJornal";
            this.cbJornal.Size = new System.Drawing.Size(100, 23);
            this.cbJornal.TabIndex = 7;
            this.cbJornal.ValueMember = "CodJornal";
            this.cbJornal.SelectedIndexChanged += new System.EventHandler(this.cbJornal_SelectedIndexChanged);
            // 
            // lblJornal
            // 
            this.lblJornal.AutoSize = true;
            this.lblJornal.Location = new System.Drawing.Point(16, 212);
            this.lblJornal.Name = "lblJornal";
            this.lblJornal.Size = new System.Drawing.Size(47, 19);
            this.lblJornal.TabIndex = 242;
            this.lblJornal.Text = "Jornal:";
            // 
            // FrmCadJornalEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 448);
            this.Name = "FrmCadJornalEx";
            this.Text = "Cadastro: Jornal";
            this.Click += new System.EventHandler(this.txtObs_Focus);
            this.Leave += new System.EventHandler(this.txtObservacao_Leave);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTombo;
        private MetroFramework.Controls.MetroTextBox txtTombo;
        private System.Windows.Forms.CheckBox checkDisp;
        private MetroFramework.Controls.MetroLabel lblDisp;
        private System.Windows.Forms.ComboBox cbTipoTombo;
        private System.Windows.Forms.TextBox txtObs;
        private MetroFramework.Controls.MetroLabel lblObs;
        private MetroFramework.Controls.MetroLabel lblTipoTombo;
        private System.Windows.Forms.ComboBox cbArea;
        private MetroFramework.Controls.MetroLabel lblLocaliza;
        private MetroFramework.Controls.MetroTextBox txtLocaliza;
        private MetroFramework.Controls.MetroLabel lblManchete;
        private MetroFramework.Controls.MetroTextBox txtManchete;
        private MetroFramework.Controls.MetroLabel lblArea;
        private System.Windows.Forms.ComboBox cbLingua;
        private MetroFramework.Controls.MetroLabel lblLingua;
        private MetroFramework.Controls.MetroLabel lblDataPublicacao;
        private System.Windows.Forms.DateTimePicker dtDataPublicacao;
        private System.Windows.Forms.ComboBox cbJornal;
        private MetroFramework.Controls.MetroLabel lblJornal;
    }
}