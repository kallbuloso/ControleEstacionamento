﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Veiculo
{
    public partial class FormVeiculoListar : Form
    {
        public FormVeiculoListar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new Veiculo.FormVeiculoCrud().Show();
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
            (ve)dgvFuncionario.SelectedRows[0].DataBoundItem
            new Veiculo.FormVeiculoCrud()
        }
    }
}
