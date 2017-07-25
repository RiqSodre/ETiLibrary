namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmCadCursoT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCursoT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCurso = new MetroFramework.Controls.MetroLabel();
            this.txtCurso = new MetroFramework.Controls.MetroTextBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.lblcbCurso = new MetroFramework.Controls.MetroLabel();
            this.lblTurmas = new MetroFramework.Controls.MetroLabel();
            this.btnTurmaRemover = new MetroFramework.Controls.MetroButton();
            this.btnTurmaAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridTurmas = new MetroFramework.Controls.MetroGrid();
            this.clnCodTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLinha = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Size = new System.Drawing.Size(355, 26);
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(171, 16);
            this.lblForm.Text = "Cadastro: Cursos e Turmas";
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
            this.btnExcluir.Location = new System.Drawing.Point(222, -3);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(131, -3);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Location = new System.Drawing.Point(40, -3);
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(256, 358);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(164, 358);
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblLinha);
            this.pnlPrincipal.Controls.Add(this.lblTurmas);
            this.pnlPrincipal.Controls.Add(this.btnTurmaRemover);
            this.pnlPrincipal.Controls.Add(this.btnTurmaAdd);
            this.pnlPrincipal.Controls.Add(this.dataGridTurmas);
            this.pnlPrincipal.Controls.Add(this.lblCurso);
            this.pnlPrincipal.Controls.Add(this.txtCurso);
            this.pnlPrincipal.Controls.Add(this.cbCurso);
            this.pnlPrincipal.Controls.Add(this.lblcbCurso);
            this.pnlPrincipal.Size = new System.Drawing.Size(340, 273);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(13, 10);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(46, 19);
            this.lblCurso.TabIndex = 216;
            this.lblCurso.Text = "Curso:";
            // 
            // txtCurso
            // 
            // 
            // 
            // 
            this.txtCurso.CustomButton.Image = null;
            this.txtCurso.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtCurso.CustomButton.Name = "";
            this.txtCurso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurso.CustomButton.TabIndex = 1;
            this.txtCurso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurso.CustomButton.UseSelectable = true;
            this.txtCurso.CustomButton.Visible = false;
            this.txtCurso.Lines = new string[0];
            this.txtCurso.Location = new System.Drawing.Point(18, 31);
            this.txtCurso.MaxLength = 50;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.PasswordChar = '\0';
            this.txtCurso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurso.SelectedText = "";
            this.txtCurso.SelectionLength = 0;
            this.txtCurso.SelectionStart = 0;
            this.txtCurso.ShortcutsEnabled = true;
            this.txtCurso.Size = new System.Drawing.Size(149, 23);
            this.txtCurso.TabIndex = 213;
            this.txtCurso.UseSelectable = true;
            this.txtCurso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // cbCurso
            // 
            this.cbCurso.DisplayMember = "Descricao";
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(177, 31);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(149, 23);
            this.cbCurso.TabIndex = 214;
            this.cbCurso.ValueMember = "CodCurso";
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // lblcbCurso
            // 
            this.lblcbCurso.AutoSize = true;
            this.lblcbCurso.Location = new System.Drawing.Point(172, 9);
            this.lblcbCurso.Name = "lblcbCurso";
            this.lblcbCurso.Size = new System.Drawing.Size(128, 19);
            this.lblcbCurso.TabIndex = 215;
            this.lblcbCurso.Text = "Cursos Cadastrados:";
            // 
            // lblTurmas
            // 
            this.lblTurmas.AutoSize = true;
            this.lblTurmas.Location = new System.Drawing.Point(24, 121);
            this.lblTurmas.Name = "lblTurmas";
            this.lblTurmas.Size = new System.Drawing.Size(129, 19);
            this.lblTurmas.TabIndex = 221;
            this.lblTurmas.Text = "Turmas Cadastradas:";
            // 
            // btnTurmaRemover
            // 
            this.btnTurmaRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurmaRemover.BackgroundImage")));
            this.btnTurmaRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTurmaRemover.Location = new System.Drawing.Point(286, 191);
            this.btnTurmaRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnTurmaRemover.Name = "btnTurmaRemover";
            this.btnTurmaRemover.Size = new System.Drawing.Size(35, 35);
            this.btnTurmaRemover.TabIndex = 220;
            this.btnTurmaRemover.UseSelectable = true;
            this.btnTurmaRemover.Click += new System.EventHandler(this.btnTurmaRemover_Click);
            // 
            // btnTurmaAdd
            // 
            this.btnTurmaAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnTurmaAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurmaAdd.BackgroundImage")));
            this.btnTurmaAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTurmaAdd.Location = new System.Drawing.Point(286, 142);
            this.btnTurmaAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnTurmaAdd.Name = "btnTurmaAdd";
            this.btnTurmaAdd.Size = new System.Drawing.Size(35, 35);
            this.btnTurmaAdd.TabIndex = 218;
            this.btnTurmaAdd.UseSelectable = true;
            this.btnTurmaAdd.Click += new System.EventHandler(this.btnTurmaAdd_Click);
            // 
            // dataGridTurmas
            // 
            this.dataGridTurmas.AllowUserToAddRows = false;
            this.dataGridTurmas.AllowUserToDeleteRows = false;
            this.dataGridTurmas.AllowUserToResizeColumns = false;
            this.dataGridTurmas.AllowUserToResizeRows = false;
            this.dataGridTurmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTurmas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridTurmas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridTurmas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTurmas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTurmas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTurmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodTurma,
            this.clnTurma,
            this.clnPeriodo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTurmas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTurmas.EnableHeadersVisualStyles = false;
            this.dataGridTurmas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridTurmas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridTurmas.Location = new System.Drawing.Point(21, 142);
            this.dataGridTurmas.MultiSelect = false;
            this.dataGridTurmas.Name = "dataGridTurmas";
            this.dataGridTurmas.ReadOnly = true;
            this.dataGridTurmas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTurmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridTurmas.RowHeadersVisible = false;
            this.dataGridTurmas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridTurmas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridTurmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTurmas.Size = new System.Drawing.Size(251, 119);
            this.dataGridTurmas.TabIndex = 219;
            // 
            // clnCodTurma
            // 
            this.clnCodTurma.HeaderText = "Cod";
            this.clnCodTurma.Name = "clnCodTurma";
            this.clnCodTurma.ReadOnly = true;
            this.clnCodTurma.Visible = false;
            // 
            // clnTurma
            // 
            this.clnTurma.HeaderText = "Turma";
            this.clnTurma.Name = "clnTurma";
            this.clnTurma.ReadOnly = true;
            this.clnTurma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.HeaderText = "Período";
            this.clnPeriodo.Name = "clnPeriodo";
            this.clnPeriodo.ReadOnly = true;
            this.clnPeriodo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Location = new System.Drawing.Point(21, 94);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(300, 2);
            this.lblLinha.TabIndex = 222;
            // 
            // FrmCadCursoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Name = "FrmCadCursoT";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTurmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCurso;
        private MetroFramework.Controls.MetroTextBox txtCurso;
        private System.Windows.Forms.ComboBox cbCurso;
        private MetroFramework.Controls.MetroLabel lblcbCurso;
        private System.Windows.Forms.Label lblLinha;
        private MetroFramework.Controls.MetroLabel lblTurmas;
        private MetroFramework.Controls.MetroButton btnTurmaRemover;
        private MetroFramework.Controls.MetroButton btnTurmaAdd;
        private MetroFramework.Controls.MetroGrid dataGridTurmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
    }
}
