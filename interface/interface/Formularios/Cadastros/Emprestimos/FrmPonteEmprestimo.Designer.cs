namespace Interface.Formularios.Cadastros
{
    partial class FrmPonteEmprestimo
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
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            // 
            // 
            // 
            this.txtTexto.CustomButton.Image = null;
            this.txtTexto.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtTexto.CustomButton.Name = "";
            this.txtTexto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTexto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTexto.CustomButton.TabIndex = 1;
            this.txtTexto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTexto.CustomButton.UseSelectable = true;
            this.txtTexto.CustomButton.Visible = false;
            this.txtTexto.Lines = new string[0];
            // 
            // btnAcao
            // 
            this.btnAcao.Text = "Avançar";
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.TabIndex = 2;
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(139, 16);
            this.lblForm.TabIndex = 1000;
            this.lblForm.Text = "Emprestimo: Carregar";
            // 
            // pnlForm
            // 
            this.pnlForm.TabIndex = 1000;
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(78, 83);
            this.lblTexto.Size = new System.Drawing.Size(170, 19);
            this.lblTexto.TabIndex = 1000;
            this.lblTexto.Text = "Digite o código da pessoa:";
            // 
            // FrmPonteEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(327, 223);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPonteEmprestimo";
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
