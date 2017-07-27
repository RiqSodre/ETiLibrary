namespace Interface.Formularios.Cadastros
{
    partial class FrmPonteRevistaEx
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
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // btnAcao
            // 
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(115, 16);
            this.lblForm.Text = "Cadastro: Revista";
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(63, 83);
            this.lblTexto.Size = new System.Drawing.Size(201, 19);
            this.lblTexto.Text = "Digite aqui o tombo da Revista:";
            // 
            // FrmPonteRevistaEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(327, 223);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPonteRevistaEx";
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
