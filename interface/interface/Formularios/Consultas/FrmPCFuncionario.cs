using BLL;
using DTO.Infraestrutura_de_Pessoa;
using Interface.Formularios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCFuncionario : FrmPCBase
    {
        CargoBLL cargoBLL = new CargoBLL();
        CargoList cargoList = new CargoList();

        public FrmPCFuncionario()
        {
            InitializeComponent();
        }

        //Botão consulta Cargo
        private void btnPesquisa1_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 345;
                Height = 349;
                LimpaForm();
                lblPesquisa.Text = "Selecione o Cargo do Funcionário:";
                lblPesquisa.Visible = true;
                cbPesquisa1.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 297);
                cbPesquisa1.DisplayMember = "Descricao";
                cbPesquisa1.ValueMember = "CodCargo";

                cbPesquisa1.DataSource = cargoBLL.CarregaCargos("SELECT CodCargo, Descricao FROM tblCargo");
                if (cbPesquisa1.Items.Count > 0)
                {
                    cbPesquisa1.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Código
        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 345;
                Height = 349;
                LimpaForm();
                lblPesquisa.Text = "Digite o Código do Funcionário:";
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 297);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta CPF
        private void btnPesquisa3_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 345;
                Height = 349;
                LimpaForm();
                lblPesquisa.Text = "Digite o CPF do Funcionário:";
                lblPesquisa.Visible = true;
                txtCPF.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 297);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consutlta Nome
        private void btnPesquisa4_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 345;
                Height = 349;
                LimpaForm();
                lblPesquisa.Text = "Digite o Nome do Funcionário:";
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 297);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
