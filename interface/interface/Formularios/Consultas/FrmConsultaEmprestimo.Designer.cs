namespace Interface.Formularios.Consultas
{
    partial class FrmConsultaEmprestimo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEmprestimo = new MetroFramework.Controls.MetroGrid();
            this.clnCodUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodFuncionário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFuncionário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMulta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnCondicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar2_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(285, 29);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnFechar2
            // 
            this.btnFechar2.Click += new System.EventHandler(this.btnFechar2_Click);
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(141, 16);
            this.lblForm.Text = "Consulta: Empréstimo ";
            // 
            // dataGridEmprestimo
            // 
            this.dataGridEmprestimo.AllowUserToAddRows = false;
            this.dataGridEmprestimo.AllowUserToDeleteRows = false;
            this.dataGridEmprestimo.AllowUserToResizeColumns = false;
            this.dataGridEmprestimo.AllowUserToResizeRows = false;
            this.dataGridEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmprestimo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridEmprestimo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridEmprestimo.CausesValidation = false;
            this.dataGridEmprestimo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridEmprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodUsuario,
            this.clnUsuário,
            this.clnCodEmprestimo,
            this.clnCodFuncionário,
            this.clnFuncionário,
            this.clnData,
            this.clnMulta,
            this.clnCondicao});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmprestimo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridEmprestimo.EnableHeadersVisualStyles = false;
            this.dataGridEmprestimo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridEmprestimo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridEmprestimo.Location = new System.Drawing.Point(23, 63);
            this.dataGridEmprestimo.MultiSelect = false;
            this.dataGridEmprestimo.Name = "dataGridEmprestimo";
            this.dataGridEmprestimo.ReadOnly = true;
            this.dataGridEmprestimo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridEmprestimo.RowHeadersVisible = false;
            this.dataGridEmprestimo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridEmprestimo.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmprestimo.Size = new System.Drawing.Size(605, 304);
            this.dataGridEmprestimo.TabIndex = 108;
            this.dataGridEmprestimo.DoubleClick += new System.EventHandler(this.dataGridEmprestimo_DoubleClick);
            // 
            // clnCodUsuario
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clnCodUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnCodUsuario.HeaderText = "Cod Usuário";
            this.clnCodUsuario.Name = "clnCodUsuario";
            this.clnCodUsuario.ReadOnly = true;
            this.clnCodUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnUsuário
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clnUsuário.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnUsuário.HeaderText = "Usuário";
            this.clnUsuário.Name = "clnUsuário";
            this.clnUsuário.ReadOnly = true;
            // 
            // clnCodEmprestimo
            // 
            this.clnCodEmprestimo.HeaderText = "Cód Empréstimo";
            this.clnCodEmprestimo.Name = "clnCodEmprestimo";
            this.clnCodEmprestimo.ReadOnly = true;
            this.clnCodEmprestimo.Visible = false;
            // 
            // clnCodFuncionário
            // 
            this.clnCodFuncionário.HeaderText = "Cód Funcionário";
            this.clnCodFuncionário.Name = "clnCodFuncionário";
            this.clnCodFuncionário.ReadOnly = true;
            this.clnCodFuncionário.Visible = false;
            // 
            // clnFuncionário
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clnFuncionário.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnFuncionário.HeaderText = "Funcionário";
            this.clnFuncionário.Name = "clnFuncionário";
            this.clnFuncionário.ReadOnly = true;
            // 
            // clnData
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clnData.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnData.HeaderText = "Data";
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            // 
            // clnMulta
            // 
            this.clnMulta.HeaderText = "Multa";
            this.clnMulta.Name = "clnMulta";
            this.clnMulta.ReadOnly = true;
            this.clnMulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnMulta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clnCondicao
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clnCondicao.DefaultCellStyle = dataGridViewCellStyle6;
            this.clnCondicao.HeaderText = "Condição";
            this.clnCondicao.Name = "clnCondicao";
            this.clnCondicao.ReadOnly = true;
            this.clnCondicao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmConsultaEmprestimo
            // 
            this.AcceptButton = this.btnSelecionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.dataGridEmprestimo);
            this.Name = "FrmConsultaEmprestimo";
            this.Text = "Consulta: Empréstimo";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlForm, 0);
            this.Controls.SetChildIndex(this.btnSelecionar, 0);
            this.Controls.SetChildIndex(this.btnFechar2, 0);
            this.Controls.SetChildIndex(this.dataGridEmprestimo, 0);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGridEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodFuncionário;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncionário;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCondicao;
    }
}