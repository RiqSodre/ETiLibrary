namespace Interface.Formularios.Modelos
{
    partial class FrmPCBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPCBase));
            this.pnlPC = new System.Windows.Forms.Panel();
            this.lblPnlPC = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFrm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesq3 = new System.Windows.Forms.Button();
            this.btnPesq2 = new System.Windows.Forms.Button();
            this.btnPesq1 = new System.Windows.Forms.Button();
            this.lblPesquisa = new MetroFramework.Controls.MetroLabel();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.dtPesq1 = new System.Windows.Forms.DateTimePicker();
            this.dtPesq2 = new System.Windows.Forms.DateTimePicker();
            this.cbPesq2 = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.cbPesq1 = new System.Windows.Forms.ComboBox();
            this.toolBase = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPC.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPC
            // 
            this.pnlPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlPC.Controls.Add(this.lblPnlPC);
            this.pnlPC.Location = new System.Drawing.Point(74, 78);
            this.pnlPC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlPC.Name = "pnlPC";
            this.pnlPC.Size = new System.Drawing.Size(198, 28);
            this.pnlPC.TabIndex = 107;
            // 
            // lblPnlPC
            // 
            this.lblPnlPC.AutoSize = true;
            this.lblPnlPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnlPC.ForeColor = System.Drawing.Color.White;
            this.lblPnlPC.Location = new System.Drawing.Point(54, 7);
            this.lblPnlPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPnlPC.Name = "lblPnlPC";
            this.lblPnlPC.Size = new System.Drawing.Size(90, 16);
            this.lblPnlPC.TabIndex = 48;
            this.lblPnlPC.Text = "Consultar por:";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlForm.Controls.Add(this.lblFrm);
            this.pnlForm.Controls.Add(this.btnFechar);
            this.pnlForm.Location = new System.Drawing.Point(0, 5);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(348, 26);
            this.pnlForm.TabIndex = 105;
            this.pnlForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseMove);
            // 
            // lblFrm
            // 
            this.lblFrm.AutoSize = true;
            this.lblFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm.ForeColor = System.Drawing.Color.White;
            this.lblFrm.Location = new System.Drawing.Point(8, 4);
            this.lblFrm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrm.Name = "lblFrm";
            this.lblFrm.Size = new System.Drawing.Size(63, 16);
            this.lblFrm.TabIndex = 44;
            this.lblFrm.Text = "Consulta:";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(312, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 22);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesq3
            // 
            this.btnPesq3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq3.Location = new System.Drawing.Point(74, 164);
            this.btnPesq3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesq3.Name = "btnPesq3";
            this.btnPesq3.Size = new System.Drawing.Size(198, 30);
            this.btnPesq3.TabIndex = 109;
            this.btnPesq3.Text = "btn3";
            this.btnPesq3.UseVisualStyleBackColor = true;
            // 
            // btnPesq2
            // 
            this.btnPesq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq2.Location = new System.Drawing.Point(74, 135);
            this.btnPesq2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesq2.Name = "btnPesq2";
            this.btnPesq2.Size = new System.Drawing.Size(198, 30);
            this.btnPesq2.TabIndex = 112;
            this.btnPesq2.Text = "btn2";
            this.btnPesq2.UseVisualStyleBackColor = true;
            // 
            // btnPesq1
            // 
            this.btnPesq1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq1.Location = new System.Drawing.Point(74, 106);
            this.btnPesq1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPesq1.Name = "btnPesq1";
            this.btnPesq1.Size = new System.Drawing.Size(198, 30);
            this.btnPesq1.TabIndex = 111;
            this.btnPesq1.Text = "btn1";
            this.btnPesq1.UseVisualStyleBackColor = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPesquisa.Location = new System.Drawing.Point(38, 296);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(283, 23);
            this.lblPesquisa.TabIndex = 49;
            this.lblPesquisa.Text = "Digite aqui:";
            this.lblPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPesquisa.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(92, 389);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(159, 30);
            this.btnPesquisar.TabIndex = 114;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Visible = false;
            // 
            // dtPesq1
            // 
            this.dtPesq1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPesq1.Location = new System.Drawing.Point(71, 323);
            this.dtPesq1.Name = "dtPesq1";
            this.dtPesq1.Size = new System.Drawing.Size(84, 20);
            this.dtPesq1.TabIndex = 116;
            this.dtPesq1.Visible = false;
            // 
            // dtPesq2
            // 
            this.dtPesq2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPesq2.Location = new System.Drawing.Point(194, 323);
            this.dtPesq2.Name = "dtPesq2";
            this.dtPesq2.Size = new System.Drawing.Size(84, 20);
            this.dtPesq2.TabIndex = 117;
            this.dtPesq2.Visible = false;
            // 
            // cbPesq2
            // 
            this.cbPesq2.FormattingEnabled = true;
            this.cbPesq2.Location = new System.Drawing.Point(92, 355);
            this.cbPesq2.Name = "cbPesq2";
            this.cbPesq2.Size = new System.Drawing.Size(159, 21);
            this.cbPesq2.TabIndex = 118;
            this.cbPesq2.Visible = false;
            this.cbPesq2.SelectedIndexChanged += new System.EventHandler(this.cbPesquisa_SelectedIndexChanged);
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
            this.txtPesquisa.Location = new System.Drawing.Point(92, 320);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(159, 23);
            this.txtPesquisa.TabIndex = 119;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPesq1
            // 
            this.cbPesq1.FormattingEnabled = true;
            this.cbPesq1.Location = new System.Drawing.Point(92, 322);
            this.cbPesq1.Name = "cbPesq1";
            this.cbPesq1.Size = new System.Drawing.Size(159, 21);
            this.cbPesq1.TabIndex = 120;
            this.cbPesq1.Visible = false;
            this.cbPesq1.SelectedIndexChanged += new System.EventHandler(this.cbPesquisa_SelectedIndexChanged);
            // 
            // toolBase
            // 
            this.toolBase.AutomaticDelay = 200;
            // 
            // FrmPCBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(345, 448);
            this.Controls.Add(this.cbPesq1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cbPesq2);
            this.Controls.Add(this.dtPesq2);
            this.Controls.Add(this.dtPesq1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnPesq2);
            this.Controls.Add(this.btnPesq1);
            this.Controls.Add(this.btnPesq3);
            this.Controls.Add(this.pnlPC);
            this.Controls.Add(this.pnlForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPCBase";
            this.Resizable = false;
            this.pnlPC.ResumeLayout(false);
            this.pnlPC.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlPC;
        public System.Windows.Forms.Label lblPnlPC;
        public System.Windows.Forms.Panel pnlForm;
        public System.Windows.Forms.Button btnPesq3;
        public System.Windows.Forms.Button btnPesq2;
        public System.Windows.Forms.Button btnPesq1;
        public MetroFramework.Controls.MetroButton btnPesquisar;
        public System.Windows.Forms.DateTimePicker dtPesq1;
        public System.Windows.Forms.DateTimePicker dtPesq2;
        public System.Windows.Forms.ComboBox cbPesq2;
        public System.Windows.Forms.Label lblFrm;
        public System.Windows.Forms.ComboBox cbPesq1;
        public MetroFramework.Controls.MetroTextBox txtPesquisa;
        public System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolBase;
        public MetroFramework.Controls.MetroLabel lblPesquisa;
    }
}