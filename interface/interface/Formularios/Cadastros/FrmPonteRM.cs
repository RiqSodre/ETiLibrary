using BLL;
using DTO.Pessoas;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteRM : Interface.Formularios.Modelos.FrmPonte
    {
        private PessoaBLL pessoa = new PessoaBLL();
        private FrmCadAluno frmCadAluno = new FrmCadAluno();
        private Aluno aluno = new Aluno();
 
        public FrmPonteRM(FrmCadAluno frmCadAluno2)
        {
            InitializeComponent();

            frmCadAluno = frmCadAluno2;
            aluno = frmCadAluno.Aluno;
        }

        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            int parsable;

            if (txtTexto.Text.Equals(null) || txtTexto.Text.Equals(""))
            {
                MessageBox.Show(this, "Digite o R.M. no campo informado.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else if(!int.TryParse(txtTexto.Text, out parsable))
            {
                MessageBox.Show(this, "Digite um R.M valido.", "Atenção", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }
            else
            {
                aluno = pessoa.AlunoCarregarXML(txtTexto.Text);

                if (aluno.Nome == "" || aluno.Nome == null)
                {
                    MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o R.M foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                    return;
                }
                
                frmCadAluno.Aluno = aluno;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
