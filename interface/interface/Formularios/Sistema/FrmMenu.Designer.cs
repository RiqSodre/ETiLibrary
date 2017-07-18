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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioBibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infraestruturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.áreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jornalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genêroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acervoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infraestruturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jornalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraviosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relátoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confiuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.lblMensagem = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblHora = new MetroFramework.Controls.MetroLabel();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAcervo = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEspaco = new System.Windows.Forms.ToolStripStatusLabel();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.menuPrincipal.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.relátoriosToolStripMenuItem,
            this.confiuraçõesToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(957, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.TabStop = true;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.acervoToolStripMenuItem,
            this.infraestruturaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alunosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem,
            this.funcionárioBibliotecaToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // funcionárioBibliotecaToolStripMenuItem
            // 
            this.funcionárioBibliotecaToolStripMenuItem.Enabled = false;
            this.funcionárioBibliotecaToolStripMenuItem.Name = "funcionárioBibliotecaToolStripMenuItem";
            this.funcionárioBibliotecaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.funcionárioBibliotecaToolStripMenuItem.Text = "Funcionário Biblioteca";
            this.funcionárioBibliotecaToolStripMenuItem.Click += new System.EventHandler(this.funcionárioBibliotecaToolStripMenuItem_Click);
            // 
            // acervoToolStripMenuItem
            // 
            this.acervoToolStripMenuItem.Name = "acervoToolStripMenuItem";
            this.acervoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.acervoToolStripMenuItem.Text = "Acervo";
            this.acervoToolStripMenuItem.Click += new System.EventHandler(this.acervoToolStripMenuItem_Click);
            // 
            // infraestruturaToolStripMenuItem
            // 
            this.infraestruturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.turmasToolStripMenuItem,
            this.toolStripSeparator2,
            this.áreaToolStripMenuItem,
            this.jornalToolStripMenuItem,
            this.revistaToolStripMenuItem,
            this.editoraToolStripMenuItem,
            this.genêroToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.extraviosToolStripMenuItem,
            this.assuntosToolStripMenuItem});
            this.infraestruturaToolStripMenuItem.Name = "infraestruturaToolStripMenuItem";
            this.infraestruturaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.infraestruturaToolStripMenuItem.Text = "Infraestrutura";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Enabled = false;
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Enabled = false;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Enabled = false;
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // áreaToolStripMenuItem
            // 
            this.áreaToolStripMenuItem.Name = "áreaToolStripMenuItem";
            this.áreaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.áreaToolStripMenuItem.Text = "Área";
            this.áreaToolStripMenuItem.Click += new System.EventHandler(this.áreaToolStripMenuItem_Click);
            // 
            // jornalToolStripMenuItem
            // 
            this.jornalToolStripMenuItem.Name = "jornalToolStripMenuItem";
            this.jornalToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.jornalToolStripMenuItem.Text = "Jornal";
            this.jornalToolStripMenuItem.Click += new System.EventHandler(this.jornalToolStripMenuItem_Click);
            // 
            // revistaToolStripMenuItem
            // 
            this.revistaToolStripMenuItem.Name = "revistaToolStripMenuItem";
            this.revistaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.revistaToolStripMenuItem.Text = "Revista";
            this.revistaToolStripMenuItem.Click += new System.EventHandler(this.revistaToolStripMenuItem_Click);
            // 
            // editoraToolStripMenuItem
            // 
            this.editoraToolStripMenuItem.Name = "editoraToolStripMenuItem";
            this.editoraToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editoraToolStripMenuItem.Text = "Editora";
            this.editoraToolStripMenuItem.Click += new System.EventHandler(this.editoraToolStripMenuItem_Click);
            // 
            // genêroToolStripMenuItem
            // 
            this.genêroToolStripMenuItem.Name = "genêroToolStripMenuItem";
            this.genêroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.genêroToolStripMenuItem.Text = "Genêro";
            this.genêroToolStripMenuItem.Click += new System.EventHandler(this.genêroToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // extraviosToolStripMenuItem
            // 
            this.extraviosToolStripMenuItem.Name = "extraviosToolStripMenuItem";
            this.extraviosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.extraviosToolStripMenuItem.Text = "Extravios";
            this.extraviosToolStripMenuItem.Click += new System.EventHandler(this.extraviosToolStripMenuItem_Click);
            // 
            // assuntosToolStripMenuItem
            // 
            this.assuntosToolStripMenuItem.Name = "assuntosToolStripMenuItem";
            this.assuntosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.assuntosToolStripMenuItem.Text = "Assuntos";
            this.assuntosToolStripMenuItem.Click += new System.EventHandler(this.assuntosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem1,
            this.funcionáriosToolStripMenuItem1,
            this.acervoToolStripMenuItem1,
            this.emprestimoToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.infraestruturaToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // alunosToolStripMenuItem1
            // 
            this.alunosToolStripMenuItem1.Name = "alunosToolStripMenuItem1";
            this.alunosToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.alunosToolStripMenuItem1.Text = "Alunos";
            this.alunosToolStripMenuItem1.Click += new System.EventHandler(this.alunosToolStripMenuItem1_Click);
            // 
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.funcionáriosToolStripMenuItem1.Text = "Funcionário";
            this.funcionáriosToolStripMenuItem1.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // acervoToolStripMenuItem1
            // 
            this.acervoToolStripMenuItem1.Name = "acervoToolStripMenuItem1";
            this.acervoToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.acervoToolStripMenuItem1.Text = "Acervo";
            this.acervoToolStripMenuItem1.Click += new System.EventHandler(this.acervoToolStripMenuItem1_Click);
            // 
            // emprestimoToolStripMenuItem
            // 
            this.emprestimoToolStripMenuItem.Name = "emprestimoToolStripMenuItem";
            this.emprestimoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.emprestimoToolStripMenuItem.Text = "Empréstimo";
            this.emprestimoToolStripMenuItem.Click += new System.EventHandler(this.emprestimoToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // infraestruturaToolStripMenuItem1
            // 
            this.infraestruturaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargosToolStripMenuItem1,
            this.cursosToolStripMenuItem1,
            this.turmasToolStripMenuItem1,
            this.toolStripSeparator1,
            this.autoresToolStripMenuItem1,
            this.editorasToolStripMenuItem,
            this.jornalToolStripMenuItem1,
            this.revistasToolStripMenuItem,
            this.extraviosToolStripMenuItem1});
            this.infraestruturaToolStripMenuItem1.Name = "infraestruturaToolStripMenuItem1";
            this.infraestruturaToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.infraestruturaToolStripMenuItem1.Text = "Infraestrutura";
            // 
            // cargosToolStripMenuItem1
            // 
            this.cargosToolStripMenuItem1.Name = "cargosToolStripMenuItem1";
            this.cargosToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.cargosToolStripMenuItem1.Text = "Cargos";
            this.cargosToolStripMenuItem1.Click += new System.EventHandler(this.cargosToolStripMenuItem1_Click);
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            this.cursosToolStripMenuItem1.Click += new System.EventHandler(this.cursosToolStripMenuItem1_Click);
            // 
            // turmasToolStripMenuItem1
            // 
            this.turmasToolStripMenuItem1.Name = "turmasToolStripMenuItem1";
            this.turmasToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.turmasToolStripMenuItem1.Text = "Turmas";
            this.turmasToolStripMenuItem1.Click += new System.EventHandler(this.turmasToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // autoresToolStripMenuItem1
            // 
            this.autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            this.autoresToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.autoresToolStripMenuItem1.Text = "Autores";
            this.autoresToolStripMenuItem1.Click += new System.EventHandler(this.autoresToolStripMenuItem1_Click);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            this.editorasToolStripMenuItem.Click += new System.EventHandler(this.editorasToolStripMenuItem_Click);
            // 
            // jornalToolStripMenuItem1
            // 
            this.jornalToolStripMenuItem1.Name = "jornalToolStripMenuItem1";
            this.jornalToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.jornalToolStripMenuItem1.Text = "Jornal";
            this.jornalToolStripMenuItem1.Click += new System.EventHandler(this.jornalToolStripMenuItem1_Click);
            // 
            // revistasToolStripMenuItem
            // 
            this.revistasToolStripMenuItem.Name = "revistasToolStripMenuItem";
            this.revistasToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.revistasToolStripMenuItem.Text = "Revistas";
            this.revistasToolStripMenuItem.Click += new System.EventHandler(this.revistasToolStripMenuItem_Click);
            // 
            // extraviosToolStripMenuItem1
            // 
            this.extraviosToolStripMenuItem1.Name = "extraviosToolStripMenuItem1";
            this.extraviosToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.extraviosToolStripMenuItem1.Text = "Extravios";
            this.extraviosToolStripMenuItem1.Click += new System.EventHandler(this.extraviosToolStripMenuItem1_Click);
            // 
            // relátoriosToolStripMenuItem
            // 
            this.relátoriosToolStripMenuItem.Name = "relátoriosToolStripMenuItem";
            this.relátoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relátoriosToolStripMenuItem.Text = "Relatórios";
            this.relátoriosToolStripMenuItem.Click += new System.EventHandler(this.relátoriosToolStripMenuItem_Click);
            // 
            // confiuraçõesToolStripMenuItem
            // 
            this.confiuraçõesToolStripMenuItem.Name = "confiuraçõesToolStripMenuItem";
            this.confiuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.confiuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // pnlBase
            // 
            this.pnlBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBase.BackColor = System.Drawing.Color.White;
            this.pnlBase.Controls.Add(this.btnCadAluno);
            this.pnlBase.Controls.Add(this.lblData);
            this.pnlBase.Controls.Add(this.lblMensagem);
            this.pnlBase.Controls.Add(this.lblNome);
            this.pnlBase.Controls.Add(this.lblHora);
            this.pnlBase.Controls.Add(this.btnEmprestimo);
            this.pnlBase.Controls.Add(this.btnConfiguracoes);
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
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMensagem.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMensagem.Location = new System.Drawing.Point(3, 21);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(117, 19);
            this.lblMensagem.TabIndex = 12;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnEmprestimo
            // 
            this.btnEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEmprestimo.BackColor = System.Drawing.Color.White;
            this.btnEmprestimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmprestimo.BackgroundImage")));
            this.btnEmprestimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Location = new System.Drawing.Point(0, 191);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(123, 96);
            this.btnEmprestimo.TabIndex = 2;
            this.btnEmprestimo.Text = "&Empréstimo";
            this.btnEmprestimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmprestimo.UseVisualStyleBackColor = false;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfiguracoes.BackColor = System.Drawing.Color.White;
            this.btnConfiguracoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.BackgroundImage")));
            this.btnConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 389);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(123, 96);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(153, 24);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(120, 22);
            this.miniToolStrip.TabIndex = 13;
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
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acervoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infraestruturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem áreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jornalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genêroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraviosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acervoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infraestruturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jornalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem revistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraviosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relátoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confiuraçõesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAcervo;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblVersao;
        private System.Windows.Forms.ToolStripStatusLabel lblEspaco;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.StatusStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioBibliotecaToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblHora;
        private MetroFramework.Controls.MetroLabel lblMensagem;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblData;
        private System.Windows.Forms.ToolStripMenuItem emprestimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.Button btnCadAluno;
    }
}