﻿using BLL;
using DTO.Pessoas;
using Interface.Properties;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Sistema
{
    public partial class FrmLogin : MetroForm
    {
        private AutenticacaoBLL autenticaBLL = new AutenticacaoBLL();
        private PessoaBLL pessoaBLL = new PessoaBLL();

        //Construtor Padrão
        public FrmLogin()
        {
            InitializeComponent();
        }
        //Verifica se as textbox estão ok
        private bool CaixasOK()
        {
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show(this, "O campo Nome do Usuário é obrigatório.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            else if (txtSenha.Text.Length == 0)
            {
                MessageBox.Show(this, "O campo Senha é obrigatório.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        //Fecha o formulario
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Minimiza o formulario
        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Faz o login no sistema
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CaixasOK())
                {
                    int codUsuario;
                    codUsuario = autenticaBLL.AutenticarUsuario(txtNome.Text, autenticaBLL.CripSenha(txtSenha.Text));
                    if (codUsuario == 0)
                    {
                        MessageBox.Show(this, "Usuário não cadastrado no sistema.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Funcionario func = pessoaBLL.FuncionarioBiblioSelect(codUsuario);
                        Settings.Default.Nome = func.Nome;
                        Settings.Default.Login = func.Login;
                        Settings.Default.Senha = func.Senha;
                        Settings.Default.Admin = func.Admin;
                        Settings.Default.CodPessoa = (int)func.CodPessoa;
                        DialogResult = DialogResult.Yes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }
        //Abre o formulario de recuperar senha
        private void lblRecSenha_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRecSenha frmRecSenha = new FrmRecSenha();
                frmRecSenha.ShowDialog();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    lblRecSenha_Click(sender, e);
                }
            }
        }
        //Muda a cor da label ao passar o mouse
        private void lblRecSenha_MouseMove(object sender, MouseEventArgs e)
        {
            lblRecSenha.ForeColor = Color.LightGray;
        }
        //Volta a cor da label após passar o mouse
        private void lblRecSenha_MouseLeave(object sender, EventArgs e)
        {
            lblRecSenha.ForeColor = SystemColors.ButtonShadow;
        }
    }
}
