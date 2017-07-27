namespace Interface.Formularios.Cadastros.Infraestrutura
{
    partial class FrmPonteTurma
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
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new MetroFramework.Controls.MetroLabel();
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
            this.txtTexto.Location = new System.Drawing.Point(51, 100);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(229, 224);
            this.btnAcao.TabIndex = 2;
            this.btnAcao.Text = "Salvar";
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            // 
            // lblForm
            // 
            this.lblForm.Size = new System.Drawing.Size(108, 16);
            this.lblForm.Text = "Cadastro: Turma";
            // 
            // pnlForm
            // 
            this.pnlForm.TabIndex = 3;
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(84, 70);
            this.lblTexto.Size = new System.Drawing.Size(158, 19);
            this.lblTexto.Text = "Insira o nome da Turma:";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Matuitino",
            "Vespertino",
            "Noturno"});
            this.cbPeriodo.Location = new System.Drawing.Point(89, 171);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(149, 23);
            this.cbPeriodo.TabIndex = 1;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPeriodo.Location = new System.Drawing.Point(134, 141);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(58, 19);
            this.lblPeriodo.TabIndex = 219;
            this.lblPeriodo.Text = "Período:";
            // 
            // FrmPonteTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPonteTurma";
            this.Controls.SetChildIndex(this.txtTexto, 0);
            this.Controls.SetChildIndex(this.pnlForm, 0);
            this.Controls.SetChildIndex(this.btnAcao, 0);
            this.Controls.SetChildIndex(this.lblTexto, 0);
            this.Controls.SetChildIndex(this.lblPeriodo, 0);
            this.Controls.SetChildIndex(this.cbPeriodo, 0);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPeriodo;
        private MetroFramework.Controls.MetroLabel lblPeriodo;
    }
}
