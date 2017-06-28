namespace Interface.Formularios.Consultas
{
    partial class FrmConsultaAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAlunos = new MetroFramework.Controls.MetroGrid();
            this.clnCodAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefoneTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar2_Click);
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
            this.lblForm.Size = new System.Drawing.Size(100, 16);
            this.lblForm.Text = "Consulta: Aluno";
            // 
            // dataGridAlunos
            // 
            this.dataGridAlunos.AllowUserToAddRows = false;
            this.dataGridAlunos.AllowUserToDeleteRows = false;
            this.dataGridAlunos.AllowUserToResizeColumns = false;
            this.dataGridAlunos.AllowUserToResizeRows = false;
            this.dataGridAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAlunos.CausesValidation = false;
            this.dataGridAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodAluno,
            this.clnNome,
            this.clnSexo,
            this.clnCPF,
            this.clnRM,
            this.clnDataCadastro,
            this.clnCodCurso,
            this.clnCurso,
            this.clnCodTurma,
            this.clnPeriodo,
            this.clnTelefone,
            this.clnTelefoneTipo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAlunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAlunos.EnableHeadersVisualStyles = false;
            this.dataGridAlunos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridAlunos.Location = new System.Drawing.Point(23, 68);
            this.dataGridAlunos.MultiSelect = false;
            this.dataGridAlunos.Name = "dataGridAlunos";
            this.dataGridAlunos.ReadOnly = true;
            this.dataGridAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAlunos.RowHeadersVisible = false;
            this.dataGridAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAlunos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAlunos.Size = new System.Drawing.Size(605, 304);
            this.dataGridAlunos.TabIndex = 109;
            // 
            // clnCodAluno
            // 
            this.clnCodAluno.HeaderText = "Cod Aluno";
            this.clnCodAluno.Name = "clnCodAluno";
            this.clnCodAluno.ReadOnly = true;
            this.clnCodAluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            // 
            // clnSexo
            // 
            this.clnSexo.HeaderText = "Sexo";
            this.clnSexo.Name = "clnSexo";
            this.clnSexo.ReadOnly = true;
            this.clnSexo.Visible = false;
            // 
            // clnCPF
            // 
            this.clnCPF.HeaderText = "CPF";
            this.clnCPF.Name = "clnCPF";
            this.clnCPF.ReadOnly = true;
            this.clnCPF.Visible = false;
            // 
            // clnRM
            // 
            this.clnRM.HeaderText = "RM";
            this.clnRM.Name = "clnRM";
            this.clnRM.ReadOnly = true;
            // 
            // clnDataCadastro
            // 
            this.clnDataCadastro.HeaderText = "Data Cadastro";
            this.clnDataCadastro.Name = "clnDataCadastro";
            this.clnDataCadastro.ReadOnly = true;
            this.clnDataCadastro.Visible = false;
            // 
            // clnCodCurso
            // 
            this.clnCodCurso.HeaderText = "CodCurso";
            this.clnCodCurso.Name = "clnCodCurso";
            this.clnCodCurso.ReadOnly = true;
            this.clnCodCurso.Visible = false;
            // 
            // clnCurso
            // 
            this.clnCurso.HeaderText = "Curso";
            this.clnCurso.Name = "clnCurso";
            this.clnCurso.ReadOnly = true;
            // 
            // clnCodTurma
            // 
            this.clnCodTurma.HeaderText = "CodTurma";
            this.clnCodTurma.Name = "clnCodTurma";
            this.clnCodTurma.ReadOnly = true;
            this.clnCodTurma.Visible = false;
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.HeaderText = "Periodo";
            this.clnPeriodo.Name = "clnPeriodo";
            this.clnPeriodo.ReadOnly = true;
            // 
            // clnTelefone
            // 
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            this.clnTelefone.ReadOnly = true;
            // 
            // clnTelefoneTipo
            // 
            this.clnTelefoneTipo.HeaderText = "Tipo Telefone";
            this.clnTelefoneTipo.Name = "clnTelefoneTipo";
            this.clnTelefoneTipo.ReadOnly = true;
            this.clnTelefoneTipo.Visible = false;
            // 
            // FrmConsultaAluno
            // 
            this.AcceptButton = this.btnSelecionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.dataGridAlunos);
            this.Name = "FrmConsultaAluno";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSelecionar, 0);
            this.Controls.SetChildIndex(this.btnFechar2, 0);
            this.Controls.SetChildIndex(this.dataGridAlunos, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGridAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefoneTipo;
    }
}