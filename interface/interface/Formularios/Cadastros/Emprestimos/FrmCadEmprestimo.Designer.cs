namespace Interface.Formularios.Cadastros
{
    partial class FrmCadEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEmprestimo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnFecharEmp = new System.Windows.Forms.Button();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtSexo = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.cbMidia = new System.Windows.Forms.ComboBox();
            this.txtTombo = new MetroFramework.Controls.MetroTextBox();
            this.btnCarregar = new MetroFramework.Controls.MetroButton();
            this.lblMidia = new MetroFramework.Controls.MetroLabel();
            this.lblTombo = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblSexo = new MetroFramework.Controls.MetroLabel();
            this.lblTelefone = new MetroFramework.Controls.MetroLabel();
            this.dataGridMidias = new MetroFramework.Controls.MetroGrid();
            this.clnCodMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDevolvido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageGrid = new System.Windows.Forms.ImageList(this.components);
            this.pnlCabecalho.SuspendLayout();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMidias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCabecalho.Controls.Add(this.lblForm);
            this.pnlCabecalho.Controls.Add(this.btnMini);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Location = new System.Drawing.Point(-3, 5);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(593, 26);
            this.pnlCabecalho.TabIndex = 104;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(7, 4);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(178, 16);
            this.lblForm.TabIndex = 48;
            this.lblForm.Text = "Empréstimo: Gerenciamento";
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMini.Location = new System.Drawing.Point(533, 1);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 22);
            this.btnMini.TabIndex = 47;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(561, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 22);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.White;
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBase.Controls.Add(this.btnConcluir);
            this.pnlBase.Controls.Add(this.btnFecharEmp);
            this.pnlBase.Controls.Add(this.btnRenovar);
            this.pnlBase.Controls.Add(this.btnDevolver);
            this.pnlBase.Location = new System.Drawing.Point(-1, 29);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(590, 36);
            this.pnlBase.TabIndex = 103;
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatAppearance.BorderSize = 0;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Location = new System.Drawing.Point(377, -3);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(88, 41);
            this.btnConcluir.TabIndex = 7;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnFecharEmp
            // 
            this.btnFecharEmp.FlatAppearance.BorderSize = 0;
            this.btnFecharEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharEmp.Location = new System.Drawing.Point(286, -3);
            this.btnFecharEmp.Name = "btnFecharEmp";
            this.btnFecharEmp.Size = new System.Drawing.Size(88, 41);
            this.btnFecharEmp.TabIndex = 6;
            this.btnFecharEmp.Text = "Fechar Emprestimo";
            this.btnFecharEmp.UseVisualStyleBackColor = true;
            this.btnFecharEmp.Click += new System.EventHandler(this.btnFecharEmp_Click);
            // 
            // btnRenovar
            // 
            this.btnRenovar.FlatAppearance.BorderSize = 0;
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovar.Location = new System.Drawing.Point(196, -3);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(88, 41);
            this.btnRenovar.TabIndex = 5;
            this.btnRenovar.Text = "Alterar Data";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Location = new System.Drawing.Point(106, -3);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(88, 41);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(342, 90);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(75, 23);
            this.txtCodigo.TabIndex = 107;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(342, 119);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ReadOnly = true;
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(180, 23);
            this.txtNome.TabIndex = 109;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSexo
            // 
            // 
            // 
            // 
            this.txtSexo.CustomButton.Image = null;
            this.txtSexo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtSexo.CustomButton.Name = "";
            this.txtSexo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSexo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSexo.CustomButton.TabIndex = 1;
            this.txtSexo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSexo.CustomButton.UseSelectable = true;
            this.txtSexo.CustomButton.Visible = false;
            this.txtSexo.Lines = new string[0];
            this.txtSexo.Location = new System.Drawing.Point(342, 148);
            this.txtSexo.MaxLength = 32767;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.PasswordChar = '\0';
            this.txtSexo.ReadOnly = true;
            this.txtSexo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSexo.SelectedText = "";
            this.txtSexo.SelectionLength = 0;
            this.txtSexo.SelectionStart = 0;
            this.txtSexo.ShortcutsEnabled = true;
            this.txtSexo.Size = new System.Drawing.Size(75, 23);
            this.txtSexo.TabIndex = 111;
            this.txtSexo.UseSelectable = true;
            this.txtSexo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSexo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefone
            // 
            // 
            // 
            // 
            this.txtTelefone.CustomButton.Image = null;
            this.txtTelefone.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtTelefone.CustomButton.Name = "";
            this.txtTelefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone.CustomButton.TabIndex = 1;
            this.txtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone.CustomButton.UseSelectable = true;
            this.txtTelefone.CustomButton.Visible = false;
            this.txtTelefone.Lines = new string[0];
            this.txtTelefone.Location = new System.Drawing.Point(342, 177);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(107, 23);
            this.txtTelefone.TabIndex = 113;
            this.txtTelefone.UseSelectable = true;
            this.txtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbMidia
            // 
            this.cbMidia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMidia.FormattingEnabled = true;
            this.cbMidia.Items.AddRange(new object[] {
            "Livro",
            "CD_DVD",
            "Mapa",
            "Jornal",
            "Revista"});
            this.cbMidia.Location = new System.Drawing.Point(69, 92);
            this.cbMidia.Name = "cbMidia";
            this.cbMidia.Size = new System.Drawing.Size(142, 21);
            this.cbMidia.TabIndex = 0;
            // 
            // txtTombo
            // 
            // 
            // 
            // 
            this.txtTombo.CustomButton.Image = null;
            this.txtTombo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtTombo.CustomButton.Name = "";
            this.txtTombo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTombo.CustomButton.TabIndex = 1;
            this.txtTombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTombo.CustomButton.UseSelectable = true;
            this.txtTombo.CustomButton.Visible = false;
            this.txtTombo.Lines = new string[0];
            this.txtTombo.Location = new System.Drawing.Point(68, 120);
            this.txtTombo.MaxLength = 32767;
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.PasswordChar = '\0';
            this.txtTombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTombo.SelectedText = "";
            this.txtTombo.SelectionLength = 0;
            this.txtTombo.SelectionStart = 0;
            this.txtTombo.ShortcutsEnabled = true;
            this.txtTombo.Size = new System.Drawing.Size(75, 23);
            this.txtTombo.TabIndex = 1;
            this.txtTombo.UseSelectable = true;
            this.txtTombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTombo_KeyPress);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(149, 119);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(62, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseSelectable = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblMidia
            // 
            this.lblMidia.AutoSize = true;
            this.lblMidia.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMidia.Location = new System.Drawing.Point(13, 92);
            this.lblMidia.Name = "lblMidia";
            this.lblMidia.Size = new System.Drawing.Size(46, 19);
            this.lblMidia.TabIndex = 130;
            this.lblMidia.Text = "Mídia:";
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTombo.Location = new System.Drawing.Point(13, 120);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(54, 19);
            this.lblTombo.TabIndex = 131;
            this.lblTombo.Text = "Tombo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCodigo.Location = new System.Drawing.Point(266, 90);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 134;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNome.Location = new System.Drawing.Point(266, 119);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 19);
            this.lblNome.TabIndex = 135;
            this.lblNome.Text = "Nome:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSexo.Location = new System.Drawing.Point(266, 148);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 19);
            this.lblSexo.TabIndex = 136;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTelefone.Location = new System.Drawing.Point(266, 177);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 19);
            this.lblTelefone.TabIndex = 137;
            this.lblTelefone.Text = "Telefone:";
            // 
            // dataGridMidias
            // 
            this.dataGridMidias.AllowUserToAddRows = false;
            this.dataGridMidias.AllowUserToDeleteRows = false;
            this.dataGridMidias.AllowUserToResizeColumns = false;
            this.dataGridMidias.AllowUserToResizeRows = false;
            this.dataGridMidias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMidias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridMidias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridMidias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridMidias.CausesValidation = false;
            this.dataGridMidias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMidias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.NullValue = "N/I";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMidias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMidias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMidias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodMidia,
            this.clnTombo,
            this.clnDescricao,
            this.clnTipoMidia,
            this.clnDataDevolucao,
            this.clnDevolvido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMidias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMidias.EnableHeadersVisualStyles = false;
            this.dataGridMidias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridMidias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridMidias.Location = new System.Drawing.Point(19, 242);
            this.dataGridMidias.MultiSelect = false;
            this.dataGridMidias.Name = "dataGridMidias";
            this.dataGridMidias.ReadOnly = true;
            this.dataGridMidias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMidias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMidias.RowHeadersVisible = false;
            this.dataGridMidias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridMidias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMidias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMidias.Size = new System.Drawing.Size(545, 148);
            this.dataGridMidias.TabIndex = 1000;
            this.dataGridMidias.TabStop = false;
            // 
            // clnCodMidia
            // 
            this.clnCodMidia.HeaderText = "CodMidia";
            this.clnCodMidia.Name = "clnCodMidia";
            this.clnCodMidia.ReadOnly = true;
            this.clnCodMidia.Visible = false;
            // 
            // clnTombo
            // 
            this.clnTombo.HeaderText = "Tombo";
            this.clnTombo.Name = "clnTombo";
            this.clnTombo.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            // 
            // clnTipoMidia
            // 
            this.clnTipoMidia.HeaderText = "Tipo da Mídia";
            this.clnTipoMidia.Name = "clnTipoMidia";
            this.clnTipoMidia.ReadOnly = true;
            // 
            // clnDataDevolucao
            // 
            this.clnDataDevolucao.HeaderText = "Data de Devolução";
            this.clnDataDevolucao.Name = "clnDataDevolucao";
            this.clnDataDevolucao.ReadOnly = true;
            // 
            // clnDevolvido
            // 
            this.clnDevolvido.HeaderText = "Devolvido";
            this.clnDevolvido.Name = "clnDevolvido";
            this.clnDevolvido.ReadOnly = true;
            this.clnDevolvido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnDevolvido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnDevolvido.ToolTipText = "true";
            // 
            // imageGrid
            // 
            this.imageGrid.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageGrid.ImageStream")));
            this.imageGrid.TransparentColor = System.Drawing.Color.Transparent;
            this.imageGrid.Images.SetKeyName(0, "ok.png");
            this.imageGrid.Images.SetKeyName(1, "error.png");
            // 
            // FrmCadEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(587, 401);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTombo);
            this.Controls.Add(this.lblMidia);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtTombo);
            this.Controls.Add(this.cbMidia);
            this.Controls.Add(this.dataGridMidias);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlBase);
            this.Name = "FrmCadEmprestimo";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro: Empréstimo";
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMidias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlCabecalho;
        public System.Windows.Forms.Label lblForm;
        public System.Windows.Forms.Button btnMini;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Panel pnlBase;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtSexo;
        private MetroFramework.Controls.MetroTextBox txtTelefone;
        public System.Windows.Forms.Button btnConcluir;
        public System.Windows.Forms.Button btnFecharEmp;
        public System.Windows.Forms.Button btnRenovar;
        public System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.ComboBox cbMidia;
        private MetroFramework.Controls.MetroTextBox txtTombo;
        private MetroFramework.Controls.MetroButton btnCarregar;
        private MetroFramework.Controls.MetroLabel lblMidia;
        private MetroFramework.Controls.MetroLabel lblTombo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblSexo;
        private MetroFramework.Controls.MetroLabel lblTelefone;
        public MetroFramework.Controls.MetroGrid dataGridMidias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataDevolucao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnDevolvido;
        private System.Windows.Forms.ImageList imageGrid;
    }
}