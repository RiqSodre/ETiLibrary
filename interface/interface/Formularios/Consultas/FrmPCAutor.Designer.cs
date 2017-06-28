namespace Interface.Formularios.Consultas
{
    partial class FrmPCAutor
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
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisa3
            // 
            this.btnPesquisa3.Visible = false;
            // 
            // btnPesquisa2
            // 
            this.btnPesquisa2.Text = "Notação";
            this.btnPesquisa2.Click += new System.EventHandler(this.btnPesquisa2_Click);
            // 
            // btnPesquisa1
            // 
            this.btnPesquisa1.Text = "Nome";
            this.btnPesquisa1.Click += new System.EventHandler(this.btnPesquisa1_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(0, 196);
            this.lblPesquisa.Size = new System.Drawing.Size(348, 16);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(92, 252);
            // 
            // dtPesquisa1
            // 
            this.dtPesquisa1.Location = new System.Drawing.Point(71, 219);
            // 
            // dtPesquisa2
            // 
            this.dtPesquisa2.Location = new System.Drawing.Point(194, 219);
            // 
            // cbPesquisa2
            // 
            this.cbPesquisa2.Location = new System.Drawing.Point(92, 251);
            // 
            // label9
            // 
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.Text = "Consulta: Autor";
            // 
            // cbPesquisa1
            // 
            this.cbPesquisa1.Location = new System.Drawing.Point(92, 219);
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
            this.txtPesquisa.Location = new System.Drawing.Point(92, 217);
            // 
            // FrmPCAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 220);
            this.Name = "FrmPCAutor";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}