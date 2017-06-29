using System;

namespace Interface.Formularios.Modelos
{
    public partial class FrmPonte : MetroFramework.Forms.MetroForm
    {
        public FrmPonte()
        {
            InitializeComponent();
        }

        //Fechar form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Botao ação
        protected virtual void btnAcao_Click(object sender, EventArgs e)
        {
         //Implementar método   
        }
    }
}
