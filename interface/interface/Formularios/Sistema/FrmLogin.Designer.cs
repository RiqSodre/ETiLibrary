namespace Interface.Formularios.Sistema
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxSistema = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.lblRecSenha = new MetroFramework.Controls.MetroLink();
            this.lblSistema = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLogo.BackgroundImage")));
            this.picboxLogo.Location = new System.Drawing.Point(192, 36);
            this.picboxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(95, 112);
            this.picboxLogo.TabIndex = 26;
            this.picboxLogo.TabStop = false;
            // 
            // picBoxSistema
            // 
            this.picBoxSistema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxSistema.BackgroundImage")));
            this.picBoxSistema.Location = new System.Drawing.Point(72, 162);
            this.picBoxSistema.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxSistema.Name = "picBoxSistema";
            this.picBoxSistema.Size = new System.Drawing.Size(347, 26);
            this.picBoxSistema.TabIndex = 25;
            this.picBoxSistema.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(404, 7);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(33, 31);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(445, 7);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 31);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsuario.Location = new System.Drawing.Point(35, 228);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(136, 20);
            this.lblUsuario.TabIndex = 99999;
            this.lblUsuario.Text = "Nome do Usuário:";
            this.lblUsuario.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSenha.Location = new System.Drawing.Point(35, 300);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 20);
            this.lblSenha.TabIndex = 999999;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblRecSenha
            // 
            this.lblRecSenha.DisplayFocus = true;
            this.lblRecSenha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRecSenha.Location = new System.Drawing.Point(157, 373);
            this.lblRecSenha.Margin = new System.Windows.Forms.Padding(4);
            this.lblRecSenha.Name = "lblRecSenha";
            this.lblRecSenha.Size = new System.Drawing.Size(167, 28);
            this.lblRecSenha.TabIndex = 0;
            this.lblRecSenha.TabStop = false;
            this.lblRecSenha.Text = "Esqueci minha senha";
            this.lblRecSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblRecSenha.UseCustomForeColor = true;
            this.lblRecSenha.UseSelectable = true;
            this.lblRecSenha.Click += new System.EventHandler(this.lblRecSenha_Click);
            this.lblRecSenha.MouseLeave += new System.EventHandler(this.lblRecSenha_MouseLeave);
            this.lblRecSenha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblRecSenha_MouseMove);
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSistema.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSistema.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSistema.Location = new System.Drawing.Point(11, 522);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(249, 17);
            this.lblSistema.TabIndex = 999999;
            this.lblSistema.Text = "2017 Copyrigth - Essentials Technology";
            this.lblSistema.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblSistema.UseCustomForeColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(33, 327);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(419, 37);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(33, 255);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(419, 37);
            this.txtNome.TabIndex = 0;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEntrar.Location = new System.Drawing.Point(33, 411);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(420, 46);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(481, 551);
            this.ControlBox = false;
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.lblRecSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.picBoxSistema);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.PictureBox picBoxSistema;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFechar;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroLink lblRecSenha;
        private MetroFramework.Controls.MetroLabel lblSistema;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private MetroFramework.Controls.MetroButton btnEntrar;
    }
}