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
    public partial class FrmCadGenero : FrmCadBaseInfraestrutura
    {
        public FrmCadGenero()
        {
            InitializeComponent();
        }

        private void FrmCadGenero_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: Genêro";
            lblTexto.Text = "Genêro:";
            lblTexto2.Text = "Lista de Genêros:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonte ponteGenero = new FrmPonte();
            ponteGenero.MdiParent = MdiParent;
            ponteGenero.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}