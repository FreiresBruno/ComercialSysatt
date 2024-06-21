using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class ItemPedido
    {

        //propriedades

        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }


        //metodos construtores
        public ItemPedido() {
            
                }
        public ItemPedido(int id, int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            PedidoId = pedidoId;
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
            cmd.Parameters.AddWithValue("sppedido_id", PedidoId);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.ID);
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
       public static List<ItemPedido> ObterListaPorPedido(int idPedido)
{
     List<ItemPedido> itens = new();
     var cmd = Banco.Abrir();
     cmd.CommandText = $"Select* from itempedido where pedido_id = {idPedido}";
     var dr = cmd.ExecuteReader();
     while(dr.Read()) 
     {
         itens.Add(new(dr.GetInt32(0),
             dr.GetInt32(1),
             Produto.ObterPorId(dr.GetInt32(2)),
             dr.GetDouble(3),
             dr.GetDouble(4),
             dr.GetDouble(5)));
 
     }
            return itens;
        }
           
        
        //Alterar Item
        public bool Alterar(int id)
{
    return true;
}
// Excluir um Item
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
