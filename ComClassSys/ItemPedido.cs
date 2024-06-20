using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class ItemPedido
    {

        //propriedades

        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }


        //metodos construtores
        public ItemPedido() {
            Pedido = new();
                }
        public ItemPedido(int id, Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        //metodos manter itens de pédido
        //inserir itens -
        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id", Pedido.Id);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("sppquantidade_id", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto_id", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        //Consultar item de pedido (Obter pedido e produto)
        public static ItemPedido ObterItem(int idpedido , int idproduto=0)
        {
            ItemPedido itemPedido = new();

            return itemPedido;
        }
        public static List<ItemPedido> ObterListaPorPedido(int idpedido, int idproduto = 0)
        {
            List < ItemPedido > itens = new();

            return itens;
        }
        //Alterar Item
        public bool Alterar(int id)
        {
            return true;
        }
        //excluir
        public void Remover(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }
    }
}
