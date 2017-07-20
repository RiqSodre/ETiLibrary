using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadTurma : Interface.Formularios.Modelos.FrmPonte
    {
        private FrmCadCursoT frmCadCursoTBase = new FrmCadCursoT();

        //Construtor Padrão
        public FrmCadTurma(FrmCadCursoT frmCadCursoT)
        {
            try
            {
                InitializeComponent();
                frmCadCursoTBase = frmCadCursoT;
                cbPeriodo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Salva a turma que sera passada ao form de cadastro
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Insira o nome da Turma que deseja cadastrar no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtTexto.Text.Length < 3)
                {
                    MessageBox.Show(this, "O nome da Turma deve conter no mínimo 3 caracteres.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                frmCadCursoTBase.Turma.Descricao = txtTexto.Text;
                frmCadCursoTBase.Turma.Periodo = cbPeriodo.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
