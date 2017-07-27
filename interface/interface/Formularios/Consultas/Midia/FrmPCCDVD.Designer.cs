namespace Interface.Formularios.Consultas
{
    partial class FrmPCCDVD
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
            this.pnlPC.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesq3
            // 
            this.btnPesq3.Text = "Tombo";
            this.btnPesq3.Click += new System.EventHandler(this.btnPesq3_Click);
            // 
            // btnPesq2
            // 
            this.btnPesq2.Text = "Título";
            this.btnPesq2.Click += new System.EventHandler(this.btnPesq2_Click);
            // 
            // btnPesq1
            // 
            this.btnPesq1.Text = "Área";
            this.btnPesq1.Click += new System.EventHandler(this.btnPesq1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(92, 268);
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtPesq1
            // 
            this.dtPesq1.Location = new System.Drawing.Point(71, 233);
            // 
            // dtPesq2
            // 
            this.dtPesq2.Location = new System.Drawing.Point(194, 233);
            // 
            // cbPesq2
            // 
            this.cbPesq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq2.Location = new System.Drawing.Point(92, 265);
            // 
            // lblFrm
            // 
            this.lblFrm.Size = new System.Drawing.Size(128, 16);
            this.lblFrm.Text = "Consulta: CD e DVD";
            // 
            // cbPesq1
            // 
            this.cbPesq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq1.Location = new System.Drawing.Point(92, 233);
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
            this.txtPesquisa.Location = new System.Drawing.Point(92, 233);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(2, 207);
            this.lblPesquisa.Size = new System.Drawing.Size(341, 22);
            // 
            // FrmPCCDVD
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(345, 235);
            this.Name = "FrmPCCDVD";
            this.pnlPC.ResumeLayout(false);
            this.pnlPC.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}