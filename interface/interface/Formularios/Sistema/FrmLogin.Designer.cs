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
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLogo.BackgroundImage")));
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picboxLogo.Location = new System.Drawing.Point(105, 50);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(150, 150);
            this.picboxLogo.TabIndex = 26;
            this.picboxLogo.TabStop = false;
            // 
            // picBoxSistema
            // 
            this.picBoxSistema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxSistema.BackgroundImage")));
            this.picBoxSistema.Location = new System.Drawing.Point(54, 205);
            this.picBoxSistema.Name = "picBoxSistema";
            this.picBoxSistema.Size = new System.Drawing.Size(260, 21);
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
            this.btnMin.Location = new System.Drawing.Point(303, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
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
            this.btnFechar.Location = new System.Drawing.Point(334, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsuario.Location = new System.Drawing.Point(20, 247);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(131, 19);
            this.lblUsuario.TabIndex = 99999;
            this.lblUsuario.Text = "Nome do Usuário:";
            this.lblUsuario.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSenha.Location = new System.Drawing.Point(20, 307);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 19);
            this.lblSenha.TabIndex = 999999;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblRecSenha
            // 
            this.lblRecSenha.DisplayFocus = true;
            this.lblRecSenha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRecSenha.Location = new System.Drawing.Point(118, 365);
            this.lblRecSenha.Name = "lblRecSenha";
            this.lblRecSenha.Size = new System.Drawing.Size(125, 23);
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
            this.lblSistema.Location = new System.Drawing.Point(8, 476);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(221, 15);
            this.lblSistema.TabIndex = 999999;
            this.lblSistema.Text = "2017 Copyrigth - Essentials Technology";
            this.lblSistema.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblSistema.UseCustomForeColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEntrar.Location = new System.Drawing.Point(25, 396);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(315, 37);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(25, 267);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(315, 25);
            this.txtNome.TabIndex = 0;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(25, 327);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(315, 25);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(361, 500);
            this.ControlBox = false;
            this.Controls.Add(this.picBoxSistema);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.lblRecSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.picboxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
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
        private MetroFramework.Controls.MetroButton btnEntrar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtSenha;
    }
}