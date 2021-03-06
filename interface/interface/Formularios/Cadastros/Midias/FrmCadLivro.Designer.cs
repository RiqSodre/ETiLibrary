﻿namespace Interface.Formularios.Cadastros
{
    partial class FrmCadLivro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadLivro));
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtEdicao = new MetroFramework.Controls.MetroTextBox();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.txtColecao = new MetroFramework.Controls.MetroTextBox();
            this.txtLocal = new MetroFramework.Controls.MetroTextBox();
            this.txtNPags = new MetroFramework.Controls.MetroTextBox();
            this.txtVolume = new MetroFramework.Controls.MetroTextBox();
            this.txtSubtitulo = new MetroFramework.Controls.MetroTextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.dtDataPublicacao = new System.Windows.Forms.DateTimePicker();
            this.cbAssunto = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.dataGridAssuntos = new MetroFramework.Controls.MetroGrid();
            this.clnCodAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridGeneros = new MetroFramework.Controls.MetroGrid();
            this.clnCodGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAutores = new MetroFramework.Controls.MetroGrid();
            this.clnCodAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGAdd = new MetroFramework.Controls.MetroButton();
            this.btnGRemover = new MetroFramework.Controls.MetroButton();
            this.btnAutRemover = new MetroFramework.Controls.MetroButton();
            this.btnAutAdd = new MetroFramework.Controls.MetroButton();
            this.btnAssRemover = new MetroFramework.Controls.MetroButton();
            this.btnAssAdd = new MetroFramework.Controls.MetroButton();
            this.cbTipoLivro = new System.Windows.Forms.ComboBox();
            this.cbTipoTombo = new System.Windows.Forms.ComboBox();
            this.txtTombo = new MetroFramework.Controls.MetroTextBox();
            this.timerCbAutor = new System.Windows.Forms.Timer(this.components);
            this.timerCbGenero = new System.Windows.Forms.Timer(this.components);
            this.timerCbAssunto = new System.Windows.Forms.Timer(this.components);
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.lblVolume = new MetroFramework.Controls.MetroLabel();
            this.lblLocal = new MetroFramework.Controls.MetroLabel();
            this.lblValor = new MetroFramework.Controls.MetroLabel();
            this.lblGenero = new MetroFramework.Controls.MetroLabel();
            this.lblAutor = new MetroFramework.Controls.MetroLabel();
            this.lblSubtitulo = new MetroFramework.Controls.MetroLabel();
            this.lblEdicao = new MetroFramework.Controls.MetroLabel();
            this.lblNPags = new MetroFramework.Controls.MetroLabel();
            this.lblTipoLivro = new MetroFramework.Controls.MetroLabel();
            this.lblObs = new MetroFramework.Controls.MetroLabel();
            this.lblAssunto = new MetroFramework.Controls.MetroLabel();
            this.lblColecao = new MetroFramework.Controls.MetroLabel();
            this.lblDataPublicacao = new MetroFramework.Controls.MetroLabel();
            this.lblTombo = new MetroFramework.Controls.MetroLabel();
            this.lblTipoTombo = new MetroFramework.Controls.MetroLabel();
            this.lblEditora = new MetroFramework.Controls.MetroLabel();
            this.lblArea = new MetroFramework.Controls.MetroLabel();
            this.lblDisp = new MetroFramework.Controls.MetroLabel();
            this.lblLingua = new MetroFramework.Controls.MetroLabel();
            this.lblLocaliza = new MetroFramework.Controls.MetroLabel();
            this.cbLingua = new System.Windows.Forms.ComboBox();
            this.txtLocaliza = new MetroFramework.Controls.MetroTextBox();
            this.checkDisp = new System.Windows.Forms.CheckBox();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Margin = new System.Windows.Forms.Padding(4);
            this.pnl.Size = new System.Drawing.Size(765, 26);
            this.pnl.TabIndex = 3;
            // 
            // lblForm
            // 
            this.lblForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForm.Size = new System.Drawing.Size(98, 16);
            this.lblForm.Text = "Cadastro: Livro";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Location = new System.Drawing.Point(722, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.TabIndex = 0;
            // 
            // pnlBase
            // 
            this.pnlBase.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBase.Size = new System.Drawing.Size(760, 36);
            this.pnlBase.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(423, -3);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(335, -3);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(247, -3);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 434);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.TabIndex = 2;
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(565, 434);
            this.btnAcao.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.checkDisp);
            this.pnlPrincipal.Controls.Add(this.txtLocaliza);
            this.pnlPrincipal.Controls.Add(this.cbLingua);
            this.pnlPrincipal.Controls.Add(this.lblLocaliza);
            this.pnlPrincipal.Controls.Add(this.lblLingua);
            this.pnlPrincipal.Controls.Add(this.lblDisp);
            this.pnlPrincipal.Controls.Add(this.lblArea);
            this.pnlPrincipal.Controls.Add(this.lblEditora);
            this.pnlPrincipal.Controls.Add(this.lblTipoTombo);
            this.pnlPrincipal.Controls.Add(this.lblTombo);
            this.pnlPrincipal.Controls.Add(this.lblDataPublicacao);
            this.pnlPrincipal.Controls.Add(this.lblColecao);
            this.pnlPrincipal.Controls.Add(this.txtTitulo);
            this.pnlPrincipal.Controls.Add(this.lblAssunto);
            this.pnlPrincipal.Controls.Add(this.txtSubtitulo);
            this.pnlPrincipal.Controls.Add(this.lblObs);
            this.pnlPrincipal.Controls.Add(this.lblTipoLivro);
            this.pnlPrincipal.Controls.Add(this.lblNPags);
            this.pnlPrincipal.Controls.Add(this.lblEdicao);
            this.pnlPrincipal.Controls.Add(this.lblSubtitulo);
            this.pnlPrincipal.Controls.Add(this.lblAutor);
            this.pnlPrincipal.Controls.Add(this.lblGenero);
            this.pnlPrincipal.Controls.Add(this.lblValor);
            this.pnlPrincipal.Controls.Add(this.lblLocal);
            this.pnlPrincipal.Controls.Add(this.lblVolume);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Controls.Add(this.txtValor);
            this.pnlPrincipal.Controls.Add(this.txtTombo);
            this.pnlPrincipal.Controls.Add(this.cbTipoTombo);
            this.pnlPrincipal.Controls.Add(this.cbTipoLivro);
            this.pnlPrincipal.Controls.Add(this.btnAssRemover);
            this.pnlPrincipal.Controls.Add(this.btnAssAdd);
            this.pnlPrincipal.Controls.Add(this.btnAutRemover);
            this.pnlPrincipal.Controls.Add(this.btnAutAdd);
            this.pnlPrincipal.Controls.Add(this.btnGRemover);
            this.pnlPrincipal.Controls.Add(this.btnGAdd);
            this.pnlPrincipal.Controls.Add(this.dataGridAutores);
            this.pnlPrincipal.Controls.Add(this.dataGridGeneros);
            this.pnlPrincipal.Controls.Add(this.dataGridAssuntos);
            this.pnlPrincipal.Controls.Add(this.txtObs);
            this.pnlPrincipal.Controls.Add(this.cbAutor);
            this.pnlPrincipal.Controls.Add(this.cbGenero);
            this.pnlPrincipal.Controls.Add(this.txtNPags);
            this.pnlPrincipal.Controls.Add(this.dtDataPublicacao);
            this.pnlPrincipal.Controls.Add(this.cbAssunto);
            this.pnlPrincipal.Controls.Add(this.cbArea);
            this.pnlPrincipal.Controls.Add(this.cbEditora);
            this.pnlPrincipal.Controls.Add(this.txtLocal);
            this.pnlPrincipal.Controls.Add(this.txtEdicao);
            this.pnlPrincipal.Controls.Add(this.txtVolume);
            this.pnlPrincipal.Controls.Add(this.txtColecao);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Size = new System.Drawing.Size(732, 357);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtObs.Location = new System.Drawing.Point(275, 159);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(198, 77);
            this.txtObs.TabIndex = 24;
            // 
            // txtEdicao
            // 
            // 
            // 
            // 
            this.txtEdicao.CustomButton.Image = null;
            this.txtEdicao.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtEdicao.CustomButton.Name = "";
            this.txtEdicao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEdicao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdicao.CustomButton.TabIndex = 1;
            this.txtEdicao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdicao.CustomButton.UseSelectable = true;
            this.txtEdicao.CustomButton.Visible = false;
            this.txtEdicao.Lines = new string[0];
            this.txtEdicao.Location = new System.Drawing.Point(308, 42);
            this.txtEdicao.MaxLength = 32767;
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.PasswordChar = '\0';
            this.txtEdicao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdicao.SelectedText = "";
            this.txtEdicao.SelectionLength = 0;
            this.txtEdicao.SelectionStart = 0;
            this.txtEdicao.ShortcutsEnabled = true;
            this.txtEdicao.Size = new System.Drawing.Size(123, 23);
            this.txtEdicao.TabIndex = 4;
            this.txtEdicao.UseSelectable = true;
            this.txtEdicao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdicao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdicao.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(82, 11);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(146, 23);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitulo.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // txtColecao
            // 
            // 
            // 
            // 
            this.txtColecao.CustomButton.Image = null;
            this.txtColecao.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtColecao.CustomButton.Name = "";
            this.txtColecao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtColecao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColecao.CustomButton.TabIndex = 1;
            this.txtColecao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColecao.CustomButton.UseSelectable = true;
            this.txtColecao.CustomButton.Visible = false;
            this.txtColecao.Lines = new string[0];
            this.txtColecao.Location = new System.Drawing.Point(570, 71);
            this.txtColecao.MaxLength = 32767;
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.PasswordChar = '\0';
            this.txtColecao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColecao.SelectedText = "";
            this.txtColecao.SelectionLength = 0;
            this.txtColecao.SelectionStart = 0;
            this.txtColecao.ShortcutsEnabled = true;
            this.txtColecao.Size = new System.Drawing.Size(95, 23);
            this.txtColecao.TabIndex = 8;
            this.txtColecao.UseSelectable = true;
            this.txtColecao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColecao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtColecao.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // txtLocal
            // 
            // 
            // 
            // 
            this.txtLocal.CustomButton.Image = null;
            this.txtLocal.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtLocal.CustomButton.Name = "";
            this.txtLocal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocal.CustomButton.TabIndex = 1;
            this.txtLocal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocal.CustomButton.UseSelectable = true;
            this.txtLocal.CustomButton.Visible = false;
            this.txtLocal.Lines = new string[0];
            this.txtLocal.Location = new System.Drawing.Point(82, 71);
            this.txtLocal.MaxLength = 32767;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PasswordChar = '\0';
            this.txtLocal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocal.SelectedText = "";
            this.txtLocal.SelectionLength = 0;
            this.txtLocal.SelectionStart = 0;
            this.txtLocal.ShortcutsEnabled = true;
            this.txtLocal.Size = new System.Drawing.Size(95, 23);
            this.txtLocal.TabIndex = 6;
            this.txtLocal.UseSelectable = true;
            this.txtLocal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocal_KeyPress);
            // 
            // txtNPags
            // 
            // 
            // 
            // 
            this.txtNPags.CustomButton.Image = null;
            this.txtNPags.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtNPags.CustomButton.Name = "";
            this.txtNPags.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNPags.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNPags.CustomButton.TabIndex = 1;
            this.txtNPags.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNPags.CustomButton.UseSelectable = true;
            this.txtNPags.CustomButton.Visible = false;
            this.txtNPags.Lines = new string[0];
            this.txtNPags.Location = new System.Drawing.Point(308, 71);
            this.txtNPags.MaxLength = 32767;
            this.txtNPags.Name = "txtNPags";
            this.txtNPags.PasswordChar = '\0';
            this.txtNPags.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNPags.SelectedText = "";
            this.txtNPags.SelectionLength = 0;
            this.txtNPags.SelectionStart = 0;
            this.txtNPags.ShortcutsEnabled = true;
            this.txtNPags.Size = new System.Drawing.Size(94, 23);
            this.txtNPags.TabIndex = 7;
            this.txtNPags.UseSelectable = true;
            this.txtNPags.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNPags.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNPags.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNdePaginas_KeyPress);
            // 
            // txtVolume
            // 
            // 
            // 
            // 
            this.txtVolume.CustomButton.Image = null;
            this.txtVolume.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtVolume.CustomButton.Name = "";
            this.txtVolume.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVolume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVolume.CustomButton.TabIndex = 1;
            this.txtVolume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVolume.CustomButton.UseSelectable = true;
            this.txtVolume.CustomButton.Visible = false;
            this.txtVolume.Lines = new string[0];
            this.txtVolume.Location = new System.Drawing.Point(82, 42);
            this.txtVolume.MaxLength = 32767;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.PasswordChar = '\0';
            this.txtVolume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVolume.SelectedText = "";
            this.txtVolume.SelectionLength = 0;
            this.txtVolume.SelectionStart = 0;
            this.txtVolume.ShortcutsEnabled = true;
            this.txtVolume.Size = new System.Drawing.Size(95, 23);
            this.txtVolume.TabIndex = 3;
            this.txtVolume.UseSelectable = true;
            this.txtVolume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVolume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubtitulo
            // 
            // 
            // 
            // 
            this.txtSubtitulo.CustomButton.Image = null;
            this.txtSubtitulo.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtSubtitulo.CustomButton.Name = "";
            this.txtSubtitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubtitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubtitulo.CustomButton.TabIndex = 1;
            this.txtSubtitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtitulo.CustomButton.UseSelectable = true;
            this.txtSubtitulo.CustomButton.Visible = false;
            this.txtSubtitulo.Lines = new string[0];
            this.txtSubtitulo.Location = new System.Drawing.Point(308, 11);
            this.txtSubtitulo.MaxLength = 32767;
            this.txtSubtitulo.Name = "txtSubtitulo";
            this.txtSubtitulo.PasswordChar = '\0';
            this.txtSubtitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtitulo.SelectedText = "";
            this.txtSubtitulo.SelectionLength = 0;
            this.txtSubtitulo.SelectionStart = 0;
            this.txtSubtitulo.ShortcutsEnabled = true;
            this.txtSubtitulo.Size = new System.Drawing.Size(123, 23);
            this.txtSubtitulo.TabIndex = 1;
            this.txtSubtitulo.UseSelectable = true;
            this.txtSubtitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubtitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubtitulo.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(82, 131);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(130, 23);
            this.cbGenero.TabIndex = 12;
            this.cbGenero.Text = "Digite o gênero";
            this.cbGenero.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            this.cbGenero.Leave += new System.EventHandler(this.cbGenero_Leave);
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.SystemColors.Window;
            this.cbArea.DisplayMember = "Descricao";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(541, 220);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(123, 23);
            this.cbArea.TabIndex = 28;
            this.cbArea.ValueMember = "CodArea";
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // cbEditora
            // 
            this.cbEditora.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(542, 188);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(122, 23);
            this.cbEditora.TabIndex = 27;
            this.cbEditora.Text = "Digite a editora";
            // 
            // dtDataPublicacao
            // 
            this.dtDataPublicacao.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataPublicacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPublicacao.Location = new System.Drawing.Point(576, 43);
            this.dtDataPublicacao.Name = "dtDataPublicacao";
            this.dtDataPublicacao.Size = new System.Drawing.Size(88, 23);
            this.dtDataPublicacao.TabIndex = 5;
            // 
            // cbAssunto
            // 
            this.cbAssunto.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbAssunto.FormattingEnabled = true;
            this.cbAssunto.Location = new System.Drawing.Point(308, 247);
            this.cbAssunto.Name = "cbAssunto";
            this.cbAssunto.Size = new System.Drawing.Size(130, 23);
            this.cbAssunto.TabIndex = 20;
            this.cbAssunto.Text = "Digite o assunto";
            this.cbAssunto.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            this.cbAssunto.Leave += new System.EventHandler(this.cbAssunto_Leave);
            // 
            // cbAutor
            // 
            this.cbAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbAutor.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(82, 247);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(147, 23);
            this.cbAutor.TabIndex = 16;
            this.cbAutor.Text = "Digite o nome do autor";
            this.cbAutor.TextChanged += new System.EventHandler(this.exibe_TextChanged);
            this.cbAutor.Leave += new System.EventHandler(this.cbAutor_Leave);
            // 
            // dataGridAssuntos
            // 
            this.dataGridAssuntos.AllowUserToAddRows = false;
            this.dataGridAssuntos.AllowUserToDeleteRows = false;
            this.dataGridAssuntos.AllowUserToResizeColumns = false;
            this.dataGridAssuntos.AllowUserToResizeRows = false;
            this.dataGridAssuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAssuntos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridAssuntos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridAssuntos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAssuntos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAssuntos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAssuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridAssuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodAssunto,
            this.clnAssunto});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAssuntos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridAssuntos.EnableHeadersVisualStyles = false;
            this.dataGridAssuntos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridAssuntos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridAssuntos.Location = new System.Drawing.Point(274, 274);
            this.dataGridAssuntos.MultiSelect = false;
            this.dataGridAssuntos.Name = "dataGridAssuntos";
            this.dataGridAssuntos.ReadOnly = true;
            this.dataGridAssuntos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAssuntos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridAssuntos.RowHeadersVisible = false;
            this.dataGridAssuntos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAssuntos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridAssuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAssuntos.Size = new System.Drawing.Size(196, 77);
            this.dataGridAssuntos.TabIndex = 22;
            // 
            // clnCodAssunto
            // 
            this.clnCodAssunto.HeaderText = "Cod";
            this.clnCodAssunto.Name = "clnCodAssunto";
            this.clnCodAssunto.ReadOnly = true;
            this.clnCodAssunto.Visible = false;
            // 
            // clnAssunto
            // 
            this.clnAssunto.HeaderText = "Assuntos";
            this.clnAssunto.Name = "clnAssunto";
            this.clnAssunto.ReadOnly = true;
            this.clnAssunto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridGeneros
            // 
            this.dataGridGeneros.AllowUserToAddRows = false;
            this.dataGridGeneros.AllowUserToDeleteRows = false;
            this.dataGridGeneros.AllowUserToResizeColumns = false;
            this.dataGridGeneros.AllowUserToResizeRows = false;
            this.dataGridGeneros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGeneros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridGeneros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridGeneros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGeneros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridGeneros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGeneros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodGenero,
            this.clnGenero});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGeneros.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridGeneros.EnableHeadersVisualStyles = false;
            this.dataGridGeneros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridGeneros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridGeneros.Location = new System.Drawing.Point(32, 159);
            this.dataGridGeneros.MultiSelect = false;
            this.dataGridGeneros.Name = "dataGridGeneros";
            this.dataGridGeneros.ReadOnly = true;
            this.dataGridGeneros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGeneros.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridGeneros.RowHeadersVisible = false;
            this.dataGridGeneros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridGeneros.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridGeneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGeneros.Size = new System.Drawing.Size(196, 77);
            this.dataGridGeneros.TabIndex = 14;
            // 
            // clnCodGenero
            // 
            this.clnCodGenero.HeaderText = "Cod";
            this.clnCodGenero.Name = "clnCodGenero";
            this.clnCodGenero.ReadOnly = true;
            this.clnCodGenero.Visible = false;
            // 
            // clnGenero
            // 
            this.clnGenero.HeaderText = "Gêneros";
            this.clnGenero.Name = "clnGenero";
            this.clnGenero.ReadOnly = true;
            this.clnGenero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridAutores
            // 
            this.dataGridAutores.AllowUserToAddRows = false;
            this.dataGridAutores.AllowUserToDeleteRows = false;
            this.dataGridAutores.AllowUserToResizeColumns = false;
            this.dataGridAutores.AllowUserToResizeRows = false;
            this.dataGridAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAutores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridAutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridAutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAutores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodAutor,
            this.clnAutor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAutores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAutores.EnableHeadersVisualStyles = false;
            this.dataGridAutores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridAutores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridAutores.Location = new System.Drawing.Point(32, 274);
            this.dataGridAutores.MultiSelect = false;
            this.dataGridAutores.Name = "dataGridAutores";
            this.dataGridAutores.ReadOnly = true;
            this.dataGridAutores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAutores.RowHeadersVisible = false;
            this.dataGridAutores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAutores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAutores.Size = new System.Drawing.Size(196, 77);
            this.dataGridAutores.TabIndex = 18;
            // 
            // clnCodAutor
            // 
            this.clnCodAutor.HeaderText = "Cod";
            this.clnCodAutor.Name = "clnCodAutor";
            this.clnCodAutor.ReadOnly = true;
            this.clnCodAutor.Visible = false;
            // 
            // clnAutor
            // 
            this.clnAutor.HeaderText = "Autores";
            this.clnAutor.Name = "clnAutor";
            this.clnAutor.ReadOnly = true;
            this.clnAutor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnGAdd
            // 
            this.btnGAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnGAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGAdd.BackgroundImage")));
            this.btnGAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGAdd.Location = new System.Drawing.Point(232, 159);
            this.btnGAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnGAdd.Name = "btnGAdd";
            this.btnGAdd.Size = new System.Drawing.Size(35, 35);
            this.btnGAdd.TabIndex = 13;
            this.btnGAdd.UseSelectable = true;
            this.btnGAdd.Click += new System.EventHandler(this.btnGeneroAdd_Click);
            // 
            // btnGRemover
            // 
            this.btnGRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGRemover.BackgroundImage")));
            this.btnGRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGRemover.Location = new System.Drawing.Point(232, 201);
            this.btnGRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnGRemover.Name = "btnGRemover";
            this.btnGRemover.Size = new System.Drawing.Size(35, 35);
            this.btnGRemover.TabIndex = 15;
            this.btnGRemover.UseSelectable = true;
            this.btnGRemover.Click += new System.EventHandler(this.btnGeneroRemover_Click);
            // 
            // btnAutRemover
            // 
            this.btnAutRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutRemover.BackgroundImage")));
            this.btnAutRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAutRemover.Location = new System.Drawing.Point(232, 316);
            this.btnAutRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutRemover.Name = "btnAutRemover";
            this.btnAutRemover.Size = new System.Drawing.Size(35, 35);
            this.btnAutRemover.TabIndex = 19;
            this.btnAutRemover.UseSelectable = true;
            this.btnAutRemover.Click += new System.EventHandler(this.btnAutoresRemover_Click);
            // 
            // btnAutAdd
            // 
            this.btnAutAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutAdd.BackgroundImage")));
            this.btnAutAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAutAdd.Location = new System.Drawing.Point(232, 274);
            this.btnAutAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutAdd.Name = "btnAutAdd";
            this.btnAutAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAutAdd.TabIndex = 17;
            this.btnAutAdd.UseSelectable = true;
            this.btnAutAdd.Click += new System.EventHandler(this.btnAutoresAdd_Click);
            // 
            // btnAssRemover
            // 
            this.btnAssRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssRemover.BackgroundImage")));
            this.btnAssRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAssRemover.Location = new System.Drawing.Point(474, 316);
            this.btnAssRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnAssRemover.Name = "btnAssRemover";
            this.btnAssRemover.Size = new System.Drawing.Size(35, 35);
            this.btnAssRemover.TabIndex = 23;
            this.btnAssRemover.UseSelectable = true;
            this.btnAssRemover.Click += new System.EventHandler(this.btnAssuntosRemover_Click);
            // 
            // btnAssAdd
            // 
            this.btnAssAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssAdd.BackgroundImage")));
            this.btnAssAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAssAdd.Location = new System.Drawing.Point(474, 274);
            this.btnAssAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAssAdd.Name = "btnAssAdd";
            this.btnAssAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAssAdd.TabIndex = 21;
            this.btnAssAdd.UseSelectable = true;
            this.btnAssAdd.Click += new System.EventHandler(this.btnAssuntosAdd_Click);
            // 
            // cbTipoLivro
            // 
            this.cbTipoLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLivro.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbTipoLivro.FormattingEnabled = true;
            this.cbTipoLivro.Items.AddRange(new object[] {
            "Técnico",
            "Literatura",
            "Didático",
            "Braile"});
            this.cbTipoLivro.Location = new System.Drawing.Point(308, 104);
            this.cbTipoLivro.Name = "cbTipoLivro";
            this.cbTipoLivro.Size = new System.Drawing.Size(123, 23);
            this.cbTipoLivro.TabIndex = 10;
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
            this.cbTipoTombo.Location = new System.Drawing.Point(541, 104);
            this.cbTipoTombo.Name = "cbTipoTombo";
            this.cbTipoTombo.Size = new System.Drawing.Size(123, 23);
            this.cbTipoTombo.TabIndex = 11;
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
            this.txtTombo.Location = new System.Drawing.Point(570, 11);
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
            // timerCbAutor
            // 
            this.timerCbAutor.Interval = 10000;
            this.timerCbAutor.Tick += new System.EventHandler(this.timerCbAutor_Tick);
            // 
            // timerCbGenero
            // 
            this.timerCbGenero.Interval = 10000;
            this.timerCbGenero.Tick += new System.EventHandler(this.timerCbGenero_Tick);
            // 
            // timerCbAssunto
            // 
            this.timerCbAssunto.Interval = 10000;
            this.timerCbAssunto.Tick += new System.EventHandler(this.timerCbAssunto_Tick);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[] {
        "R$ 00,00"};
            this.txtValor.Location = new System.Drawing.Point(82, 103);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(95, 23);
            this.txtValor.TabIndex = 9;
            this.txtValor.Text = "R$ 00,00";
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 19);
            this.lblTitulo.TabIndex = 188;
            this.lblTitulo.Text = "Título:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(21, 44);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(56, 19);
            this.lblVolume.TabIndex = 189;
            this.lblVolume.Text = "Volume:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(21, 73);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(42, 19);
            this.lblLocal.TabIndex = 190;
            this.lblLocal.Text = "Local:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(21, 105);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 19);
            this.lblValor.TabIndex = 191;
            this.lblValor.Text = "Valor:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 132);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(55, 19);
            this.lblGenero.TabIndex = 192;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(21, 248);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(46, 19);
            this.lblAutor.TabIndex = 193;
            this.lblAutor.Text = "Autor:";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(239, 13);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(63, 19);
            this.lblSubtitulo.TabIndex = 194;
            this.lblSubtitulo.Text = "Subtitulo:";
            // 
            // lblEdicao
            // 
            this.lblEdicao.AutoSize = true;
            this.lblEdicao.Location = new System.Drawing.Point(239, 44);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(51, 19);
            this.lblEdicao.TabIndex = 195;
            this.lblEdicao.Text = "Edição:";
            // 
            // lblNPags
            // 
            this.lblNPags.AutoSize = true;
            this.lblNPags.Location = new System.Drawing.Point(208, 73);
            this.lblNPags.Name = "lblNPags";
            this.lblNPags.Size = new System.Drawing.Size(95, 19);
            this.lblNPags.TabIndex = 196;
            this.lblNPags.Text = "Nº de Páginas:";
            // 
            // lblTipoLivro
            // 
            this.lblTipoLivro.AutoSize = true;
            this.lblTipoLivro.Location = new System.Drawing.Point(206, 105);
            this.lblTipoLivro.Name = "lblTipoLivro";
            this.lblTipoLivro.Size = new System.Drawing.Size(90, 19);
            this.lblTipoLivro.TabIndex = 197;
            this.lblTipoLivro.Text = "Tipo do Livro:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(274, 132);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(83, 19);
            this.lblObs.TabIndex = 198;
            this.lblObs.Text = "Observação:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(251, 248);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(57, 19);
            this.lblAssunto.TabIndex = 199;
            this.lblAssunto.Text = "Assunto:";
            // 
            // lblColecao
            // 
            this.lblColecao.AutoSize = true;
            this.lblColecao.Location = new System.Drawing.Point(502, 73);
            this.lblColecao.Name = "lblColecao";
            this.lblColecao.Size = new System.Drawing.Size(60, 19);
            this.lblColecao.TabIndex = 200;
            this.lblColecao.Text = "Coleção:";
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Location = new System.Drawing.Point(445, 44);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(125, 19);
            this.lblDataPublicacao.TabIndex = 201;
            this.lblDataPublicacao.Text = "Data de Publicação:";
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(502, 13);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(53, 19);
            this.lblTombo.TabIndex = 202;
            this.lblTombo.Text = "Tombo:";
            // 
            // lblTipoTombo
            // 
            this.lblTipoTombo.AutoSize = true;
            this.lblTipoTombo.Location = new System.Drawing.Point(437, 105);
            this.lblTipoTombo.Name = "lblTipoTombo";
            this.lblTipoTombo.Size = new System.Drawing.Size(102, 19);
            this.lblTipoTombo.TabIndex = 203;
            this.lblTipoTombo.Text = "Tipo de Tombo:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(485, 189);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(54, 19);
            this.lblEditora.TabIndex = 204;
            this.lblEditora.Text = "Editora:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(495, 221);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 205;
            this.lblArea.Text = "Area:";
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(540, 248);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(71, 19);
            this.lblDisp.TabIndex = 206;
            this.lblDisp.Text = "Disponível:";
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(485, 159);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(50, 19);
            this.lblLingua.TabIndex = 207;
            this.lblLingua.Text = "Lingua:";
            // 
            // lblLocaliza
            // 
            this.lblLocaliza.AutoSize = true;
            this.lblLocaliza.Location = new System.Drawing.Point(456, 132);
            this.lblLocaliza.Name = "lblLocaliza";
            this.lblLocaliza.Size = new System.Drawing.Size(79, 19);
            this.lblLocaliza.TabIndex = 208;
            this.lblLocaliza.Text = "Localização:";
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
            this.cbLingua.Location = new System.Drawing.Point(541, 159);
            this.cbLingua.Name = "cbLingua";
            this.cbLingua.Size = new System.Drawing.Size(123, 23);
            this.cbLingua.TabIndex = 26;
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
            this.txtLocaliza.Location = new System.Drawing.Point(541, 132);
            this.txtLocaliza.MaxLength = 32767;
            this.txtLocaliza.Name = "txtLocaliza";
            this.txtLocaliza.PasswordChar = '\0';
            this.txtLocaliza.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocaliza.SelectedText = "";
            this.txtLocaliza.SelectionLength = 0;
            this.txtLocaliza.SelectionStart = 0;
            this.txtLocaliza.ShortcutsEnabled = true;
            this.txtLocaliza.Size = new System.Drawing.Size(124, 23);
            this.txtLocaliza.TabIndex = 25;
            this.txtLocaliza.UseSelectable = true;
            this.txtLocaliza.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocaliza.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkDisp
            // 
            this.checkDisp.AutoSize = true;
            this.checkDisp.Checked = true;
            this.checkDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisp.Location = new System.Drawing.Point(627, 252);
            this.checkDisp.Name = "checkDisp";
            this.checkDisp.Size = new System.Drawing.Size(15, 14);
            this.checkDisp.TabIndex = 25;
            this.checkDisp.TabStop = false;
            this.checkDisp.UseVisualStyleBackColor = true;
            // 
            // FrmCadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 468);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadLivro";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro: Livro";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtObs;
        private MetroFramework.Controls.MetroTextBox txtEdicao;
        private MetroFramework.Controls.MetroTextBox txtTitulo;
        private MetroFramework.Controls.MetroTextBox txtColecao;
        private MetroFramework.Controls.MetroTextBox txtLocal;
        private MetroFramework.Controls.MetroTextBox txtNPags;
        private MetroFramework.Controls.MetroTextBox txtVolume;
        private MetroFramework.Controls.MetroTextBox txtSubtitulo;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.DateTimePicker dtDataPublicacao;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.ComboBox cbAssunto;
        private MetroFramework.Controls.MetroGrid dataGridGeneros;
        private MetroFramework.Controls.MetroGrid dataGridAssuntos;
        private MetroFramework.Controls.MetroGrid dataGridAutores;
        private MetroFramework.Controls.MetroButton btnAutRemover;
        private MetroFramework.Controls.MetroButton btnAutAdd;
        private MetroFramework.Controls.MetroButton btnGRemover;
        private MetroFramework.Controls.MetroButton btnGAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodAssunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAssunto;
        private MetroFramework.Controls.MetroButton btnAssRemover;
        private MetroFramework.Controls.MetroButton btnAssAdd;
        private System.Windows.Forms.ComboBox cbTipoLivro;
        private MetroFramework.Controls.MetroTextBox txtTombo;
        private System.Windows.Forms.ComboBox cbTipoTombo;
        private System.Windows.Forms.Timer timerCbAutor;
        private System.Windows.Forms.Timer timerCbGenero;
        private System.Windows.Forms.Timer timerCbAssunto;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroLabel lblArea;
        private MetroFramework.Controls.MetroLabel lblEditora;
        private MetroFramework.Controls.MetroLabel lblTipoTombo;
        private MetroFramework.Controls.MetroLabel lblTombo;
        private MetroFramework.Controls.MetroLabel lblDataPublicacao;
        private MetroFramework.Controls.MetroLabel lblColecao;
        private MetroFramework.Controls.MetroLabel lblAssunto;
        private MetroFramework.Controls.MetroLabel lblObs;
        private MetroFramework.Controls.MetroLabel lblTipoLivro;
        private MetroFramework.Controls.MetroLabel lblNPags;
        private MetroFramework.Controls.MetroLabel lblEdicao;
        private MetroFramework.Controls.MetroLabel lblSubtitulo;
        private MetroFramework.Controls.MetroLabel lblAutor;
        private MetroFramework.Controls.MetroLabel lblGenero;
        private MetroFramework.Controls.MetroLabel lblValor;
        private MetroFramework.Controls.MetroLabel lblLocal;
        private MetroFramework.Controls.MetroLabel lblVolume;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private System.Windows.Forms.CheckBox checkDisp;
        private MetroFramework.Controls.MetroTextBox txtLocaliza;
        private System.Windows.Forms.ComboBox cbLingua;
        private MetroFramework.Controls.MetroLabel lblLocaliza;
        private MetroFramework.Controls.MetroLabel lblLingua;
        private MetroFramework.Controls.MetroLabel lblDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGenero;
    }
}