namespace Interface.Formularios.Cadastros
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
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtEdicao = new MetroFramework.Controls.MetroTextBox();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.txtColecao = new MetroFramework.Controls.MetroTextBox();
            this.txtLocal = new MetroFramework.Controls.MetroTextBox();
            this.txtNdePaginas = new MetroFramework.Controls.MetroTextBox();
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
            this.btnGeneroAdd = new MetroFramework.Controls.MetroButton();
            this.btnGeneroRemover = new MetroFramework.Controls.MetroButton();
            this.btnAutoresRemover = new MetroFramework.Controls.MetroButton();
            this.btnAutoresAdd = new MetroFramework.Controls.MetroButton();
            this.btnAssuntosRemover = new MetroFramework.Controls.MetroButton();
            this.btnAssuntosAdd = new MetroFramework.Controls.MetroButton();
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
            this.lblDisponivel = new MetroFramework.Controls.MetroLabel();
            this.lblLingua = new MetroFramework.Controls.MetroLabel();
            this.lblLocalizacao = new MetroFramework.Controls.MetroLabel();
            this.cbLingua = new System.Windows.Forms.ComboBox();
            this.txtLocalizacao = new MetroFramework.Controls.MetroTextBox();
            this.checkDisponivel = new System.Windows.Forms.CheckBox();
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
            this.pnl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnl.Size = new System.Drawing.Size(1020, 32);
            this.pnl.TabIndex = 2;
            // 
            // lblForm
            // 
            this.lblForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblForm.Size = new System.Drawing.Size(124, 20);
            this.lblForm.Text = "Cadastro: Livro";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Location = new System.Drawing.Point(963, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFechar.TabIndex = 2;
            // 
            // pnlBase
            // 
            this.pnlBase.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlBase.Size = new System.Drawing.Size(1013, 44);
            this.pnlBase.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(564, -4);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(447, -4);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(329, -4);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(883, 534);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(753, 534);
            this.btnAcao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcao.TabIndex = 0;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.checkDisponivel);
            this.pnlPrincipal.Controls.Add(this.txtLocalizacao);
            this.pnlPrincipal.Controls.Add(this.cbLingua);
            this.pnlPrincipal.Controls.Add(this.lblLocalizacao);
            this.pnlPrincipal.Controls.Add(this.lblLingua);
            this.pnlPrincipal.Controls.Add(this.lblDisponivel);
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
            this.pnlPrincipal.Controls.Add(this.btnAssuntosRemover);
            this.pnlPrincipal.Controls.Add(this.btnAssuntosAdd);
            this.pnlPrincipal.Controls.Add(this.btnAutoresRemover);
            this.pnlPrincipal.Controls.Add(this.btnAutoresAdd);
            this.pnlPrincipal.Controls.Add(this.btnGeneroRemover);
            this.pnlPrincipal.Controls.Add(this.btnGeneroAdd);
            this.pnlPrincipal.Controls.Add(this.dataGridAutores);
            this.pnlPrincipal.Controls.Add(this.dataGridGeneros);
            this.pnlPrincipal.Controls.Add(this.dataGridAssuntos);
            this.pnlPrincipal.Controls.Add(this.txtObservacao);
            this.pnlPrincipal.Controls.Add(this.cbAutor);
            this.pnlPrincipal.Controls.Add(this.cbGenero);
            this.pnlPrincipal.Controls.Add(this.txtNdePaginas);
            this.pnlPrincipal.Controls.Add(this.dtDataPublicacao);
            this.pnlPrincipal.Controls.Add(this.cbAssunto);
            this.pnlPrincipal.Controls.Add(this.cbArea);
            this.pnlPrincipal.Controls.Add(this.cbEditora);
            this.pnlPrincipal.Controls.Add(this.txtLocal);
            this.pnlPrincipal.Controls.Add(this.txtEdicao);
            this.pnlPrincipal.Controls.Add(this.txtVolume);
            this.pnlPrincipal.Controls.Add(this.txtColecao);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlPrincipal.Size = new System.Drawing.Size(892, 439);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(367, 196);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(263, 94);
            this.txtObservacao.TabIndex = 17;
            // 
            // txtEdicao
            // 
            // 
            // 
            // 
            this.txtEdicao.CustomButton.Image = null;
            this.txtEdicao.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtEdicao.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdicao.CustomButton.Name = "";
            this.txtEdicao.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtEdicao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdicao.CustomButton.TabIndex = 1;
            this.txtEdicao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdicao.CustomButton.UseSelectable = true;
            this.txtEdicao.CustomButton.Visible = false;
            this.txtEdicao.Lines = new string[0];
            this.txtEdicao.Location = new System.Drawing.Point(411, 52);
            this.txtEdicao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdicao.MaxLength = 32767;
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.PasswordChar = '\0';
            this.txtEdicao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdicao.SelectedText = "";
            this.txtEdicao.SelectionLength = 0;
            this.txtEdicao.SelectionStart = 0;
            this.txtEdicao.ShortcutsEnabled = true;
            this.txtEdicao.Size = new System.Drawing.Size(164, 28);
            this.txtEdicao.TabIndex = 4;
            this.txtEdicao.UseSelectable = true;
            this.txtEdicao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdicao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.txtTitulo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(109, 14);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(195, 28);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtColecao
            // 
            // 
            // 
            // 
            this.txtColecao.CustomButton.Image = null;
            this.txtColecao.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtColecao.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColecao.CustomButton.Name = "";
            this.txtColecao.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtColecao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColecao.CustomButton.TabIndex = 1;
            this.txtColecao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColecao.CustomButton.UseSelectable = true;
            this.txtColecao.CustomButton.Visible = false;
            this.txtColecao.Lines = new string[0];
            this.txtColecao.Location = new System.Drawing.Point(759, 14);
            this.txtColecao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColecao.MaxLength = 32767;
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.PasswordChar = '\0';
            this.txtColecao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColecao.SelectedText = "";
            this.txtColecao.SelectionLength = 0;
            this.txtColecao.SelectionStart = 0;
            this.txtColecao.ShortcutsEnabled = true;
            this.txtColecao.Size = new System.Drawing.Size(127, 28);
            this.txtColecao.TabIndex = 2;
            this.txtColecao.UseSelectable = true;
            this.txtColecao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColecao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLocal
            // 
            // 
            // 
            // 
            this.txtLocal.CustomButton.Image = null;
            this.txtLocal.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtLocal.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocal.CustomButton.Name = "";
            this.txtLocal.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtLocal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocal.CustomButton.TabIndex = 1;
            this.txtLocal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocal.CustomButton.UseSelectable = true;
            this.txtLocal.CustomButton.Visible = false;
            this.txtLocal.Lines = new string[0];
            this.txtLocal.Location = new System.Drawing.Point(109, 87);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocal.MaxLength = 32767;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PasswordChar = '\0';
            this.txtLocal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocal.SelectedText = "";
            this.txtLocal.SelectionLength = 0;
            this.txtLocal.SelectionStart = 0;
            this.txtLocal.ShortcutsEnabled = true;
            this.txtLocal.Size = new System.Drawing.Size(127, 28);
            this.txtLocal.TabIndex = 6;
            this.txtLocal.UseSelectable = true;
            this.txtLocal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocal_KeyPress);
            // 
            // txtNdePaginas
            // 
            // 
            // 
            // 
            this.txtNdePaginas.CustomButton.Image = null;
            this.txtNdePaginas.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtNdePaginas.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNdePaginas.CustomButton.Name = "";
            this.txtNdePaginas.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtNdePaginas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNdePaginas.CustomButton.TabIndex = 1;
            this.txtNdePaginas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNdePaginas.CustomButton.UseSelectable = true;
            this.txtNdePaginas.CustomButton.Visible = false;
            this.txtNdePaginas.Lines = new string[0];
            this.txtNdePaginas.Location = new System.Drawing.Point(411, 87);
            this.txtNdePaginas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNdePaginas.MaxLength = 32767;
            this.txtNdePaginas.Name = "txtNdePaginas";
            this.txtNdePaginas.PasswordChar = '\0';
            this.txtNdePaginas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNdePaginas.SelectedText = "";
            this.txtNdePaginas.SelectionLength = 0;
            this.txtNdePaginas.SelectionStart = 0;
            this.txtNdePaginas.ShortcutsEnabled = true;
            this.txtNdePaginas.Size = new System.Drawing.Size(125, 28);
            this.txtNdePaginas.TabIndex = 7;
            this.txtNdePaginas.UseSelectable = true;
            this.txtNdePaginas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNdePaginas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNdePaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNdePaginas_KeyPress);
            // 
            // txtVolume
            // 
            // 
            // 
            // 
            this.txtVolume.CustomButton.Image = null;
            this.txtVolume.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtVolume.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVolume.CustomButton.Name = "";
            this.txtVolume.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtVolume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVolume.CustomButton.TabIndex = 1;
            this.txtVolume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVolume.CustomButton.UseSelectable = true;
            this.txtVolume.CustomButton.Visible = false;
            this.txtVolume.Lines = new string[0];
            this.txtVolume.Location = new System.Drawing.Point(109, 52);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVolume.MaxLength = 32767;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.PasswordChar = '\0';
            this.txtVolume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVolume.SelectedText = "";
            this.txtVolume.SelectionLength = 0;
            this.txtVolume.SelectionStart = 0;
            this.txtVolume.ShortcutsEnabled = true;
            this.txtVolume.Size = new System.Drawing.Size(127, 28);
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
            this.txtSubtitulo.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtSubtitulo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtitulo.CustomButton.Name = "";
            this.txtSubtitulo.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtSubtitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubtitulo.CustomButton.TabIndex = 1;
            this.txtSubtitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtitulo.CustomButton.UseSelectable = true;
            this.txtSubtitulo.CustomButton.Visible = false;
            this.txtSubtitulo.Lines = new string[0];
            this.txtSubtitulo.Location = new System.Drawing.Point(411, 14);
            this.txtSubtitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtitulo.MaxLength = 32767;
            this.txtSubtitulo.Name = "txtSubtitulo";
            this.txtSubtitulo.PasswordChar = '\0';
            this.txtSubtitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtitulo.SelectedText = "";
            this.txtSubtitulo.SelectionLength = 0;
            this.txtSubtitulo.SelectionStart = 0;
            this.txtSubtitulo.ShortcutsEnabled = true;
            this.txtSubtitulo.Size = new System.Drawing.Size(164, 28);
            this.txtSubtitulo.TabIndex = 1;
            this.txtSubtitulo.UseSelectable = true;
            this.txtSubtitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubtitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(109, 161);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(172, 24);
            this.cbGenero.TabIndex = 11;
            this.cbGenero.Text = "Digite o genero";
            this.cbGenero.Click += new System.EventHandler(this.cbGenero_Click);
            this.cbGenero.Leave += new System.EventHandler(this.cbGenero_Leave);
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.SystemColors.Window;
            this.cbArea.DisplayMember = "Descricao";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(721, 271);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(163, 24);
            this.cbArea.TabIndex = 24;
            this.cbArea.ValueMember = "CodArea";
            // 
            // cbEditora
            // 
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(723, 231);
            this.cbEditora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(161, 24);
            this.cbEditora.TabIndex = 23;
            this.cbEditora.Text = "Digite a editora";
            // 
            // dtDataPublicacao
            // 
            this.dtDataPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPublicacao.Location = new System.Drawing.Point(768, 53);
            this.dtDataPublicacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataPublicacao.Name = "dtDataPublicacao";
            this.dtDataPublicacao.Size = new System.Drawing.Size(116, 22);
            this.dtDataPublicacao.TabIndex = 5;
            // 
            // cbAssunto
            // 
            this.cbAssunto.FormattingEnabled = true;
            this.cbAssunto.Location = new System.Drawing.Point(411, 304);
            this.cbAssunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAssunto.Name = "cbAssunto";
            this.cbAssunto.Size = new System.Drawing.Size(172, 24);
            this.cbAssunto.TabIndex = 18;
            this.cbAssunto.Text = "Digite o assunto";
            this.cbAssunto.Click += new System.EventHandler(this.cbAssunto_Click);
            this.cbAssunto.Leave += new System.EventHandler(this.cbAssunto_Leave);
            // 
            // cbAutor
            // 
            this.cbAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(109, 304);
            this.cbAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(172, 24);
            this.cbAutor.TabIndex = 14;
            this.cbAutor.Text = "Digite o nome do Autor";
            this.cbAutor.Click += new System.EventHandler(this.cbAutor_Click);
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
            this.dataGridAssuntos.Location = new System.Drawing.Point(365, 337);
            this.dataGridAssuntos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridAssuntos.Size = new System.Drawing.Size(265, 95);
            this.dataGridAssuntos.TabIndex = 167;
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
            this.dataGridGeneros.Location = new System.Drawing.Point(43, 196);
            this.dataGridGeneros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridGeneros.Size = new System.Drawing.Size(261, 95);
            this.dataGridGeneros.TabIndex = 168;
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
            this.clnGenero.HeaderText = "Generos";
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
            this.dataGridAutores.Location = new System.Drawing.Point(44, 337);
            this.dataGridAutores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridAutores.Size = new System.Drawing.Size(261, 95);
            this.dataGridAutores.TabIndex = 169;
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
            // btnGeneroAdd
            // 
            this.btnGeneroAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneroAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneroAdd.BackgroundImage")));
            this.btnGeneroAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneroAdd.Location = new System.Drawing.Point(312, 196);
            this.btnGeneroAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeneroAdd.Name = "btnGeneroAdd";
            this.btnGeneroAdd.Size = new System.Drawing.Size(40, 37);
            this.btnGeneroAdd.TabIndex = 12;
            this.btnGeneroAdd.UseSelectable = true;
            this.btnGeneroAdd.Click += new System.EventHandler(this.btnGeneroAdd_Click);
            // 
            // btnGeneroRemover
            // 
            this.btnGeneroRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneroRemover.BackgroundImage")));
            this.btnGeneroRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneroRemover.Location = new System.Drawing.Point(312, 233);
            this.btnGeneroRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeneroRemover.Name = "btnGeneroRemover";
            this.btnGeneroRemover.Size = new System.Drawing.Size(40, 37);
            this.btnGeneroRemover.TabIndex = 13;
            this.btnGeneroRemover.UseSelectable = true;
            this.btnGeneroRemover.Click += new System.EventHandler(this.btnGeneroRemover_Click);
            // 
            // btnAutoresRemover
            // 
            this.btnAutoresRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoresRemover.BackgroundImage")));
            this.btnAutoresRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoresRemover.Location = new System.Drawing.Point(309, 373);
            this.btnAutoresRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoresRemover.Name = "btnAutoresRemover";
            this.btnAutoresRemover.Size = new System.Drawing.Size(40, 37);
            this.btnAutoresRemover.TabIndex = 16;
            this.btnAutoresRemover.UseSelectable = true;
            this.btnAutoresRemover.Click += new System.EventHandler(this.btnAutoresRemover_Click);
            // 
            // btnAutoresAdd
            // 
            this.btnAutoresAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoresAdd.BackgroundImage")));
            this.btnAutoresAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoresAdd.Location = new System.Drawing.Point(309, 336);
            this.btnAutoresAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoresAdd.Name = "btnAutoresAdd";
            this.btnAutoresAdd.Size = new System.Drawing.Size(40, 37);
            this.btnAutoresAdd.TabIndex = 15;
            this.btnAutoresAdd.UseSelectable = true;
            this.btnAutoresAdd.Click += new System.EventHandler(this.btnAutoresAdd_Click);
            // 
            // btnAssuntosRemover
            // 
            this.btnAssuntosRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssuntosRemover.BackgroundImage")));
            this.btnAssuntosRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssuntosRemover.Location = new System.Drawing.Point(636, 373);
            this.btnAssuntosRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnAssuntosRemover.Name = "btnAssuntosRemover";
            this.btnAssuntosRemover.Size = new System.Drawing.Size(40, 37);
            this.btnAssuntosRemover.TabIndex = 20;
            this.btnAssuntosRemover.UseSelectable = true;
            this.btnAssuntosRemover.Click += new System.EventHandler(this.btnAssuntosRemover_Click);
            // 
            // btnAssuntosAdd
            // 
            this.btnAssuntosAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssuntosAdd.BackgroundImage")));
            this.btnAssuntosAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssuntosAdd.Location = new System.Drawing.Point(636, 336);
            this.btnAssuntosAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAssuntosAdd.Name = "btnAssuntosAdd";
            this.btnAssuntosAdd.Size = new System.Drawing.Size(40, 37);
            this.btnAssuntosAdd.TabIndex = 19;
            this.btnAssuntosAdd.UseSelectable = true;
            this.btnAssuntosAdd.Click += new System.EventHandler(this.btnAssuntosAdd_Click);
            // 
            // cbTipoLivro
            // 
            this.cbTipoLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLivro.FormattingEnabled = true;
            this.cbTipoLivro.Items.AddRange(new object[] {
            "Técnico",
            "Literatura",
            "Didático",
            "Braile"});
            this.cbTipoLivro.Location = new System.Drawing.Point(411, 128);
            this.cbTipoLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoLivro.Name = "cbTipoLivro";
            this.cbTipoLivro.Size = new System.Drawing.Size(163, 24);
            this.cbTipoLivro.TabIndex = 9;
            // 
            // cbTipoTombo
            // 
            this.cbTipoTombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTombo.FormattingEnabled = true;
            this.cbTipoTombo.Items.AddRange(new object[] {
            "Doação",
            "Compra",
            "Permuta"});
            this.cbTipoTombo.Location = new System.Drawing.Point(721, 128);
            this.cbTipoTombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoTombo.Name = "cbTipoTombo";
            this.cbTipoTombo.Size = new System.Drawing.Size(163, 24);
            this.cbTipoTombo.TabIndex = 10;
            // 
            // txtTombo
            // 
            // 
            // 
            // 
            this.txtTombo.CustomButton.Image = null;
            this.txtTombo.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtTombo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTombo.CustomButton.Name = "";
            this.txtTombo.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtTombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTombo.CustomButton.TabIndex = 1;
            this.txtTombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTombo.CustomButton.UseSelectable = true;
            this.txtTombo.CustomButton.Visible = false;
            this.txtTombo.Lines = new string[0];
            this.txtTombo.Location = new System.Drawing.Point(759, 87);
            this.txtTombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTombo.MaxLength = 32767;
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.PasswordChar = '\0';
            this.txtTombo.ReadOnly = true;
            this.txtTombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTombo.SelectedText = "";
            this.txtTombo.SelectionLength = 0;
            this.txtTombo.SelectionStart = 0;
            this.txtTombo.ShortcutsEnabled = true;
            this.txtTombo.Size = new System.Drawing.Size(127, 28);
            this.txtTombo.TabIndex = 10;
            this.txtTombo.TabStop = false;
            this.txtTombo.UseSelectable = true;
            this.txtTombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // timerCbAutor
            // 
            this.timerCbAutor.Interval = 2500;
            this.timerCbAutor.Tick += new System.EventHandler(this.timerCbAutor_Tick);
            // 
            // timerCbGenero
            // 
            this.timerCbGenero.Interval = 2500;
            this.timerCbGenero.Tick += new System.EventHandler(this.timerCbGenero_Tick);
            // 
            // timerCbAssunto
            // 
            this.timerCbAssunto.Interval = 2500;
            this.timerCbAssunto.Tick += new System.EventHandler(this.timerCbAssunto_Tick);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtValor.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[] {
        "R$ 00,00"};
            this.txtValor.Location = new System.Drawing.Point(109, 127);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(127, 28);
            this.txtValor.TabIndex = 8;
            this.txtValor.Text = "R$ 00,00";
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(28, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 20);
            this.lblTitulo.TabIndex = 188;
            this.lblTitulo.Text = "Título:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(28, 54);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(59, 20);
            this.lblVolume.TabIndex = 189;
            this.lblVolume.Text = "Volume:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(28, 90);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(44, 20);
            this.lblLocal.TabIndex = 190;
            this.lblLocal.Text = "Local:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(28, 129);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 20);
            this.lblValor.TabIndex = 191;
            this.lblValor.Text = "Valor:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(28, 162);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(59, 20);
            this.lblGenero.TabIndex = 192;
            this.lblGenero.Text = "Genêro:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(28, 305);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(47, 20);
            this.lblAutor.TabIndex = 193;
            this.lblAutor.Text = "Autor:";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(319, 16);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(65, 20);
            this.lblSubtitulo.TabIndex = 194;
            this.lblSubtitulo.Text = "Subtitulo:";
            // 
            // lblEdicao
            // 
            this.lblEdicao.AutoSize = true;
            this.lblEdicao.Location = new System.Drawing.Point(319, 54);
            this.lblEdicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(53, 20);
            this.lblEdicao.TabIndex = 195;
            this.lblEdicao.Text = "Edição:";
            // 
            // lblNPags
            // 
            this.lblNPags.AutoSize = true;
            this.lblNPags.Location = new System.Drawing.Point(277, 90);
            this.lblNPags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNPags.Name = "lblNPags";
            this.lblNPags.Size = new System.Drawing.Size(99, 20);
            this.lblNPags.TabIndex = 196;
            this.lblNPags.Text = "Nº de Páginas:";
            // 
            // lblTipoLivro
            // 
            this.lblTipoLivro.AutoSize = true;
            this.lblTipoLivro.Location = new System.Drawing.Point(275, 129);
            this.lblTipoLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoLivro.Name = "lblTipoLivro";
            this.lblTipoLivro.Size = new System.Drawing.Size(93, 20);
            this.lblTipoLivro.TabIndex = 197;
            this.lblTipoLivro.Text = "Tipo do Livro:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(365, 162);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(87, 20);
            this.lblObs.TabIndex = 198;
            this.lblObs.Text = "Observação:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(335, 305);
            this.lblAssunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(61, 20);
            this.lblAssunto.TabIndex = 199;
            this.lblAssunto.Text = "Assunto:";
            // 
            // lblColecao
            // 
            this.lblColecao.AutoSize = true;
            this.lblColecao.Location = new System.Drawing.Point(671, 16);
            this.lblColecao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColecao.Name = "lblColecao";
            this.lblColecao.Size = new System.Drawing.Size(62, 20);
            this.lblColecao.TabIndex = 200;
            this.lblColecao.Text = "Coleção:";
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Location = new System.Drawing.Point(593, 54);
            this.lblDataPublicacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(130, 20);
            this.lblDataPublicacao.TabIndex = 201;
            this.lblDataPublicacao.Text = "Data de Publicação:";
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(671, 90);
            this.lblTombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(54, 20);
            this.lblTombo.TabIndex = 202;
            this.lblTombo.Text = "Tombo:";
            // 
            // lblTipoTombo
            // 
            this.lblTipoTombo.AutoSize = true;
            this.lblTipoTombo.Location = new System.Drawing.Point(583, 129);
            this.lblTipoTombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTombo.Name = "lblTipoTombo";
            this.lblTipoTombo.Size = new System.Drawing.Size(105, 20);
            this.lblTipoTombo.TabIndex = 203;
            this.lblTipoTombo.Text = "Tipo de Tombo:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(647, 233);
            this.lblEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(55, 20);
            this.lblEditora.TabIndex = 204;
            this.lblEditora.Text = "Editora:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(660, 272);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(41, 20);
            this.lblArea.TabIndex = 205;
            this.lblArea.Text = "Area:";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.Location = new System.Drawing.Point(720, 305);
            this.lblDisponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(76, 20);
            this.lblDisponivel.TabIndex = 206;
            this.lblDisponivel.Text = "Disponivel:";
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(647, 196);
            this.lblLingua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(53, 20);
            this.lblLingua.TabIndex = 207;
            this.lblLingua.Text = "Lingua:";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(608, 162);
            this.lblLocalizacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(83, 20);
            this.lblLocalizacao.TabIndex = 208;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // cbLingua
            // 
            this.cbLingua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbLingua.Location = new System.Drawing.Point(721, 196);
            this.cbLingua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLingua.Name = "cbLingua";
            this.cbLingua.Size = new System.Drawing.Size(163, 24);
            this.cbLingua.TabIndex = 22;
            // 
            // txtLocalizacao
            // 
            // 
            // 
            // 
            this.txtLocalizacao.CustomButton.Image = null;
            this.txtLocalizacao.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txtLocalizacao.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalizacao.CustomButton.Name = "";
            this.txtLocalizacao.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtLocalizacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocalizacao.CustomButton.TabIndex = 1;
            this.txtLocalizacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocalizacao.CustomButton.UseSelectable = true;
            this.txtLocalizacao.CustomButton.Visible = false;
            this.txtLocalizacao.Lines = new string[0];
            this.txtLocalizacao.Location = new System.Drawing.Point(720, 162);
            this.txtLocalizacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalizacao.MaxLength = 32767;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.PasswordChar = '\0';
            this.txtLocalizacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocalizacao.SelectedText = "";
            this.txtLocalizacao.SelectionLength = 0;
            this.txtLocalizacao.SelectionStart = 0;
            this.txtLocalizacao.ShortcutsEnabled = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(165, 28);
            this.txtLocalizacao.TabIndex = 21;
            this.txtLocalizacao.UseSelectable = true;
            this.txtLocalizacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocalizacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkDisponivel
            // 
            this.checkDisponivel.AutoSize = true;
            this.checkDisponivel.Checked = true;
            this.checkDisponivel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisponivel.Location = new System.Drawing.Point(817, 310);
            this.checkDisponivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDisponivel.Name = "checkDisponivel";
            this.checkDisponivel.Size = new System.Drawing.Size(18, 17);
            this.checkDisponivel.TabIndex = 25;
            this.checkDisponivel.UseVisualStyleBackColor = true;
            // 
            // FrmCadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 576);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmCadLivro";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
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

        private System.Windows.Forms.TextBox txtObservacao;
        private MetroFramework.Controls.MetroTextBox txtEdicao;
        private MetroFramework.Controls.MetroTextBox txtTitulo;
        private MetroFramework.Controls.MetroTextBox txtColecao;
        private MetroFramework.Controls.MetroTextBox txtLocal;
        private MetroFramework.Controls.MetroTextBox txtNdePaginas;
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
        private MetroFramework.Controls.MetroButton btnAutoresRemover;
        private MetroFramework.Controls.MetroButton btnAutoresAdd;
        private MetroFramework.Controls.MetroButton btnGeneroRemover;
        private MetroFramework.Controls.MetroButton btnGeneroAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodAssunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAssunto;
        private MetroFramework.Controls.MetroButton btnAssuntosRemover;
        private MetroFramework.Controls.MetroButton btnAssuntosAdd;
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
        private System.Windows.Forms.CheckBox checkDisponivel;
        private MetroFramework.Controls.MetroTextBox txtLocalizacao;
        private System.Windows.Forms.ComboBox cbLingua;
        private MetroFramework.Controls.MetroLabel lblLocalizacao;
        private MetroFramework.Controls.MetroLabel lblLingua;
        private MetroFramework.Controls.MetroLabel lblDisponivel;
    }
}