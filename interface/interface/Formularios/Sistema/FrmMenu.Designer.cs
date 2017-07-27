using System.Windows.Forms;

namespace Interface.Formularios.Sistema
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.inicioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.funcMenuCad = new System.Windows.Forms.ToolStripMenuItem();
            this.funcCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.funcBCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.acervoCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infraCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoTCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSeparadoCad = new System.Windows.Forms.ToolStripSeparator();
            this.areaCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.assuntoCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.autorCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editoraCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.extravCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generoCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.jornalCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.revistaCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pcMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.funcPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.acervoPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.emprePCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infraPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoTPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSeparadorPC = new System.Windows.Forms.ToolStripSeparator();
            this.autorPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editoraPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.extravPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.jornalPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.revistaPCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.relatiorioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.lblMsg = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblHora = new MetroFramework.Controls.MetroLabel();
            this.btnEmpre = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAcervo = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEspaco = new System.Windows.Forms.ToolStripStatusLabel();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.reservaCadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioMenu,
            this.cadMenu,
            this.pcMenu,
            this.relatiorioMenu,
            this.configMenu});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(957, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.TabStop = true;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // inicioMenu
            // 
            this.inicioMenu.Name = "inicioMenu";
            this.inicioMenu.Size = new System.Drawing.Size(48, 20);
            this.inicioMenu.Text = "Inicio";
            // 
            // cadMenu
            // 
            this.cadMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoCadMenu,
            this.funcMenuCad,
            this.acervoCadMenu,
            this.reservaCadMenu,
            this.infraCadMenu});
            this.cadMenu.Name = "cadMenu";
            this.cadMenu.Size = new System.Drawing.Size(71, 20);
            this.cadMenu.Text = "Cadastros";
            // 
            // alunoCadMenu
            // 
            this.alunoCadMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.alunoCadMenu.Name = "alunoCadMenu";
            this.alunoCadMenu.Size = new System.Drawing.Size(152, 22);
            this.alunoCadMenu.Text = "Alunos";
            this.alunoCadMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alunoCadMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.alunoCadMenu.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // funcMenuCad
            // 
            this.funcMenuCad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcCadMenu,
            this.funcBCadMenu});
            this.funcMenuCad.Name = "funcMenuCad";
            this.funcMenuCad.Size = new System.Drawing.Size(152, 22);
            this.funcMenuCad.Text = "Funcionários";
            // 
            // funcCadMenu
            // 
            this.funcCadMenu.Name = "funcCadMenu";
            this.funcCadMenu.Size = new System.Drawing.Size(192, 22);
            this.funcCadMenu.Text = "Funcionário";
            this.funcCadMenu.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // funcBCadMenu
            // 
            this.funcBCadMenu.Enabled = false;
            this.funcBCadMenu.Name = "funcBCadMenu";
            this.funcBCadMenu.Size = new System.Drawing.Size(192, 22);
            this.funcBCadMenu.Text = "Funcionário Biblioteca";
            this.funcBCadMenu.Click += new System.EventHandler(this.funcionárioBibliotecaToolStripMenuItem_Click);
            // 
            // acervoCadMenu
            // 
            this.acervoCadMenu.Name = "acervoCadMenu";
            this.acervoCadMenu.Size = new System.Drawing.Size(152, 22);
            this.acervoCadMenu.Text = "Acervo";
            this.acervoCadMenu.Click += new System.EventHandler(this.acervoToolStripMenuItem_Click);
            // 
            // infraCadMenu
            // 
            this.infraCadMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoTCadMenu,
            this.toolSeparadoCad,
            this.areaCadMenu,
            this.assuntoCadMenu,
            this.autorCadMenu,
            this.editoraCadMenu,
            this.extravCadMenu,
            this.generoCadMenu,
            this.jornalCadMenu,
            this.revistaCadMenu});
            this.infraCadMenu.Name = "infraCadMenu";
            this.infraCadMenu.Size = new System.Drawing.Size(152, 22);
            this.infraCadMenu.Text = "Infraestrutura";
            // 
            // cursoTCadMenu
            // 
            this.cursoTCadMenu.Enabled = false;
            this.cursoTCadMenu.Name = "cursoTCadMenu";
            this.cursoTCadMenu.Size = new System.Drawing.Size(162, 22);
            this.cursoTCadMenu.Text = "Cursos e Turmas";
            this.cursoTCadMenu.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // toolSeparadoCad
            // 
            this.toolSeparadoCad.Name = "toolSeparadoCad";
            this.toolSeparadoCad.Size = new System.Drawing.Size(159, 6);
            // 
            // areaCadMenu
            // 
            this.areaCadMenu.Name = "areaCadMenu";
            this.areaCadMenu.Size = new System.Drawing.Size(162, 22);
            this.areaCadMenu.Text = "Área";
            this.areaCadMenu.Click += new System.EventHandler(this.áreaToolStripMenuItem_Click);
            // 
            // assuntoCadMenu
            // 
            this.assuntoCadMenu.Name = "assuntoCadMenu";
            this.assuntoCadMenu.Size = new System.Drawing.Size(162, 22);
            this.assuntoCadMenu.Text = "Assuntos";
            this.assuntoCadMenu.Click += new System.EventHandler(this.assuntosToolStripMenuItem_Click);
            // 
            // autorCadMenu
            // 
            this.autorCadMenu.Name = "autorCadMenu";
            this.autorCadMenu.Size = new System.Drawing.Size(162, 22);
            this.autorCadMenu.Text = "Autores";
            this.autorCadMenu.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // editoraCadMenu
            // 
            this.editoraCadMenu.Name = "editoraCadMenu";
            this.editoraCadMenu.Size = new System.Drawing.Size(162, 22);
            this.editoraCadMenu.Text = "Editora";
            this.editoraCadMenu.Click += new System.EventHandler(this.editoraToolStripMenuItem_Click);
            // 
            // extravCadMenu
            // 
            this.extravCadMenu.Name = "extravCadMenu";
            this.extravCadMenu.Size = new System.Drawing.Size(162, 22);
            this.extravCadMenu.Text = "Extravios";
            this.extravCadMenu.Click += new System.EventHandler(this.extraviosToolStripMenuItem_Click);
            // 
            // generoCadMenu
            // 
            this.generoCadMenu.Name = "generoCadMenu";
            this.generoCadMenu.Size = new System.Drawing.Size(162, 22);
            this.generoCadMenu.Text = "Gênero";
            this.generoCadMenu.Click += new System.EventHandler(this.genêroToolStripMenuItem_Click);
            // 
            // jornalCadMenu
            // 
            this.jornalCadMenu.Name = "jornalCadMenu";
            this.jornalCadMenu.Size = new System.Drawing.Size(162, 22);
            this.jornalCadMenu.Text = "Jornal";
            this.jornalCadMenu.Click += new System.EventHandler(this.jornalToolStripMenuItem_Click);
            // 
            // revistaCadMenu
            // 
            this.revistaCadMenu.Name = "revistaCadMenu";
            this.revistaCadMenu.Size = new System.Drawing.Size(162, 22);
            this.revistaCadMenu.Text = "Revista";
            this.revistaCadMenu.Click += new System.EventHandler(this.revistaToolStripMenuItem_Click);
            // 
            // pcMenu
            // 
            this.pcMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoPCMenu,
            this.funcPCMenu,
            this.acervoPCMenu,
            this.emprePCMenu,
            this.reservaPCMenu,
            this.infraPCMenu});
            this.pcMenu.Name = "pcMenu";
            this.pcMenu.Size = new System.Drawing.Size(71, 20);
            this.pcMenu.Text = "Consultas";
            // 
            // alunoPCMenu
            // 
            this.alunoPCMenu.Name = "alunoPCMenu";
            this.alunoPCMenu.Size = new System.Drawing.Size(152, 22);
            this.alunoPCMenu.Text = "Alunos";
            this.alunoPCMenu.Click += new System.EventHandler(this.alunosToolStripMenuItem1_Click);
            // 
            // funcPCMenu
            // 
            this.funcPCMenu.Name = "funcPCMenu";
            this.funcPCMenu.Size = new System.Drawing.Size(152, 22);
            this.funcPCMenu.Text = "Funcionário";
            this.funcPCMenu.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // acervoPCMenu
            // 
            this.acervoPCMenu.Name = "acervoPCMenu";
            this.acervoPCMenu.Size = new System.Drawing.Size(152, 22);
            this.acervoPCMenu.Text = "Acervo";
            this.acervoPCMenu.Click += new System.EventHandler(this.acervoToolStripMenuItem1_Click);
            // 
            // emprePCMenu
            // 
            this.emprePCMenu.Name = "emprePCMenu";
            this.emprePCMenu.Size = new System.Drawing.Size(152, 22);
            this.emprePCMenu.Text = "Empréstimo";
            this.emprePCMenu.Click += new System.EventHandler(this.emprestimoToolStripMenuItem_Click);
            // 
            // reservaPCMenu
            // 
            this.reservaPCMenu.Name = "reservaPCMenu";
            this.reservaPCMenu.Size = new System.Drawing.Size(152, 22);
            this.reservaPCMenu.Text = "Reservas";
            this.reservaPCMenu.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // infraPCMenu
            // 
            this.infraPCMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoTPCMenu,
            this.toolSeparadorPC,
            this.autorPCMenu,
            this.editoraPCMenu,
            this.extravPCMenu,
            this.jornalPCMenu,
            this.revistaPCMenu});
            this.infraPCMenu.Name = "infraPCMenu";
            this.infraPCMenu.Size = new System.Drawing.Size(152, 22);
            this.infraPCMenu.Text = "Infraestrutura";
            // 
            // cursoTPCMenu
            // 
            this.cursoTPCMenu.Name = "cursoTPCMenu";
            this.cursoTPCMenu.Size = new System.Drawing.Size(162, 22);
            this.cursoTPCMenu.Text = "Cursos e Turmas";
            this.cursoTPCMenu.Click += new System.EventHandler(this.cursosToolStripMenuItem1_Click);
            // 
            // toolSeparadorPC
            // 
            this.toolSeparadorPC.Name = "toolSeparadorPC";
            this.toolSeparadorPC.Size = new System.Drawing.Size(159, 6);
            // 
            // autorPCMenu
            // 
            this.autorPCMenu.Name = "autorPCMenu";
            this.autorPCMenu.Size = new System.Drawing.Size(162, 22);
            this.autorPCMenu.Text = "Autores";
            this.autorPCMenu.Click += new System.EventHandler(this.autoresToolStripMenuItem1_Click);
            // 
            // editoraPCMenu
            // 
            this.editoraPCMenu.Name = "editoraPCMenu";
            this.editoraPCMenu.Size = new System.Drawing.Size(162, 22);
            this.editoraPCMenu.Text = "Editoras";
            this.editoraPCMenu.Click += new System.EventHandler(this.editorasToolStripMenuItem_Click);
            // 
            // extravPCMenu
            // 
            this.extravPCMenu.Name = "extravPCMenu";
            this.extravPCMenu.Size = new System.Drawing.Size(162, 22);
            this.extravPCMenu.Text = "Extravios";
            this.extravPCMenu.Click += new System.EventHandler(this.extraviosToolStripMenuItem1_Click);
            // 
            // jornalPCMenu
            // 
            this.jornalPCMenu.Name = "jornalPCMenu";
            this.jornalPCMenu.Size = new System.Drawing.Size(162, 22);
            this.jornalPCMenu.Text = "Jornal";
            this.jornalPCMenu.Click += new System.EventHandler(this.jornalToolStripMenuItem1_Click);
            // 
            // revistaPCMenu
            // 
            this.revistaPCMenu.Name = "revistaPCMenu";
            this.revistaPCMenu.Size = new System.Drawing.Size(162, 22);
            this.revistaPCMenu.Text = "Revistas";
            this.revistaPCMenu.Click += new System.EventHandler(this.revistasToolStripMenuItem_Click);
            // 
            // relatiorioMenu
            // 
            this.relatiorioMenu.Name = "relatiorioMenu";
            this.relatiorioMenu.Size = new System.Drawing.Size(71, 20);
            this.relatiorioMenu.Text = "Relatórios";
            this.relatiorioMenu.Click += new System.EventHandler(this.relátoriosToolStripMenuItem_Click);
            // 
            // configMenu
            // 
            this.configMenu.Name = "configMenu";
            this.configMenu.Size = new System.Drawing.Size(96, 20);
            this.configMenu.Text = "Configurações";
            // 
            // pnlBase
            // 
            this.pnlBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBase.BackColor = System.Drawing.Color.White;
            this.pnlBase.Controls.Add(this.btnCadAluno);
            this.pnlBase.Controls.Add(this.lblData);
            this.pnlBase.Controls.Add(this.lblMsg);
            this.pnlBase.Controls.Add(this.lblNome);
            this.pnlBase.Controls.Add(this.lblHora);
            this.pnlBase.Controls.Add(this.btnEmpre);
            this.pnlBase.Controls.Add(this.btnConfig);
            this.pnlBase.Controls.Add(this.btnSair);
            this.pnlBase.Controls.Add(this.btnAcervo);
            this.pnlBase.Location = new System.Drawing.Point(834, 12);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(123, 670);
            this.pnlBase.TabIndex = 10;
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCadAluno.BackColor = System.Drawing.Color.White;
            this.btnCadAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadAluno.BackgroundImage")));
            this.btnCadAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadAluno.FlatAppearance.BorderSize = 0;
            this.btnCadAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadAluno.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCadAluno.Location = new System.Drawing.Point(0, 85);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(123, 96);
            this.btnCadAluno.TabIndex = 1;
            this.btnCadAluno.Text = "&Cadastro Alunos";
            this.btnCadAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadAluno.UseVisualStyleBackColor = false;
            this.btnCadAluno.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblData.Location = new System.Drawing.Point(11, 609);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 23);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMsg.Location = new System.Drawing.Point(3, 21);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(117, 19);
            this.lblMsg.TabIndex = 12;
            this.lblMsg.Text = "Mensagem";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNome.Location = new System.Drawing.Point(3, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 19);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHora.Location = new System.Drawing.Point(13, 634);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 19);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEmpre
            // 
            this.btnEmpre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEmpre.BackColor = System.Drawing.Color.White;
            this.btnEmpre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpre.BackgroundImage")));
            this.btnEmpre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpre.FlatAppearance.BorderSize = 0;
            this.btnEmpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpre.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnEmpre.Location = new System.Drawing.Point(0, 191);
            this.btnEmpre.Name = "btnEmpre";
            this.btnEmpre.Size = new System.Drawing.Size(123, 96);
            this.btnEmpre.TabIndex = 2;
            this.btnEmpre.Text = "&Empréstimo";
            this.btnEmpre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpre.UseVisualStyleBackColor = false;
            this.btnEmpre.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfig.BackColor = System.Drawing.Color.White;
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnConfig.Location = new System.Drawing.Point(0, 389);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(123, 96);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnSair.Location = new System.Drawing.Point(0, 488);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 96);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcervo
            // 
            this.btnAcervo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAcervo.BackColor = System.Drawing.Color.White;
            this.btnAcervo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcervo.BackgroundImage")));
            this.btnAcervo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcervo.FlatAppearance.BorderSize = 0;
            this.btnAcervo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcervo.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnAcervo.Location = new System.Drawing.Point(0, 290);
            this.btnAcervo.Name = "btnAcervo";
            this.btnAcervo.Size = new System.Drawing.Size(123, 96);
            this.btnAcervo.TabIndex = 3;
            this.btnAcervo.Text = "&Acervo";
            this.btnAcervo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcervo.UseVisualStyleBackColor = false;
            this.btnAcervo.Click += new System.EventHandler(this.acervoToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersao,
            this.lblEspaco});
            this.statusBar.Location = new System.Drawing.Point(0, 672);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(957, 22);
            this.statusBar.TabIndex = 11;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblVersao
            // 
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(67, 17);
            this.lblVersao.Text = "Versão Beta";
            // 
            // lblEspaco
            // 
            this.lblEspaco.Name = "lblEspaco";
            this.lblEspaco.Size = new System.Drawing.Size(875, 17);
            this.lblEspaco.Spring = true;
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // reservaCadMenu
            // 
            this.reservaCadMenu.Name = "reservaCadMenu";
            this.reservaCadMenu.Size = new System.Drawing.Size(152, 22);
            this.reservaCadMenu.Text = "Reserva";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 694);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.pnlBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(973, 733);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Tech. Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem inicioMenu;
        private System.Windows.Forms.ToolStripMenuItem cadMenu;
        private System.Windows.Forms.ToolStripMenuItem alunoCadMenu;
        private System.Windows.Forms.ToolStripMenuItem funcMenuCad;
        private System.Windows.Forms.ToolStripMenuItem acervoCadMenu;
        private System.Windows.Forms.ToolStripMenuItem infraCadMenu;
        private System.Windows.Forms.ToolStripMenuItem cursoTCadMenu;
        private System.Windows.Forms.ToolStripSeparator toolSeparadoCad;
        private System.Windows.Forms.ToolStripMenuItem areaCadMenu;
        private System.Windows.Forms.ToolStripMenuItem jornalCadMenu;
        private System.Windows.Forms.ToolStripMenuItem revistaCadMenu;
        private System.Windows.Forms.ToolStripMenuItem editoraCadMenu;
        private System.Windows.Forms.ToolStripMenuItem generoCadMenu;
        private System.Windows.Forms.ToolStripMenuItem autorCadMenu;
        private System.Windows.Forms.ToolStripMenuItem extravCadMenu;
        private System.Windows.Forms.ToolStripMenuItem assuntoCadMenu;
        private System.Windows.Forms.ToolStripMenuItem pcMenu;
        private System.Windows.Forms.ToolStripMenuItem alunoPCMenu;
        private System.Windows.Forms.ToolStripMenuItem funcPCMenu;
        private System.Windows.Forms.ToolStripMenuItem acervoPCMenu;
        private System.Windows.Forms.ToolStripMenuItem infraPCMenu;
        private System.Windows.Forms.ToolStripMenuItem cursoTPCMenu;
        private System.Windows.Forms.ToolStripSeparator toolSeparadorPC;
        private System.Windows.Forms.ToolStripMenuItem autorPCMenu;
        private System.Windows.Forms.ToolStripMenuItem editoraPCMenu;
        private System.Windows.Forms.ToolStripMenuItem jornalPCMenu;
        private System.Windows.Forms.ToolStripMenuItem revistaPCMenu;
        private System.Windows.Forms.ToolStripMenuItem extravPCMenu;
        private System.Windows.Forms.ToolStripMenuItem relatiorioMenu;
        private System.Windows.Forms.ToolStripMenuItem configMenu;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Button btnEmpre;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAcervo;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblVersao;
        private System.Windows.Forms.ToolStripStatusLabel lblEspaco;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.ToolStripMenuItem funcCadMenu;
        private System.Windows.Forms.ToolStripMenuItem funcBCadMenu;
        private MetroFramework.Controls.MetroLabel lblHora;
        private MetroFramework.Controls.MetroLabel lblMsg;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblData;
        private System.Windows.Forms.ToolStripMenuItem emprePCMenu;
        private System.Windows.Forms.ToolStripMenuItem reservaPCMenu;
        private System.Windows.Forms.Button btnCadAluno;
        private ToolStripMenuItem reservaCadMenu;
    }
}