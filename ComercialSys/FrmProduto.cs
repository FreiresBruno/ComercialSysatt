using ComClassSys;
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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Produto produto = new Produto(mskCodigo.Text

              , txtDescricao.Text
              , Convert.ToDouble(mskValor.Text)
              , cmbUnidedeVendas.Text
              , Convert.ToInt32(txtCategoria.Text)
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)
                );

            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto {produto.GetHashCode()} cadastrado com sucesso");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Produto produto = new Produto(

              int.Parse(txtId.Text)
              , mskCodigo.Text
              , txtDescricao.Text
              , Convert.ToDouble(mskValor.Text)
              , cmbUnidedeVendas.Text
              , Convert.ToInt32(txtCategoria.Text)
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)
              , true);

            if (produto.Editar(produto.Id))
            {
                MessageBox.Show($"o Produto {produto.descricao} foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \"{produto.descricao}\" !");
            }

        }

        private void btnConsultarPorId_Click(object sender, EventArgs e)
        {
            if (btnConsultarPorId.Text == "&Consultar")
            {
                mskCodigo.Clear();
                txtDescricao.Clear();
                mskValor.Clear();
                txtCategoria.Clear();
                txtEstoqueMinimo.Clear();
                txtClasseDesconto.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultarPorId.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = produto.ObterPorId(int.Parse(txtId.Text));
                    mskCodigo.Text = produto.CodBarras;
                    txtDescricao.Text = produto.Descricao;
                    produto.ValorUnit = Convert.ToDouble(mskValor.Text);
                    cmbUnidedeVendas.Text = produto.UnidadeVenda;
                    produto.CategoriaId = int.Parse(txtCategoria.Text);
                    produto.EstoqueMinimo = Convert.ToDouble(txtEstoqueMinimo.Text);
                    produto.ClasseDesconto = Convert.ToDouble(txtClasseDesconto.Text);

                    txtId.ReadOnly = true;
                    btnConsultarPorId.Text = "&Consultar";
                    cmbUnidedeVendas.SelectedValue = produto.cmbUnidedeVendas.Id;
                    btnEditar.Enabled = true;
                }
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBarras;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValoUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.CategoriaId;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[6].Value = produto.ClasseDesconto;

                count++;
            }
        }
            
    }
}
