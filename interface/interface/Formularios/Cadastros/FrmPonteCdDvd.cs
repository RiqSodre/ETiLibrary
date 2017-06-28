using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Formularios.Modelos;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteCdDvd : FrmPonte
    {
        private FrmCadCdDvd frmCadCdDvd;

        public FrmPonteCdDvd()
        {
            InitializeComponent();
        }

        public FrmPonteCdDvd(FrmCadCdDvd frmCadCdDvd)
        {
            // TODO: Complete member initialization
            this.frmCadCdDvd = frmCadCdDvd;
        }

        private void FrmPonteCdDvd_Load(object sender, EventArgs e)
        {
            lblTexto.Text = "Digite o código do CD/DVD:";
        }
    }
}
