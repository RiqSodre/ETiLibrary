﻿using System;
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
    public partial class FrmCadExtravio : FrmCadBaseInfraestrutura
    {
        public FrmCadExtravio()
        {
            InitializeComponent();
        }

        private void FrmCadExtravio_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastrar: Extravio";
            lblTexto.Text = "Extravio:";
            lblTexto2.Text = "Lista de Extravios:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonte ponteExtravio = new FrmPonte();
            ponteExtravio.MdiParent = MdiParent;
            ponteExtravio.Show();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}