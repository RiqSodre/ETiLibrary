namespace Interface.Formularios.Consultas
{
    partial class FrmPCEmprestimo
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
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(74, 50);
            // 
            // panel2
            // 
            this.panel2.TabIndex = 5;
            // 
            // btnPesquisa3
            // 
            this.btnPesquisa3.Location = new System.Drawing.Point(74, 136);
            this.btnPesquisa3.TabIndex = 2;
            this.btnPesquisa3.Text = "Multa";
            this.btnPesquisa3.Click += new System.EventHandler(this.btnPesquisa3_Click);
            // 
            // btnPesquisa2
            // 
            this.btnPesquisa2.Location = new System.Drawing.Point(74, 107);
            this.btnPesquisa2.TabIndex = 1;
            this.btnPesquisa2.Text = "Estado";
            this.btnPesquisa2.Click += new System.EventHandler(this.btnPesquisa2_Click);
            // 
            // btnPesquisa1
            // 
            this.btnPesquisa1.Location = new System.Drawing.Point(74, 78);
            this.btnPesquisa1.TabIndex = 0;
            this.btnPesquisa1.Text = "Data";
            this.btnPesquisa1.Click += new System.EventHandler(this.btnPesquisa1_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(0, 236);
            this.lblPesquisa.Size = new System.Drawing.Size(348, 22);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(92, 321);
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtPesquisa1
            // 
            this.dtPesquisa1.Location = new System.Drawing.Point(71, 270);
            // 
            // dtPesquisa2
            // 
            this.dtPesquisa2.Location = new System.Drawing.Point(194, 270);
            // 
            // cbPesquisa2
            // 
            this.cbPesquisa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa2.Location = new System.Drawing.Point(92, 321);
            // 
            // label9
            // 
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.Text = "Consulta: Empréstimo";
            // 
            // cbPesquisa1
            // 
            this.cbPesquisa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa1.Location = new System.Drawing.Point(92, 270);
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
            this.txtPesquisa.Visible = false;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.TabIndex = 0;
            // 
            // btnPesquisa4
            // 
            this.btnPesquisa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa4.Location = new System.Drawing.Point(74, 165);
            this.btnPesquisa4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesquisa4.Name = "btnPesquisa4";
            this.btnPesquisa4.Size = new System.Drawing.Size(198, 30);
            this.btnPesquisa4.TabIndex = 3;
            this.btnPesquisa4.Text = "Pessoa";
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
            this.btnPesquisa5.TabIndex = 4;
            this.btnPesquisa5.Text = "Tombo";
            this.btnPesquisa5.UseVisualStyleBackColor = true;
            this.btnPesquisa5.Click += new System.EventHandler(this.btnPesquisa5_Click);
            // 
            // FrmPCEmprestimo
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 267);
            this.Controls.Add(this.btnPesquisa5);
            this.Controls.Add(this.btnPesquisa4);
            this.Name = "FrmPCEmprestimo";
            this.Controls.SetChildIndex(this.panel2, 0);
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
            this.Controls.SetChildIndex(this.btnPesquisa5, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnPesquisa4;
        public System.Windows.Forms.Button btnPesquisa5;
    }
}