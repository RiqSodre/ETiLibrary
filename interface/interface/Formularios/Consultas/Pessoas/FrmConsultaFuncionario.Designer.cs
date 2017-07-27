namespace Interface.Formularios.Consultas
{
    partial class FrmConsultaFuncionario
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
            this.dataGridFuncionarios = new MetroFramework.Controls.MetroGrid();
            this.clnCodFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefoneTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Location = new System.Drawing.Point(-1, 5);
            this.pnlForm.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.TabIndex = 0;
            // 
            // btnSelec
            // 
            this.btnSelec.TabIndex = 1;
            this.btnSelec.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnFechar2
            // 
            this.btnFechar2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar2.TabIndex = 2;
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(136, 16);
            this.lblForm.Text = "Consulta: Funcionário";
            // 
            // dataGridFuncionarios
            // 
            this.dataGridFuncionarios.AllowUserToAddRows = false;
            this.dataGridFuncionarios.AllowUserToDeleteRows = false;
            this.dataGridFuncionarios.AllowUserToResizeColumns = false;
            this.dataGridFuncionarios.AllowUserToResizeRows = false;
            this.dataGridFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFuncionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridFuncionarios.CausesValidation = false;
            this.dataGridFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodFuncionario,
            this.clnNome,
            this.clnSexo,
            this.clnCPF,
            this.clnCodCargo,
            this.clnCargo,
            this.clnTelefone,
            this.clnTelefoneTipo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFuncionarios.EnableHeadersVisualStyles = false;
            this.dataGridFuncionarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridFuncionarios.Location = new System.Drawing.Point(9, 55);
            this.dataGridFuncionarios.MultiSelect = false;
            this.dataGridFuncionarios.Name = "dataGridFuncionarios";
            this.dataGridFuncionarios.ReadOnly = true;
            this.dataGridFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridFuncionarios.RowHeadersVisible = false;
            this.dataGridFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFuncionarios.Size = new System.Drawing.Size(640, 304);
            this.dataGridFuncionarios.TabIndex = 0;
            this.dataGridFuncionarios.DoubleClick += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // clnCodFuncionario
            // 
            this.clnCodFuncionario.HeaderText = "Cod Funcionário";
            this.clnCodFuncionario.Name = "clnCodFuncionario";
            this.clnCodFuncionario.ReadOnly = true;
            this.clnCodFuncionario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // 
            // clnCodCargo
            // 
            this.clnCodCargo.HeaderText = "CodCargo";
            this.clnCodCargo.Name = "clnCodCargo";
            this.clnCodCargo.ReadOnly = true;
            this.clnCodCargo.Visible = false;
            // 
            // clnCargo
            // 
            this.clnCargo.HeaderText = "Cargo";
            this.clnCargo.Name = "clnCargo";
            this.clnCargo.ReadOnly = true;
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
            // 
            // FrmConsultaFuncionario
            // 
            this.AcceptButton = this.btnSelec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar2;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.dataGridFuncionarios);
            this.Name = "FrmConsultaFuncionario";
            this.Controls.SetChildIndex(this.pnlForm, 0);
            this.Controls.SetChildIndex(this.btnSelec, 0);
            this.Controls.SetChildIndex(this.btnFechar2, 0);
            this.Controls.SetChildIndex(this.dataGridFuncionarios, 0);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGridFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefoneTipo;
    }
}