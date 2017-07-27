namespace Interface.Formularios.Consultas.Pessoas
{
    partial class FrmConsultaCDVD
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
            this.dataGridCDVD = new MetroFramework.Controls.MetroGrid();
            this.clnCodMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLocaliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLingua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoTombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDisp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCDVD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            // 
            // btnSelec
            // 
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(128, 16);
            this.lblForm.Text = "Consulta: CD e DVD";
            // 
            // dataGridCDVD
            // 
            this.dataGridCDVD.AllowUserToAddRows = false;
            this.dataGridCDVD.AllowUserToDeleteRows = false;
            this.dataGridCDVD.AllowUserToResizeColumns = false;
            this.dataGridCDVD.AllowUserToResizeRows = false;
            this.dataGridCDVD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCDVD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridCDVD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridCDVD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCDVD.CausesValidation = false;
            this.dataGridCDVD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCDVD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCDVD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCDVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCDVD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodMidia,
            this.clnTombo,
            this.clnTitulo,
            this.clnLocaliza,
            this.clnLingua,
            this.clnTipoTombo,
            this.clnDisp,
            this.clnObs,
            this.clnArea,
            this.clnCodArea});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCDVD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCDVD.EnableHeadersVisualStyles = false;
            this.dataGridCDVD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridCDVD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridCDVD.Location = new System.Drawing.Point(9, 55);
            this.dataGridCDVD.MultiSelect = false;
            this.dataGridCDVD.Name = "dataGridCDVD";
            this.dataGridCDVD.ReadOnly = true;
            this.dataGridCDVD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCDVD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCDVD.RowHeadersVisible = false;
            this.dataGridCDVD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCDVD.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCDVD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCDVD.Size = new System.Drawing.Size(640, 304);
            this.dataGridCDVD.TabIndex = 108;
            this.dataGridCDVD.DoubleClick += new System.EventHandler(this.btnSelec_Click);
            // 
            // clnCodMidia
            // 
            this.clnCodMidia.HeaderText = "Cod Midia";
            this.clnCodMidia.Name = "clnCodMidia";
            this.clnCodMidia.ReadOnly = true;
            this.clnCodMidia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnCodMidia.Visible = false;
            // 
            // clnTombo
            // 
            this.clnTombo.HeaderText = "Tombo";
            this.clnTombo.Name = "clnTombo";
            this.clnTombo.ReadOnly = true;
            this.clnTombo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnTitulo
            // 
            this.clnTitulo.HeaderText = "Título";
            this.clnTitulo.Name = "clnTitulo";
            this.clnTitulo.ReadOnly = true;
            this.clnTitulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnLocaliza
            // 
            this.clnLocaliza.HeaderText = "Localização";
            this.clnLocaliza.Name = "clnLocaliza";
            this.clnLocaliza.ReadOnly = true;
            // 
            // clnLingua
            // 
            this.clnLingua.HeaderText = "Lingua";
            this.clnLingua.Name = "clnLingua";
            this.clnLingua.ReadOnly = true;
            this.clnLingua.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnTipoTombo
            // 
            this.clnTipoTombo.HeaderText = "Tipo Tombo";
            this.clnTipoTombo.Name = "clnTipoTombo";
            this.clnTipoTombo.ReadOnly = true;
            this.clnTipoTombo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnDisp
            // 
            this.clnDisp.HeaderText = "Disponível";
            this.clnDisp.Name = "clnDisp";
            this.clnDisp.ReadOnly = true;
            this.clnDisp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnDisp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clnObs
            // 
            this.clnObs.HeaderText = "Observação";
            this.clnObs.Name = "clnObs";
            this.clnObs.ReadOnly = true;
            this.clnObs.Visible = false;
            // 
            // clnArea
            // 
            this.clnArea.HeaderText = "Área";
            this.clnArea.Name = "clnArea";
            this.clnArea.ReadOnly = true;
            this.clnArea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnCodArea
            // 
            this.clnCodArea.HeaderText = "CodArea";
            this.clnCodArea.Name = "clnCodArea";
            this.clnCodArea.ReadOnly = true;
            this.clnCodArea.Visible = false;
            // 
            // FrmConsultaCDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.dataGridCDVD);
            this.Name = "FrmConsultaCDVD";
            this.Controls.SetChildIndex(this.pnlForm, 0);
            this.Controls.SetChildIndex(this.btnSelec, 0);
            this.Controls.SetChildIndex(this.btnFechar2, 0);
            this.Controls.SetChildIndex(this.dataGridCDVD, 0);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCDVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGridCDVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLocaliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLingua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoTombo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodArea;
    }
}
