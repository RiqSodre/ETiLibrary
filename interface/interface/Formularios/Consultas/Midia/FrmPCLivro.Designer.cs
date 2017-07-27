namespace Interface.Formularios.Consultas
{
    partial class FrmPCLivro
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
            this.btnPesquisa4 = new System.Windows.Forms.Button();
            this.btnPesquisa5 = new System.Windows.Forms.Button();
            this.btnPesquisa6 = new System.Windows.Forms.Button();
            this.btnPesquisa7 = new System.Windows.Forms.Button();
            this.pnlPC.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.pnlPC.Location = new System.Drawing.Point(74, 50);
            // 
            // btnPesquisa3
            // 
            this.btnPesq3.Location = new System.Drawing.Point(74, 136);
            this.btnPesq3.Text = "Autor";
            this.btnPesq3.Click += new System.EventHandler(this.btnPesquisa3_Click);
            // 
            // btnPesquisa2
            // 
            this.btnPesq2.Location = new System.Drawing.Point(74, 107);
            this.btnPesq2.Text = "Assunto";
            this.btnPesq2.Click += new System.EventHandler(this.btnPesquisa2_Click);
            // 
            // btnPesquisa1
            // 
            this.btnPesq1.Location = new System.Drawing.Point(74, 78);
            this.btnPesq1.Text = "Área";
            this.btnPesq1.Click += new System.EventHandler(this.btnPesquisa1_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(0, 297);
            this.lblPesquisa.Size = new System.Drawing.Size(348, 16);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(92, 366);
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtPesquisa1
            // 
            this.dtPesq1.Location = new System.Drawing.Point(71, 332);
            // 
            // dtPesquisa2
            // 
            this.dtPesq2.Location = new System.Drawing.Point(194, 332);
            // 
            // cbPesquisa2
            // 
            this.cbPesq2.Location = new System.Drawing.Point(92, 364);
            // 
            // label9
            // 
            this.lblFrm.Size = new System.Drawing.Size(95, 16);
            this.lblFrm.Text = "Consulta: Livro";
            // 
            // cbPesquisa1
            // 
            this.cbPesq1.Location = new System.Drawing.Point(92, 331);
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
            this.txtPesquisa.Location = new System.Drawing.Point(92, 329);
            this.txtPesquisa.Visible = false;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            // 
            // btnPesquisa4
            // 
            this.btnPesquisa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa4.Location = new System.Drawing.Point(74, 165);
            this.btnPesquisa4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesquisa4.Name = "btnPesquisa4";
            this.btnPesquisa4.Size = new System.Drawing.Size(198, 30);
            this.btnPesquisa4.TabIndex = 121;
            this.btnPesquisa4.Text = "Editora";
            this.btnPesquisa4.UseVisualStyleBackColor = true;
            this.btnPesquisa4.Click += new System.EventHandler(this.btnPesquisa4_Click);
            // 
            // btnPesquisa5
            // 
            this.btnPesquisa5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa5.Location = new System.Drawing.Point(74, 194);
            this.btnPesquisa5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesquisa5.Name = "btnPesquisa5";
            this.btnPesquisa5.Size = new System.Drawing.Size(198, 30);
            this.btnPesquisa5.TabIndex = 122;
            this.btnPesquisa5.Text = "Genêro";
            this.btnPesquisa5.UseVisualStyleBackColor = true;
            this.btnPesquisa5.Click += new System.EventHandler(this.btnPesquisa5_Click);
            // 
            // btnPesquisa6
            // 
            this.btnPesquisa6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa6.Location = new System.Drawing.Point(74, 223);
            this.btnPesquisa6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesquisa6.Name = "btnPesquisa6";
            this.btnPesquisa6.Size = new System.Drawing.Size(198, 30);
            this.btnPesquisa6.TabIndex = 123;
            this.btnPesquisa6.Text = "Título";
            this.btnPesquisa6.UseVisualStyleBackColor = true;
            this.btnPesquisa6.Click += new System.EventHandler(this.btnPesquisa6_Click);
            // 
            // btnPesquisa7
            // 
            this.btnPesquisa7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa7.Location = new System.Drawing.Point(74, 252);
            this.btnPesquisa7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesquisa7.Name = "btnPesquisa7";
            this.btnPesquisa7.Size = new System.Drawing.Size(198, 30);
            this.btnPesquisa7.TabIndex = 124;
            this.btnPesquisa7.Text = "Tombo";
            this.btnPesquisa7.UseVisualStyleBackColor = true;
            this.btnPesquisa7.Click += new System.EventHandler(this.btnPesquisa7_Click);
            // 
            // FrmPCLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 325);
            this.Controls.Add(this.btnPesquisa7);
            this.Controls.Add(this.btnPesquisa6);
            this.Controls.Add(this.btnPesquisa5);
            this.Controls.Add(this.btnPesquisa4);
            this.Name = "FrmPCLivro";
            this.Controls.SetChildIndex(this.pnlForm, 0);
            this.Controls.SetChildIndex(this.pnlPC, 0);
            this.Controls.SetChildIndex(this.btnPesq3, 0);
            this.Controls.SetChildIndex(this.btnPesq1, 0);
            this.Controls.SetChildIndex(this.btnPesq2, 0);
            this.Controls.SetChildIndex(this.lblPesquisa, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.dtPesq1, 0);
            this.Controls.SetChildIndex(this.dtPesq2, 0);
            this.Controls.SetChildIndex(this.cbPesq2, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.cbPesq1, 0);
            this.Controls.SetChildIndex(this.btnPesquisa4, 0);
            this.Controls.SetChildIndex(this.btnPesquisa5, 0);
            this.Controls.SetChildIndex(this.btnPesquisa6, 0);
            this.Controls.SetChildIndex(this.btnPesquisa7, 0);
            this.pnlPC.ResumeLayout(false);
            this.pnlPC.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnPesquisa4;
        public System.Windows.Forms.Button btnPesquisa5;
        public System.Windows.Forms.Button btnPesquisa6;
        public System.Windows.Forms.Button btnPesquisa7;
    }
}