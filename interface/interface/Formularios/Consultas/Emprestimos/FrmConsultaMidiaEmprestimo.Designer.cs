namespace Interface.Formularios.Consultas
{
    partial class FrmConsultaMidiaEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaMidiaEmprestimo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblForm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.dataGridMidias = new MetroFramework.Controls.MetroGrid();
            this.clnCodMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDevolvido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMidias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(4, 4);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(220, 16);
            this.lblForm.TabIndex = 48;
            this.lblForm.Text = "Empréstimo: Midias do Empréstimo";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(535, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 22);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl.Controls.Add(this.lblForm);
            this.pnl.Controls.Add(this.btnFechar);
            this.pnl.Location = new System.Drawing.Point(0, 5);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(560, 26);
            this.pnl.TabIndex = 104;
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
            this.dataGridMidias.Location = new System.Drawing.Point(7, 45);
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
            this.dataGridMidias.TabIndex = 1001;
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
            // FrmConsultaMidiaEmprestimo
            // 
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(561, 216);
            this.Controls.Add(this.dataGridMidias);
            this.Controls.Add(this.pnl);
            this.Movable = false;
            this.Name = "FrmConsultaMidiaEmprestimo";
            this.Resizable = false;
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMidias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblForm;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Panel pnl;
        public MetroFramework.Controls.MetroGrid dataGridMidias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataDevolucao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnDevolvido;
    }
}