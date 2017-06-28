namespace Interface.Formularios.Consultas
{
    partial class FrmConsultaLivro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridLivro = new MetroFramework.Controls.MetroGrid();
            this.clnCodLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSubtitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnColecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNPags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataPublicacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLingua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoTombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDisponivel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAssuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).BeginInit();
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
            // dataGridLivro
            // 
            this.dataGridLivro.AllowUserToAddRows = false;
            this.dataGridLivro.AllowUserToDeleteRows = false;
            this.dataGridLivro.AllowUserToResizeColumns = false;
            this.dataGridLivro.AllowUserToResizeRows = false;
            this.dataGridLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridLivro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridLivro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridLivro.CausesValidation = false;
            this.dataGridLivro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridLivro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodLivro,
            this.clnTitulo,
            this.clnSubtitulo,
            this.clnColecao,
            this.clnEdicao,
            this.clnVolume,
            this.clnNPags,
            this.clnLocal,
            this.clnDataPublicacao,
            this.clnValor,
            this.clnTipoLivro,
            this.clnLocalizacao,
            this.clnLingua,
            this.clnDataCadastro,
            this.clnTipoTombo,
            this.clnTombo,
            this.clnTipoMidia,
            this.clnDisponivel,
            this.clnObs,
            this.clnCodArea,
            this.clnArea,
            this.clnCodEditora,
            this.clnEditora,
            this.clnGenero,
            this.clnAssuntos,
            this.clnAutores});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLivro.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridLivro.EnableHeadersVisualStyles = false;
            this.dataGridLivro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridLivro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridLivro.Location = new System.Drawing.Point(27, 68);
            this.dataGridLivro.MultiSelect = false;
            this.dataGridLivro.Name = "dataGridLivro";
            this.dataGridLivro.ReadOnly = true;
            this.dataGridLivro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLivro.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridLivro.RowHeadersVisible = false;
            this.dataGridLivro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridLivro.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLivro.Size = new System.Drawing.Size(605, 304);
            this.dataGridLivro.TabIndex = 109;
            // 
            // clnCodLivro
            // 
            this.clnCodLivro.HeaderText = "CodLivro";
            this.clnCodLivro.Name = "clnCodLivro";
            this.clnCodLivro.ReadOnly = true;
            this.clnCodLivro.Visible = false;
            this.clnCodLivro.Width = 56;
            // 
            // clnTitulo
            // 
            this.clnTitulo.HeaderText = "Titulo";
            this.clnTitulo.Name = "clnTitulo";
            this.clnTitulo.ReadOnly = true;
            this.clnTitulo.Width = 59;
            // 
            // clnSubtitulo
            // 
            this.clnSubtitulo.HeaderText = "Subtitulo";
            this.clnSubtitulo.Name = "clnSubtitulo";
            this.clnSubtitulo.ReadOnly = true;
            this.clnSubtitulo.Visible = false;
            this.clnSubtitulo.Width = 78;
            // 
            // clnColecao
            // 
            this.clnColecao.HeaderText = "Coleção";
            this.clnColecao.Name = "clnColecao";
            this.clnColecao.ReadOnly = true;
            this.clnColecao.Visible = false;
            this.clnColecao.Width = 71;
            // 
            // clnEdicao
            // 
            this.clnEdicao.HeaderText = "Edição";
            this.clnEdicao.Name = "clnEdicao";
            this.clnEdicao.ReadOnly = true;
            this.clnEdicao.Width = 64;
            // 
            // clnVolume
            // 
            this.clnVolume.HeaderText = "Volume";
            this.clnVolume.Name = "clnVolume";
            this.clnVolume.ReadOnly = true;
            this.clnVolume.Visible = false;
            this.clnVolume.Width = 68;
            // 
            // clnNPags
            // 
            this.clnNPags.HeaderText = "Nº de Páginas";
            this.clnNPags.Name = "clnNPags";
            this.clnNPags.ReadOnly = true;
            this.clnNPags.Visible = false;
            this.clnNPags.Width = 102;
            // 
            // clnLocal
            // 
            this.clnLocal.HeaderText = "Local";
            this.clnLocal.Name = "clnLocal";
            this.clnLocal.ReadOnly = true;
            this.clnLocal.Visible = false;
            this.clnLocal.Width = 56;
            // 
            // clnDataPublicacao
            // 
            this.clnDataPublicacao.HeaderText = "Data Publicação";
            this.clnDataPublicacao.Name = "clnDataPublicacao";
            this.clnDataPublicacao.ReadOnly = true;
            this.clnDataPublicacao.Width = 103;
            // 
            // clnValor
            // 
            this.clnValor.HeaderText = "Valor";
            this.clnValor.Name = "clnValor";
            this.clnValor.ReadOnly = true;
            this.clnValor.Visible = false;
            this.clnValor.Width = 56;
            // 
            // clnTipoLivro
            // 
            this.clnTipoLivro.HeaderText = "Tipo Livro";
            this.clnTipoLivro.Name = "clnTipoLivro";
            this.clnTipoLivro.ReadOnly = true;
            this.clnTipoLivro.Visible = false;
            this.clnTipoLivro.Width = 73;
            // 
            // clnLocalizacao
            // 
            this.clnLocalizacao.HeaderText = "Localização";
            this.clnLocalizacao.Name = "clnLocalizacao";
            this.clnLocalizacao.ReadOnly = true;
            this.clnLocalizacao.Width = 88;
            // 
            // clnLingua
            // 
            this.clnLingua.HeaderText = "Lingua";
            this.clnLingua.Name = "clnLingua";
            this.clnLingua.ReadOnly = true;
            this.clnLingua.Width = 65;
            // 
            // clnDataCadastro
            // 
            this.clnDataCadastro.HeaderText = "Data Cadastro";
            this.clnDataCadastro.Name = "clnDataCadastro";
            this.clnDataCadastro.ReadOnly = true;
            this.clnDataCadastro.Visible = false;
            this.clnDataCadastro.Width = 94;
            // 
            // clnTipoTombo
            // 
            this.clnTipoTombo.HeaderText = "Tipo Tombo";
            this.clnTipoTombo.Name = "clnTipoTombo";
            this.clnTipoTombo.ReadOnly = true;
            this.clnTipoTombo.Visible = false;
            this.clnTipoTombo.Width = 82;
            // 
            // clnTombo
            // 
            this.clnTombo.HeaderText = "Tombo";
            this.clnTombo.Name = "clnTombo";
            this.clnTombo.ReadOnly = true;
            this.clnTombo.Width = 64;
            // 
            // clnTipoMidia
            // 
            this.clnTipoMidia.HeaderText = "TipoMidia";
            this.clnTipoMidia.Name = "clnTipoMidia";
            this.clnTipoMidia.ReadOnly = true;
            this.clnTipoMidia.Visible = false;
            this.clnTipoMidia.Width = 81;
            // 
            // clnDisponivel
            // 
            this.clnDisponivel.HeaderText = "Disponivel";
            this.clnDisponivel.Name = "clnDisponivel";
            this.clnDisponivel.ReadOnly = true;
            this.clnDisponivel.Width = 65;
            // 
            // clnObs
            // 
            this.clnObs.HeaderText = "Observação";
            this.clnObs.Name = "clnObs";
            this.clnObs.ReadOnly = true;
            this.clnObs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnObs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnObs.Visible = false;
            this.clnObs.Width = 71;
            // 
            // clnCodArea
            // 
            this.clnCodArea.HeaderText = "CodArea";
            this.clnCodArea.Name = "clnCodArea";
            this.clnCodArea.ReadOnly = true;
            this.clnCodArea.Visible = false;
            this.clnCodArea.Width = 74;
            // 
            // clnArea
            // 
            this.clnArea.HeaderText = "Área";
            this.clnArea.Name = "clnArea";
            this.clnArea.ReadOnly = true;
            this.clnArea.Width = 53;
            // 
            // clnCodEditora
            // 
            this.clnCodEditora.HeaderText = "CodEditora";
            this.clnCodEditora.Name = "clnCodEditora";
            this.clnCodEditora.ReadOnly = true;
            this.clnCodEditora.Visible = false;
            this.clnCodEditora.Width = 88;
            // 
            // clnEditora
            // 
            this.clnEditora.HeaderText = "Editora";
            this.clnEditora.Name = "clnEditora";
            this.clnEditora.ReadOnly = true;
            this.clnEditora.Width = 67;
            // 
            // clnGenero
            // 
            this.clnGenero.HeaderText = "Genero";
            this.clnGenero.Name = "clnGenero";
            this.clnGenero.ReadOnly = true;
            this.clnGenero.Width = 68;
            // 
            // clnAssuntos
            // 
            this.clnAssuntos.HeaderText = "Assuntos";
            this.clnAssuntos.Name = "clnAssuntos";
            this.clnAssuntos.ReadOnly = true;
            this.clnAssuntos.Width = 77;
            // 
            // clnAutores
            // 
            this.clnAutores.HeaderText = "Autores";
            this.clnAutores.Name = "clnAutores";
            this.clnAutores.ReadOnly = true;
            this.clnAutores.Width = 70;
            // 
            // FrmConsultaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.dataGridLivro);
            this.Name = "FrmConsultaLivro";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSelecionar, 0);
            this.Controls.SetChildIndex(this.btnFechar2, 0);
            this.Controls.SetChildIndex(this.dataGridLivro, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGridLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSubtitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnColecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNPags;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataPublicacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLingua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoTombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoMidia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAssuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAutores;
    }
}