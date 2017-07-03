namespace Interface.Formularios.Consultas
{
    partial class FrmPCFuncionario
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
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.panel3.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisa3
            // 
            this.btnPesquisa3.Text = "CPF";
            this.btnPesquisa3.Click += new System.EventHandler(this.btnPesquisa3_Click);
            // 
            // btnPesquisa2
            // 
            this.btnPesquisa2.Text = "Código";
            this.btnPesquisa2.Click += new System.EventHandler(this.btnPesquisa2_Click);
            // 
            // btnPesquisa1
            // 
            this.btnPesquisa1.Text = "Cargo";
            this.btnPesquisa1.Click += new System.EventHandler(this.btnPesquisa1_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(0, 234);
            this.lblPesquisa.Size = new System.Drawing.Size(348, 16);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(92, 297);
            // 
            // dtPesquisa1
            // 
            this.dtPesquisa1.Location = new System.Drawing.Point(71, 263);
            // 
            // dtPesquisa2
            // 
            this.dtPesquisa2.Location = new System.Drawing.Point(194, 263);
            // 
            // cbPesquisa2
            // 
            this.cbPesquisa2.Location = new System.Drawing.Point(92, 295);
            // 
            // label9
            // 
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.Text = "Consulta: Funcionário";
            // 
            // cbPesquisa1
            // 
            this.cbPesquisa1.Location = new System.Drawing.Point(92, 262);
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
            this.txtPesquisa.Location = new System.Drawing.Point(92, 260);
            this.txtPesquisa.Visible = false;
            // 
            // btnPesquisa4
            // 
            this.btnPesquisa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa4.Location = new System.Drawing.Point(74, 193);
            this.btnPesquisa4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesquisa4.Name = "btnPesquisa4";
            this.btnPesquisa4.Size = new System.Drawing.Size(198, 30);
            this.btnPesquisa4.TabIndex = 122;
            this.btnPesquisa4.Text = "Nome";
            this.btnPesquisa4.UseVisualStyleBackColor = true;
            this.btnPesquisa4.Click += new System.EventHandler(this.btnPesquisa4_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(92, 263);
            this.txtCPF.Mask = "000\\.000\\.000\\-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(159, 20);
            this.txtCPF.TabIndex = 123;
            this.txtCPF.Visible = false;
            // 
            // FrmPCFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 264);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnPesquisa4);
            this.Name = "FrmPCFuncionario";
            this.Controls.SetChildIndex(this.pnlForm, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnPesquisa3, 0);
            this.Controls.SetChildIndex(this.btnPesquisa1, 0);
            this.Controls.SetChildIndex(this.btnPesquisa2, 0);
            this.Controls.SetChildIndex(this.lblPesquisa, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.dtPesquisa1, 0);
            this.Controls.SetChildIndex(this.dtPesquisa2, 0);
            this.Controls.SetChildIndex(this.cbPesquisa2, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.cbPesquisa1, 0);
            this.Controls.SetChildIndex(this.btnPesquisa4, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPesquisa4;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}