using System;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using Interface.Formularios.Cadastros;
using Interface.Formularios.Consultas;
using Interface.Properties;
using Interface.Formularios.Cadastros.Infraestrutura;

namespace Interface.Formularios.Sistema
{
    public partial class FrmMenu : Form
    {
        private bool existe;

        //Construtor Padrão
        public FrmMenu()
        {
            InitializeComponent();
        }
        //Formulario Load
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                lblNome.Text = Settings.Default.Nome.Substring(0, Settings.Default.Nome.IndexOf(" "));
                if(Settings.Default.Admin == true)
                {
                    funcionarioToolStripMenuItem.Enabled = true;
                    funcionárioBibliotecaToolStripMenuItem.Enabled = true;
                    cursosToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de alunos
        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadAluno")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadAluno cadaluno = new FrmCadAluno();
                    cadaluno.MdiParent = this;
                    cadaluno.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: "+ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de funcionários
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadFuncionario")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadFuncionario cadfuncionario = new FrmCadFuncionario();
                    cadfuncionario.MdiParent = this;
                    cadfuncionario.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de funcionários da biblioteca
        private void funcionárioBibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadFuncionarioBiblioteca")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadFuncionarioBiblioteca cadfuncionario = new FrmCadFuncionarioBiblioteca();
                    cadfuncionario.MdiParent = this;
                    cadfuncionario.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de acervo
        private void acervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmListaBase")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmListaBase lista = new FrmListaBase(EnumModo.Cadastro, "Cadastro: Acervo", "Cadastrar: ");
                    lista.MdiParent = this;
                    lista.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de cursos
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadCurso")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadCursoT cadcurso = new FrmCadCursoT();
                    cadcurso.MdiParent = this;
                    cadcurso.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de áreas
        private void áreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadArea")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadArea cadarea = new FrmCadArea();
                    cadarea.MdiParent = this;
                    cadarea.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de jornais
        private void jornalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadJornal")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadJornal cadjornal = new FrmCadJornal();
                    cadjornal.MdiParent = this;
                    cadjornal.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de revistas -Implementar
        private void revistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadRevista")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadRevista cadrevista = new FrmCadRevista();
                    cadrevista.MdiParent = this;
                    cadrevista.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de editoras
        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadEditora")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadEditora cadeditora = new FrmCadEditora();
                    cadeditora.MdiParent = this;
                    cadeditora.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de gêneros
        private void genêroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadGenero")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadGenero cadgenero = new FrmCadGenero();
                    cadgenero.MdiParent = this;
                    cadgenero.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de autores
        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadAutor")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadAutor cadautor = new FrmCadAutor();
                    cadautor.MdiParent = this;
                    cadautor.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de extravios
        private void extraviosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         /*   try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadExtravio")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadExtravio cadextravio = new FrmCadExtravio();
                    cadextravio.MdiParent = this;
                    cadextravio.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }*/
        }
        //Abre o form de cadastro de assuntos
        private void assuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmCadAssunto")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadAssunto cadassunto = new FrmCadAssunto();
                    cadassunto.MdiParent = this;
                    cadassunto.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de alunos
        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmConsultaAluno")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmPCAluno ctAluno = new FrmPCAluno();
                    ctAluno.MdiParent = this;
                    ctAluno.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de funcionários
        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmConsultaFuncionario")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmConsultaFuncionario ctFuncionario = new FrmConsultaFuncionario();
                    ctFuncionario.MdiParent = this;
                    ctFuncionario.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de acervo
        private void acervoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmListaBase")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmListaBase lista = new FrmListaBase(EnumModo.Consulta, "Consulta: Acervo", "Consultar: ");
                    lista.MdiParent = this;
                    lista.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de cursos -Implementar
        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de reservas -Implementar
        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de empréstimos
        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmPCEmprestimo")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmPCEmprestimo frmPC = new FrmPCEmprestimo();
                    frmPC.MdiParent = this;
                    frmPC.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de autores -Implementar
        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de editoras -Implementar
        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de jornais -Implementar
        private void jornalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de revistas -Implementar
        private void revistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de consulta de extravios -Implementar
        private void extraviosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }   
        //Abre o form ponte de empréstimo
        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                existe = false;
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FrmPonteEmprestimo")
                    {
                        existe = VerificaForm(form, existe);
                        break;
                    }
                }
                if (!existe)
                {
                    FrmPonteEmprestimo frmPonteEmprestimo = new FrmPonteEmprestimo();
                    frmPonteEmprestimo.MdiParent = this;
                    frmPonteEmprestimo.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o form de configuração -Implementar
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            try
            {
                //implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Botão lateral Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Abre o form ponte de relatórios -Implementar
        private void relátoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Confirmar saida do programa
        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult sair = MessageBox.Show(this, "Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (sair == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Verifica o estado do form encontrado
        private bool VerificaForm(Form form, bool existe)
        {
            form.Activate();
            if (form.Visible == false)
            {
                form.Close();
            }
            else
            {
                existe = true;
            }
            return existe;
        }
        //Relógio
        private void hora_Tick(object sender, EventArgs e)
        {
            try
            {
                lblHora.Text = DateTime.Now.ToShortTimeString();
                lblData.Text = DateTime.Now.ToShortDateString();
                int hora = Convert.ToInt32(lblHora.Text.Substring(0, 2));
                if(hora > 17 || hora < 6)
                {
                    lblMensagem.Text = "Boa noite";
                }
                else if (hora > 5 && hora < 12)
                {
                    lblMensagem.Text = "Bom dia";
                }
                else
                {
                    lblMensagem.Text = "Bom tarde";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
    }
}
