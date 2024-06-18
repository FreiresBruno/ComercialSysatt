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
           
            Produto produto = new Produto(mskCodigo.Text

              , txtDescricao.Text
              , Convert.ToDouble(txtValorUnit.Text)
              , cmbUnidedeVendas.Text
              ,Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)

                ) ;

            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto {produto.GetHashCode()} cadastrado com sucesso");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Produto produto = new Produto(

              int.Parse(txtId.Text)
              , mskCodigo.Text
              , txtDescricao.Text
              , Convert.ToDouble(txtValorUnit)
              , cmbUnidedeVendas.Text
              , Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)
              
            
              );

            if (produto.Editar(produto.Id))
            {
                MessageBox.Show($"o Produto {produto.CodBarras} foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \"{produto.CodBarras}\" !");
            }
            
        }

        private void btnConsultarPorId_Click(object sender, EventArgs e)
        {
            if (btnConsultarPorId.Text == "&Consultar")
            {
                mskCodigo.Clear();
                txtDescricao.Clear();
                txtValorUnit.Clear();
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
                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    produto.CodBarras = mskCodigo.Text;
                    produto.Descricao = txtDescricao.Text;
                    produto.ValoUnit = Convert.ToDouble(txtValorUnit);
                    produto.UnidadeVenda = cmbUnidedeVendas.Text;
                    produto.EstoqueMinimo = Convert.ToDouble(txtEstoqueMinimo.Text);
                    produto.ClasseDesconto = Convert.ToDouble(txtClasseDesconto.Text);
                    txtId.ReadOnly = true;
                    btnConsultarPorId.Text = "&Consultar";
                    cbmCategoria.SelectedValue = produto.CategoriaId.Id;
                    btnEditar.Enabled = true;
                }
            }
        }


        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

            var categorias = Categoria.ObterLista();
            cbmCategoria.DataSource = categorias;
            cbmCategoria.DisplayMember = "descricao";
            cbmCategoria.ValueMember = "id";




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
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;

                count++;
            }
        }
            
    }
}
