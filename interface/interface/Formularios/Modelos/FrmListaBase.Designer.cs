namespace Interface.Formularios.Modelos
{
    partial class FrmListaBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaBase));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnCadTcc = new System.Windows.Forms.Button();
            this.btnCadRevista = new System.Windows.Forms.Button();
            this.btnCadMap = new System.Windows.Forms.Button();
            this.btnCadLivro = new System.Windows.Forms.Button();
            this.btnCadJornal = new System.Windows.Forms.Button();
            this.btnCadCdDvd = new System.Windows.Forms.Button();
            this.pnlLbl = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnlLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlForm.Controls.Add(this.lblForm);
            this.pnlForm.Controls.Add(this.btnFechar);
            this.pnlForm.Location = new System.Drawing.Point(0, 5);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(458, 32);
            this.pnlForm.TabIndex = 101;
            this.pnlForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseMove);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(11, 5);
            this.lblForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(50, 20);
            this.lblForm.TabIndex = 44;
            this.lblForm.Text = "Texto";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(416, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 27);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnCadTcc);
            this.pnl.Controls.Add(this.btnCadRevista);
            this.pnl.Controls.Add(this.btnCadMap);
            this.pnl.Controls.Add(this.btnCadLivro);
            this.pnl.Controls.Add(this.btnCadJornal);
            this.pnl.Controls.Add(this.btnCadCdDvd);
            this.pnl.Location = new System.Drawing.Point(94, 79);
            this.pnl.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(264, 249);
            this.pnl.TabIndex = 102;
            // 
            // btnCadTcc
            // 
            this.btnCadTcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadTcc.Location = new System.Drawing.Point(0, 210);
            this.btnCadTcc.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCadTcc.Name = "btnCadTcc";
            this.btnCadTcc.Size = new System.Drawing.Size(264, 37);
            this.btnCadTcc.TabIndex = 5;
            this.btnCadTcc.Text = "TCC";
            this.btnCadTcc.UseVisualStyleBackColor = true;
            this.btnCadTcc.Click += new System.EventHandler(this.btnCadTcc_Click);
            // 
            // btnCadRevista
            // 
            this.btnCadRevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadRevista.Location = new System.Drawing.Point(0, 175);
            this.btnCadRevista.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCadRevista.Name = "btnCadRevista";
            this.btnCadRevista.Size = new System.Drawing.Size(264, 37);
            this.btnCadRevista.TabIndex = 4;
            this.btnCadRevista.Text = "Revista";
            this.btnCadRevista.UseVisualStyleBackColor = true;
            this.btnCadRevista.Click += new System.EventHandler(this.btnCadRevista_Click);
            // 
            // btnCadMap
            // 
            this.btnCadMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadMap.Location = new System.Drawing.Point(0, 139);
            this.btnCadMap.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCadMap.Name = "btnCadMap";
            this.btnCadMap.Size = new System.Drawing.Size(264, 37);
            this.btnCadMap.TabIndex = 3;
            this.btnCadMap.Text = "Mapa";
            this.btnCadMap.UseVisualStyleBackColor = true;
            this.btnCadMap.Click += new System.EventHandler(this.btnCadMap_Click);
            // 
            // btnCadLivro
            // 
            this.btnCadLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadLivro.Location = new System.Drawing.Point(0, 103);
            this.btnCadLivro.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCadLivro.Name = "btnCadLivro";
            this.btnCadLivro.Size = new System.Drawing.Size(264, 37);
            this.btnCadLivro.TabIndex = 2;
            this.btnCadLivro.Text = "Livro";
            this.btnCadLivro.UseVisualStyleBackColor = true;
            this.btnCadLivro.Click += new System.EventHandler(this.btnCadLivro_Click);
            // 
            // btnCadJornal
            // 
            this.btnCadJornal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadJornal.Location = new System.Drawing.Point(0, 68);
            this.btnCadJornal.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCadJornal.Name = "btnCadJornal";
            this.btnCadJornal.Size = new System.Drawing.Size(264, 37);
            this.btnCadJornal.TabIndex = 1;
            this.btnCadJornal.Text = "Jornal";
            this.btnCadJornal.UseVisualStyleBackColor = true;
            this.btnCadJornal.Click += new System.EventHandler(this.btnCadJornal_Click);
            // 
            // btnCadCdDvd
            // 
            this.btnCadCdDvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCdDvd.Location = new System.Drawing.Point(0, 32);
            this.btnCadCdDvd.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCadCdDvd.Name = "btnCadCdDvd";
            this.btnCadCdDvd.Size = new System.Drawing.Size(264, 37);
            this.btnCadCdDvd.TabIndex = 0;
            this.btnCadCdDvd.Text = "CD/DVD";
            this.btnCadCdDvd.UseVisualStyleBackColor = true;
            this.btnCadCdDvd.Click += new System.EventHandler(this.btnCadCdDvd_Click);
            // 
            // pnlLbl
            // 
            this.pnlLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLbl.Controls.Add(this.lblTexto);
            this.pnlLbl.Location = new System.Drawing.Point(94, 77);
            this.pnlLbl.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pnlLbl.Name = "pnlLbl";
            this.pnlLbl.Size = new System.Drawing.Size(264, 34);
            this.pnlLbl.TabIndex = 103;
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(0, 7);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(264, 20);
            this.lblTexto.TabIndex = 48;
            this.lblTexto.Text = "Texto";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmListaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(450, 390);
            this.Controls.Add(this.pnlLbl);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlForm);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "FrmListaBase";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnlLbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Panel pnl;
        public System.Windows.Forms.Panel pnlLbl;
        public System.Windows.Forms.Button btnCadCdDvd;
        public System.Windows.Forms.Label lblTexto;
        public System.Windows.Forms.Button btnCadTcc;
        public System.Windows.Forms.Button btnCadRevista;
        public System.Windows.Forms.Button btnCadMap;
        public System.Windows.Forms.Button btnCadLivro;
        public System.Windows.Forms.Button btnCadJornal;
    }
}