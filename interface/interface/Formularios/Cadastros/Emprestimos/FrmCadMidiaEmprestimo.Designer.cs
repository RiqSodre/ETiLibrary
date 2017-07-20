namespace Interface.Formularios.Cadastros
{
    partial class FrmCadMidiaEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadMidiaEmprestimo));
            this.pnl = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.dateTDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnCofirmar = new MetroFramework.Controls.MetroButton();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl.Controls.Add(this.lblForm);
            this.pnl.Controls.Add(this.btnFechar);
            this.pnl.Location = new System.Drawing.Point(0, 5);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(300, 26);
            this.pnl.TabIndex = 103;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(4, 4);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(179, 16);
            this.lblForm.TabIndex = 48;
            this.lblForm.Text = "Empréstimo: Confirmar midia";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(275, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 22);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(98, 47);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(170, 23);
            this.txtDescricao.TabIndex = 105;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(24, 52);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 106;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(24, 88);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(104, 13);
            this.lblDataDevolucao.TabIndex = 107;
            this.lblDataDevolucao.Text = "Data de devolução: ";
            // 
            // dateTDataDevolucao
            // 
            this.dateTDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTDataDevolucao.Location = new System.Drawing.Point(168, 85);
            this.dateTDataDevolucao.Name = "dateTDataDevolucao";
            this.dateTDataDevolucao.Size = new System.Drawing.Size(100, 20);
            this.dateTDataDevolucao.TabIndex = 108;
            // 
            // btnCofirmar
            // 
            this.btnCofirmar.Location = new System.Drawing.Point(193, 117);
            this.btnCofirmar.Name = "btnCofirmar";
            this.btnCofirmar.Size = new System.Drawing.Size(75, 23);
            this.btnCofirmar.TabIndex = 110;
            this.btnCofirmar.Text = "Confirmar";
            this.btnCofirmar.UseSelectable = true;
            this.btnCofirmar.Click += new System.EventHandler(this.btnCofirmar_Click);
            // 
            // FrmCadMidiaEmprestimo
            // 
            this.AcceptButton = this.btnCofirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(302, 150);
            this.Controls.Add(this.btnCofirmar);
            this.Controls.Add(this.dateTDataDevolucao);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.pnl);
            this.Name = "FrmCadMidiaEmprestimo";
            this.Resizable = false;
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnl;
        public System.Windows.Forms.Label lblForm;
        public System.Windows.Forms.Button btnFechar;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.DateTimePicker dateTDataDevolucao;
        private MetroFramework.Controls.MetroButton btnCofirmar;
    }
}