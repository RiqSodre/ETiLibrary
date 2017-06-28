using BLL;
using DTO.Emprestimos;
using DTO.Infraestrutura_de_Midia;
using DTO.Midia;
using DTO.Multa;
using Interface.Properties;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadEmprestimo : MetroFramework.Forms.MetroForm
    {
        private Emprestimo emprestimoBase = new Emprestimo();
        private MidiaEmprestimo midiaEmprestimoBase = new MidiaEmprestimo();
        private EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private MultaBLL multaBLL = new MultaBLL();

        public MidiaEmprestimo MidiaEmprestimoBase
        {
            get
            {
                return midiaEmprestimoBase;
            }

            set
            {
                midiaEmprestimoBase = value;
            }
        }

        public FrmCadEmprestimo()
        {
            InitializeComponent();
        }

        //Carrega o emprestimo existente ou um novo emprestimo
        public FrmCadEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                InitializeComponent();
                emprestimoBase = emprestimo;

                txtCodigo.Text = emprestimo.Usuario.CodPessoa.ToString();
                txtNome.Text = emprestimo.Usuario.Nome;
                txtSexo.Text = emprestimo.Usuario.Sexo;

                if(emprestimo.Usuario.Sexo != null)
                {
                    txtSexo.Text = emprestimo.Usuario.Sexo;
                }
                else
                {
                    txtSexo.Text = "Sexo não informado. Por favor atualize o cadastro.";
                    txtSexo.Width = 180;
                }

                if (emprestimo.Usuario.Telefone.Numero != null)
                {
                    txtTelefone.Text = emprestimo.Usuario.Telefone.Numero;
                }

                else if (emprestimo.Usuario.Celular.Numero != null)
                {
                    txtTelefone.Text = emprestimo.Usuario.Celular.Numero;
                }
                else
                {
                    txtTelefone.Text = "O usuário não possui nenhum número para contato. Por favor atualize o cadastro.";
                    txtTelefone.Width = 180;
                }

                foreach (MidiaEmprestimo midiaEmprestimo in emprestimo.MidiaEmprestimoList)
                {
                    dataGridMidias.Rows.Add(midiaEmprestimo.CodMidia, midiaEmprestimo.Tombo, midiaEmprestimo.Descricao, midiaEmprestimo.TipoMidia,
                        midiaEmprestimo.DataDevolucao.ToShortDateString(), midiaEmprestimo.Devolvido);
                }

                dataGridMidias.AutoResizeColumns();
                cbMidia.SelectedIndex = 0;
                txtTombo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        //Carrega a midia informada
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                MidiaEmprestimo midiaEmprestimo = new MidiaEmprestimo();

                if (txtTombo.Text.Length == 0)
                {
                    MessageBox.Show("O campo tombo é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(!ValidaMidia())
                {
                    MessageBox.Show(this, cbMidia.Text+" ja selecionado(a) para o empréstimo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cbMidia.Text == "Livro")
                {
                    Livro livro = midiaBLL.LivroConsultar_PorTombo(Convert.ToInt32(txtTombo.Text));

                    if (!(livro.CodMidia > 0))
                    {
                        MessageBox.Show(this, "Tombo informado não cadastrado no sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (livro.Disponivel == false)
                    {
                        MessageBox.Show(this, "Livro indisponivel.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    midiaEmprestimoBase.Descricao = livro.Titulo;

                    FrmCadMidiaEmprestimo frmMidiaEmprestimo = new FrmCadMidiaEmprestimo(this);
                    if (frmMidiaEmprestimo.ShowDialog() == DialogResult.OK)
                    {
                        midiaEmprestimo.Descricao = midiaEmprestimoBase.Descricao;
                        midiaEmprestimo.CodMidia = livro.CodMidia;
                        midiaEmprestimo.TipoMidia = cbMidia.Text;
                        midiaEmprestimo.DataDevolucao = midiaEmprestimoBase.DataDevolucao;
                        midiaEmprestimo.Devolvido = false;
                        midiaEmprestimo.Tombo = Convert.ToInt32(txtTombo.Text);
                    }
                }
                else if(cbMidia.Text == "CD_DVD")
                {
                    CD_DVD cdvd = midiaBLL.CDVDConsultar_PorTombo(Convert.ToInt32(txtTombo.Text));

                    if (!(cdvd.CodMidia > 0))
                    {
                        MessageBox.Show(this, "Tombo informado não cadastrado no sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (cdvd.Disponivel == false)
                    {
                        MessageBox.Show(this, "CD / DVD indisponivel.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    midiaEmprestimoBase.Descricao = cdvd.Titulo;

                    FrmCadMidiaEmprestimo frmMidiaEmprestimo = new FrmCadMidiaEmprestimo(this);
                    if (frmMidiaEmprestimo.ShowDialog() == DialogResult.OK)
                    {
                        midiaEmprestimo.Descricao = midiaEmprestimoBase.Descricao;
                        midiaEmprestimo.CodMidia = cdvd.CodMidia;
                        midiaEmprestimo.TipoMidia = cbMidia.Text;
                        midiaEmprestimo.DataDevolucao = midiaEmprestimoBase.DataDevolucao;
                        midiaEmprestimo.Devolvido = false;
                        midiaEmprestimo.Tombo = Convert.ToInt32(txtTombo.Text);
                    }
                }
                else if (cbMidia.Text == "Mapa")
                {
                    Mapa mapa = midiaBLL.MapaConsultar_PorTombo(Convert.ToInt32(txtTombo.Text));

                    if (!(mapa.CodMidia > 0))
                    {
                        MessageBox.Show(this, "Tombo informado não cadastrado no sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (mapa.Disponivel == false)
                    {
                        MessageBox.Show(this, "Mapa indisponivel.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    midiaEmprestimoBase.Descricao = mapa.Especificacao;

                    FrmCadMidiaEmprestimo frmMidiaEmprestimo = new FrmCadMidiaEmprestimo(this);
                    if (frmMidiaEmprestimo.ShowDialog() == DialogResult.OK)
                    {
                        midiaEmprestimo.Descricao = midiaEmprestimoBase.Descricao;
                        midiaEmprestimo.CodMidia = mapa.CodMidia;
                        midiaEmprestimo.TipoMidia = cbMidia.Text;
                        midiaEmprestimo.DataDevolucao = midiaEmprestimoBase.DataDevolucao;
                        midiaEmprestimo.Devolvido = false;
                        midiaEmprestimo.Tombo = Convert.ToInt32(txtTombo.Text);
                    }
                }
                else if (cbMidia.Text == "Jornal")
                {
                    JornalEx jornal = midiaBLL.JornalConsultar_PorTombo(Convert.ToInt32(txtTombo.Text));

                    if (!(jornal.CodMidia > 0))
                    {
                        MessageBox.Show(this, "Tombo informado não cadastrado no sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (jornal.Disponivel == false)
                    {
                        MessageBox.Show(this, "Jornal indisponivel.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    midiaEmprestimoBase.Descricao = jornal.Manchete;

                    FrmCadMidiaEmprestimo frmMidiaEmprestimo = new FrmCadMidiaEmprestimo(this);
                    if (frmMidiaEmprestimo.ShowDialog() == DialogResult.OK)
                    {
                        midiaEmprestimo.Descricao = midiaEmprestimoBase.Descricao;
                        midiaEmprestimo.CodMidia = jornal.CodMidia;
                        midiaEmprestimo.TipoMidia = cbMidia.Text;
                        midiaEmprestimo.DataDevolucao = midiaEmprestimoBase.DataDevolucao;
                        midiaEmprestimo.Devolvido = false;
                        midiaEmprestimo.Tombo = Convert.ToInt32(txtTombo.Text);
                    }
                }
                else
                {
                    RevistaEx revista = midiaBLL.RevistaConsultar_PorTombo(Convert.ToInt32(txtTombo.Text));

                    if (!(revista.CodMidia > 0))
                    {
                        MessageBox.Show(this, "Tombo informado não cadastrado no sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (revista.Disponivel == false)
                    {
                        MessageBox.Show(this, "Revista indisponivel.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    midiaEmprestimo.Descricao = revista.Titulo;

                    midiaEmprestimoBase.Descricao = revista.Titulo;

                    FrmCadMidiaEmprestimo frmMidiaEmprestimo = new FrmCadMidiaEmprestimo(this);
                    if (frmMidiaEmprestimo.ShowDialog() == DialogResult.OK)
                    {
                        midiaEmprestimo.Descricao = midiaEmprestimoBase.Descricao;
                        midiaEmprestimo.CodMidia = revista.CodMidia;
                        midiaEmprestimo.TipoMidia = cbMidia.Text;
                        midiaEmprestimo.DataDevolucao = midiaEmprestimoBase.DataDevolucao;
                        midiaEmprestimo.Devolvido = false;
                        midiaEmprestimo.Tombo = Convert.ToInt32(txtTombo.Text);
                    }
                }

                txtTombo.Clear();
                txtTombo.Focus();

                if (midiaEmprestimo.CodMidia > 0)
                {
                    dataGridMidias.Rows.Add(midiaEmprestimo.CodMidia, midiaEmprestimo.Tombo, midiaEmprestimo.Descricao, midiaEmprestimo.TipoMidia, midiaEmprestimo.DataDevolucao.ToShortDateString(), midiaEmprestimo.Devolvido);
                    dataGridMidias.AutoResizeColumns();

                    MessageBox.Show(this, "Midia adicionada com sucesso. Clique em concluir para salvar as informações do empréstimo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Permite apenas numeros no textbox Tombo
        private void txtTombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Tombo aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Devolver midia
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(emprestimoBase.CodEmprestimo > 0))
                {
                    MessageBox.Show(this, "Não é possivel devolver uma midia de um novo empréstimo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridMidias.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhuma midia selecionada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if(dataGridMidias.CurrentRow.Cells["clnDevolvido"].Value.Equals(true))
                {
                    MessageBox.Show(this, "A midia selecionada ja foi devolvida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    dataGridMidias.CurrentRow.Cells["clnDevolvido"].Value = true;
                    MessageBox.Show(this, "Midia devolvida com sucesso. Clique em concluir para salvar as informações do empréstimo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Renovar midia
        private void btnRenovar_Click(object sender, EventArgs e)
        {
            try
            {
                MidiaEmprestimo midiaEmprestimo = new MidiaEmprestimo();

                if (dataGridMidias.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhuma midia selecionada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (dataGridMidias.CurrentRow.Cells["clnDevolvido"].Value.Equals(true))
                {
                    MessageBox.Show(this, "A midia selecionada ja foi devolvida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    midiaEmprestimoBase.Descricao = dataGridMidias.CurrentRow.Cells["clnDescricao"].Value.ToString();
                    midiaEmprestimoBase.DataDevolucao = DateTime.Parse((string)dataGridMidias.CurrentRow.Cells["clnDataDevolucao"].Value);

                    FrmCadMidiaEmprestimo frmMidiaEmprestimo = new FrmCadMidiaEmprestimo(this);
                    if (frmMidiaEmprestimo.ShowDialog() == DialogResult.OK)
                    {
                        dataGridMidias.CurrentRow.Cells["clnDataDevolucao"].Value = midiaEmprestimoBase.DataDevolucao.ToShortDateString();
                        MessageBox.Show(this, "Midia renovada com sucesso. Clique em concluir para salvar as informações do empréstimo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Fechar emprestimo
        private void btnFecharEmp_Click(object sender, EventArgs e)
        {
            try
            {
                MidiaEmprestimoList midiaEmprestimoList = new MidiaEmprestimoList();

                if(!(emprestimoBase.CodEmprestimo > 0))
                {
                    MessageBox.Show(this, "Não é possivel fechar um novo empréstimo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(emprestimoBase.Multa == true)
                {
                    Multa multa = multaBLL.MultaConsultar_PorEmprestimo(emprestimoBase.CodEmprestimo);
                    if(multa.Cancelada != true && multa.Pago != true)
                    {
                        MessageBox.Show(this, "Existe uma multa pendente referente a este empréstimo. Finalize a multa para prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                foreach(DataGridViewRow row in dataGridMidias.Rows)
                {
                    MidiaEmprestimo midiaEmprestimo = new MidiaEmprestimo();

                    midiaEmprestimo.Tombo = (int)row.Cells["clnTombo"].Value;
                    midiaEmprestimo.Descricao = (string)row.Cells["clnDescricao"].Value;
                    midiaEmprestimo.TipoMidia = (string)row.Cells["clnTipoMidia"].Value;
                    midiaEmprestimo.DataDevolucao = DateTime.Parse((string)row.Cells["clnDataDevolucao"].Value);
                    midiaEmprestimo.Devolvido = (bool)row.Cells["clnDevolvido"].Value;

                    if(midiaEmprestimo.Devolvido == false && midiaEmprestimo.DataDevolucao > DateTime.Now)
                    {
                        MessageBox.Show(this, "Existem midias pendentes ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    midiaEmprestimoList.Add(midiaEmprestimo);
                }

                emprestimoBase.MidiaEmprestimoList = midiaEmprestimoList;
                emprestimoBase.Fechado = true;

                MessageBox.Show(this, emprestimoBLL.EmprestimoAlterar(emprestimoBase), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Concluir emprestimo
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado;
                MidiaEmprestimoList midiaEmprestimoList = new MidiaEmprestimoList();

                if (dataGridMidias.Rows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhuma midia foi adicionada ao empréstimo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach(DataGridViewRow row in dataGridMidias.Rows)
                {
                    MidiaEmprestimo midiaEmprestimo = new MidiaEmprestimo();

                    midiaEmprestimo.CodMidia = (int)row.Cells["clnCodMidia"].Value;
                    midiaEmprestimo.Tombo = (int)row.Cells["clnTombo"].Value;
                    midiaEmprestimo.DataDevolucao = DateTime.Parse((string)row.Cells["clnDataDevolucao"].Value);
                    midiaEmprestimo.Devolvido = (bool)row.Cells["clnDevolvido"].Value;

                    midiaEmprestimoList.Add(midiaEmprestimo);
                }

                emprestimoBase.MidiaEmprestimoList = midiaEmprestimoList;

                if (emprestimoBase.CodEmprestimo > 0)
                {
                    resultado = emprestimoBLL.EmprestimoAlterar(emprestimoBase);
                }
                else
                {
                    emprestimoBase.Funcionario.CodPessoa = Settings.Default.CodPessoa;
                    resultado = emprestimoBLL.EmprestimoInserir(emprestimoBase);
                }

                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ValidaMidia
        private bool ValidaMidia()
        {
            try
            {
                bool resultado = true;

                foreach (DataGridViewRow dataRow in dataGridMidias.Rows)
                {
                    if (txtTombo.Text == dataRow.Cells["clnTombo"].Value.ToString() && cbMidia.Text == (string)dataRow.Cells["clnTipoMidia"].Value)
                    {
                        resultado = false;
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Fechar o form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //Minimiza o form
        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
