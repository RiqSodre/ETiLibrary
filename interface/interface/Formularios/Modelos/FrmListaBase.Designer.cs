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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTextoForm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadTcc = new System.Windows.Forms.Button();
            this.btnCadRevista = new System.Windows.Forms.Button();
            this.btnCadMap = new System.Windows.Forms.Button();
            this.btnCadLivro = new System.Windows.Forms.Button();
            this.btnCadJornal = new System.Windows.Forms.Button();
            this.btnCadCdDvd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblTextoForm);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 26);
            this.panel2.TabIndex = 101;
            // 
            // lblTextoForm
            // 
            this.lblTextoForm.AutoSize = true;
            this.lblTextoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoForm.ForeColor = System.Drawing.Color.White;
            this.lblTextoForm.Location = new System.Drawing.Point(8, 4);
            this.lblTextoForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoForm.Name = "lblTextoForm";
            this.lblTextoForm.Size = new System.Drawing.Size(42, 16);
            this.lblTextoForm.TabIndex = 44;
            this.lblTextoForm.Text = "Texto";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadTcc);
            this.panel1.Controls.Add(this.btnCadRevista);
            this.panel1.Controls.Add(this.btnCadMap);
            this.panel1.Controls.Add(this.btnCadLivro);
            this.panel1.Controls.Add(this.btnCadJornal);
            this.panel1.Controls.Add(this.btnCadCdDvd);
            this.panel1.Location = new System.Drawing.Point(72, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 202);
            this.panel1.TabIndex = 102;
            // 
            // btnCadTcc
            // 
            this.btnCadTcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadTcc.Location = new System.Drawing.Point(0, 171);
            this.btnCadTcc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCadTcc.Name = "btnCadTcc";
            this.btnCadTcc.Size = new System.Drawing.Size(198, 30);
            this.btnCadTcc.TabIndex = 5;
            this.btnCadTcc.Text = "TCC";
            this.btnCadTcc.UseVisualStyleBackColor = true;
            this.btnCadTcc.Click += new System.EventHandler(this.btnCadTcc_Click);
            // 
            // btnCadRevista
            // 
            this.btnCadRevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadRevista.Location = new System.Drawing.Point(0, 142);
            this.btnCadRevista.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCadRevista.Name = "btnCadRevista";
            this.btnCadRevista.Size = new System.Drawing.Size(198, 30);
            this.btnCadRevista.TabIndex = 4;
            this.btnCadRevista.Text = "Revista";
            this.btnCadRevista.UseVisualStyleBackColor = true;
            this.btnCadRevista.Click += new System.EventHandler(this.btnCadRevista_Click);
            // 
            // btnCadMap
            // 
            this.btnCadMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadMap.Location = new System.Drawing.Point(0, 113);
            this.btnCadMap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCadMap.Name = "btnCadMap";
            this.btnCadMap.Size = new System.Drawing.Size(198, 30);
            this.btnCadMap.TabIndex = 3;
            this.btnCadMap.Text = "Mapa";
            this.btnCadMap.UseVisualStyleBackColor = true;
            this.btnCadMap.Click += new System.EventHandler(this.btnCadMap_Click);
            // 
            // btnCadLivro
            // 
            this.btnCadLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadLivro.Location = new System.Drawing.Point(0, 84);
            this.btnCadLivro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCadLivro.Name = "btnCadLivro";
            this.btnCadLivro.Size = new System.Drawing.Size(198, 30);
            this.btnCadLivro.TabIndex = 2;
            this.btnCadLivro.Text = "Livro";
            this.btnCadLivro.UseVisualStyleBackColor = true;
            this.btnCadLivro.Click += new System.EventHandler(this.btnCadLivro_Click);
            // 
            // btnCadJornal
            // 
            this.btnCadJornal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadJornal.Location = new System.Drawing.Point(0, 55);
            this.btnCadJornal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCadJornal.Name = "btnCadJornal";
            this.btnCadJornal.Size = new System.Drawing.Size(198, 30);
            this.btnCadJornal.TabIndex = 1;
            this.btnCadJornal.Text = "Jornal";
            this.btnCadJornal.UseVisualStyleBackColor = true;
            this.btnCadJornal.Click += new System.EventHandler(this.btnCadJornal_Click);
            // 
            // btnCadCdDvd
            // 
            this.btnCadCdDvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCdDvd.Location = new System.Drawing.Point(0, 26);
            this.btnCadCdDvd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCadCdDvd.Name = "btnCadCdDvd";
            this.btnCadCdDvd.Size = new System.Drawing.Size(198, 30);
            this.btnCadCdDvd.TabIndex = 0;
            this.btnCadCdDvd.Text = "CD/DVD";
            this.btnCadCdDvd.UseVisualStyleBackColor = true;
            this.btnCadCdDvd.Click += new System.EventHandler(this.btnCadCdDvd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblTexto);
            this.panel3.Location = new System.Drawing.Point(72, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 28);
            this.panel3.TabIndex = 103;
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(0, 6);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(198, 16);
            this.lblTexto.TabIndex = 48;
            this.lblTexto.Text = "Texto";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmListaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(340, 390);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmListaBase";
            this.Padding = new System.Windows.Forms.Padding(20, 61, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.DoubleClick += new System.EventHandler(this.FrmListaBase_DoubleClick);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTextoForm;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnCadCdDvd;
        public System.Windows.Forms.Label lblTexto;
        public System.Windows.Forms.Button btnCadTcc;
        public System.Windows.Forms.Button btnCadRevista;
        public System.Windows.Forms.Button btnCadMap;
        public System.Windows.Forms.Button btnCadLivro;
        public System.Windows.Forms.Button btnCadJornal;
    }
}