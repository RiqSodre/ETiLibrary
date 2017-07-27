namespace Interface.Formularios.Modelos
{
    partial class FrmConsultaBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaBase));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelec = new MetroFramework.Controls.MetroButton();
            this.btnFechar2 = new MetroFramework.Controls.MetroButton();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlForm.Controls.Add(this.lblForm);
            this.pnlForm.Controls.Add(this.btnFechar);
            this.pnlForm.Location = new System.Drawing.Point(-4, 5);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(666, 26);
            this.pnlForm.TabIndex = 104;
            this.pnlForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseMove);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(7, 4);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(63, 16);
            this.lblForm.TabIndex = 48;
            this.lblForm.Text = "Consulta:";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(635, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 22);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(463, 387);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 30);
            this.btnSelec.TabIndex = 106;
            this.btnSelec.Text = "Selecionar";
            this.btnSelec.UseSelectable = true;
            // 
            // btnFechar2
            // 
            this.btnFechar2.Location = new System.Drawing.Point(553, 387);
            this.btnFechar2.Name = "btnFechar2";
            this.btnFechar2.Size = new System.Drawing.Size(75, 30);
            this.btnFechar2.TabIndex = 107;
            this.btnFechar2.Text = "Fechar";
            this.btnFechar2.UseSelectable = true;
            this.btnFechar2.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmConsultaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.btnFechar2);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.pnlForm);
            this.Name = "FrmConsultaBase";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlForm;
        public System.Windows.Forms.Button btnFechar;
        public MetroFramework.Controls.MetroButton btnSelec;
        public MetroFramework.Controls.MetroButton btnFechar2;
        public System.Windows.Forms.Label lblForm;
    }
}