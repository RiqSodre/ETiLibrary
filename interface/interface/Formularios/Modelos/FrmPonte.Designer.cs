﻿namespace Interface.Formularios.Modelos
{
    partial class FrmPonte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPonte));
            this.txtTexto = new MetroFramework.Controls.MetroTextBox();
            this.btnAcao = new MetroFramework.Controls.MetroButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblForm = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblTexto = new MetroFramework.Controls.MetroLabel();
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
            this.txtTexto.Location = new System.Drawing.Point(51, 116);
            this.txtTexto.MaxLength = 32767;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.PasswordChar = '\0';
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTexto.SelectedText = "";
            this.txtTexto.SelectionLength = 0;
            this.txtTexto.SelectionStart = 0;
            this.txtTexto.ShortcutsEnabled = true;
            this.txtTexto.Size = new System.Drawing.Size(225, 23);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.UseSelectable = true;
            this.txtTexto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTexto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(229, 177);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(75, 23);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Text = "Carregar";
            this.btnAcao.UseSelectable = true;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(298, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 22);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(7, 4);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(45, 16);
            this.lblForm.TabIndex = 48;
            this.lblForm.Text = "Nome";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlForm.Controls.Add(this.lblForm);
            this.pnlForm.Controls.Add(this.btnFechar);
            this.pnlForm.Location = new System.Drawing.Point(0, 5);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(329, 26);
            this.pnlForm.TabIndex = 2;
            this.pnlForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseMove);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTexto.Location = new System.Drawing.Point(144, 83);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(41, 19);
            this.lblTexto.TabIndex = 217;
            this.lblTexto.Text = "Texto";
            // 
            // FrmPonte
            // 
            this.AcceptButton = this.btnAcao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(327, 223);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnAcao);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.txtTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "FrmPonte";
            this.Resizable = false;
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox txtTexto;
        public MetroFramework.Controls.MetroButton btnAcao;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Label lblForm;
        public System.Windows.Forms.Panel pnlForm;
        public MetroFramework.Controls.MetroLabel lblTexto;
    }
}