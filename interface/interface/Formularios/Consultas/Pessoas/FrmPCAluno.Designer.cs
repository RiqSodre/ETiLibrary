namespace Interface.Formularios.Consultas
{
    partial class FrmPCAluno
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
            this.btnPesq4 = new System.Windows.Forms.Button();
            this.btnPesq5 = new System.Windows.Forms.Button();
            this.pnlPC.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPC
            // 
            this.pnlPC.Location = new System.Drawing.Point(74, 50);
            // 
            // pnlForm
            // 
            this.pnlForm.TabIndex = 8;
            // 
            // btnPesq3
            // 
            this.btnPesq3.Location = new System.Drawing.Point(74, 136);
            this.btnPesq3.TabIndex = 2;
            this.btnPesq3.Text = "Nome";
            this.btnPesq3.Click += new System.EventHandler(this.btnPesq3_Click);
            // 
            // btnPesq2
            // 
            this.btnPesq2.Location = new System.Drawing.Point(74, 107);
            this.btnPesq2.TabIndex = 1;
            this.btnPesq2.Text = "Curso";
            this.btnPesq2.Click += new System.EventHandler(this.btnPesq2_Click);
            // 
            // btnPesq1
            // 
            this.btnPesq1.Location = new System.Drawing.Point(74, 78);
            this.btnPesq1.TabIndex = 0;
            this.btnPesq1.Text = "Código";
            this.btnPesq1.Click += new System.EventHandler(this.btnPesq1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(92, 310);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtPesq1
            // 
            this.dtPesq1.Location = new System.Drawing.Point(74, 270);
            // 
            // dtPesq2
            // 
            this.dtPesq2.Location = new System.Drawing.Point(188, 270);
            // 
            // cbPesq2
            // 
            this.cbPesq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbPesq2.Location = new System.Drawing.Point(92, 308);
            this.cbPesq2.Size = new System.Drawing.Size(159, 23);
            // 
            // lblFrm
            // 
            this.lblFrm.Size = new System.Drawing.Size(100, 16);
            this.lblFrm.Text = "Consulta: Aluno";
            // 
            // cbPesq1
            // 
            this.cbPesq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbPesq1.Location = new System.Drawing.Point(92, 270);
            this.cbPesq1.Size = new System.Drawing.Size(159, 23);
            this.cbPesq1.SelectedValueChanged += new System.EventHandler(this.cbPesquisa1_SelectedValueChanged);
            // 
            // txtPesquisa
            // 
            // 
            // 
            // 
            this.txtPesquisa.CustomButton.Image = null;
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(92, 270);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(2, 236);
            this.lblPesquisa.Size = new System.Drawing.Size(341, 22);
            // 
            // btnPesq4
            // 
            this.btnPesq4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq4.Location = new System.Drawing.Point(74, 165);
            this.btnPesq4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesq4.Name = "btnPesq4";
            this.btnPesq4.Size = new System.Drawing.Size(198, 30);
            this.btnPesq4.TabIndex = 3;
            this.btnPesq4.Text = "RM";
            this.btnPesq4.UseVisualStyleBackColor = true;
            this.btnPesq4.Click += new System.EventHandler(this.btnPesq4_Click);
            // 
            // btnPesq5
            // 
            this.btnPesq5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq5.Location = new System.Drawing.Point(74, 194);
            this.btnPesq5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesq5.Name = "btnPesq5";
            this.btnPesq5.Size = new System.Drawing.Size(198, 30);
            this.btnPesq5.TabIndex = 4;
            this.btnPesq5.Text = "Turma";
            this.btnPesq5.UseVisualStyleBackColor = true;
            this.btnPesq5.Click += new System.EventHandler(this.btnPesq5_Click);
            // 
            // FrmPCAluno
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(345, 267);
            this.Controls.Add(this.btnPesq5);
            this.Controls.Add(this.btnPesq4);
            this.Name = "FrmPCAluno";
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.cbPesq2, 0);
            this.Controls.SetChildIndex(this.pnlForm, 0);
            this.Controls.SetChildIndex(this.pnlPC, 0);
            this.Controls.SetChildIndex(this.btnPesq3, 0);
            this.Controls.SetChildIndex(this.btnPesq1, 0);
            this.Controls.SetChildIndex(this.btnPesq2, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.lblPesquisa, 0);
            this.Controls.SetChildIndex(this.cbPesq1, 0);
            this.Controls.SetChildIndex(this.dtPesq1, 0);
            this.Controls.SetChildIndex(this.dtPesq2, 0);
            this.Controls.SetChildIndex(this.btnPesq4, 0);
            this.Controls.SetChildIndex(this.btnPesq5, 0);
            this.pnlPC.ResumeLayout(false);
            this.pnlPC.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnPesq4;
        public System.Windows.Forms.Button btnPesq5;
    }
}