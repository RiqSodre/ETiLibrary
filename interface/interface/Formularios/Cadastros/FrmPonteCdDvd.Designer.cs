namespace Interface.Formularios.Cadastros
{
    partial class FrmPonteCdDvd
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
            this.txtTexto.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.txtTexto.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtTexto.CustomButton.Name = "";
            this.txtTexto.CustomButton.Size = new System.Drawing.Size(28, 26);
            this.txtTexto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTexto.CustomButton.TabIndex = 1;
            this.txtTexto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTexto.CustomButton.UseSelectable = true;
            this.txtTexto.CustomButton.Visible = false;
            this.txtTexto.Lines = new string[0];
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(71, 102);
            this.lblTexto.Size = new System.Drawing.Size(279, 24);
            this.lblTexto.Text = "Digite aqui o tombo do CD/DVD:";
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
            this.lblForm.Size = new System.Drawing.Size(154, 20);
            this.lblForm.Text = "Cadastro: CD/DVD";
            // 
            // FrmPonteCdDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 274);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPonteCdDvd";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}