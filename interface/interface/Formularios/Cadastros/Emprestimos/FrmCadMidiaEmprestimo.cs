using DTO.Emprestimos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadMidiaEmprestimo : MetroFramework.Forms.MetroForm
    {
        private FrmCadEmprestimo frmCadEmprestimoBase = new FrmCadEmprestimo();
        private MidiaEmprestimo midiaEmprestimoBase = new MidiaEmprestimo();

        //Carrega o objeto midia emprestimo do form de emprestimo
        public FrmCadMidiaEmprestimo(FrmCadEmprestimo frmCadEmprestimo)
        {
            try
            {
                InitializeComponent();
                frmCadEmprestimoBase = frmCadEmprestimo;
                midiaEmprestimoBase = frmCadEmprestimoBase.MidiaEmprestimoBase;
                txtDescricao.Text = midiaEmprestimoBase.Descricao;

                if (!midiaEmprestimoBase.DataDevolucao.Equals(DateTime.Parse("01/01/0001 00:00")))
                {
                    dateTDataDevolucao.Value = midiaEmprestimoBase.DataDevolucao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: "+ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Confirma a midia ao empréstimo
        private void btnCofirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTDataDevolucao.Value <= DateTime.Now)
                {
                    MessageBox.Show(this, "Informe uma data valida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(dateTDataDevolucao.Value.DayOfWeek == DayOfWeek.Saturday || dateTDataDevolucao.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show(this, "A biblioteca não funciona durante os fins de semana. Selecione outra data.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                midiaEmprestimoBase.DataDevolucao = dateTDataDevolucao.Value;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
