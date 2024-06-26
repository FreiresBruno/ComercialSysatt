﻿using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = $"{Program.Usuario.Id} - {Program.Usuario.Nome}";
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(textBox2.Text));
                if (cliente.Id > 0)
                {
                    textBox3.Text = cliente.Nome;
                }

            }
        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {

        }
    }
}
