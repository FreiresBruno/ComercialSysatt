using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComClassSys
{
    public class Pedido
    {
        //        id int (4) AI PK
        //usuario_id int (4) 
        //cliente_id int (4) 
        //data timestamp
        //status char (1) 
        //desconto decimal (10,2)
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        List<ItemPedido> Itens { get; set; }

        public Pedido() { }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
          
        }

        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Itens = itens;
        }
        public int Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdesconto",Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            return 0;
        }
        public static Pedido ObterPorId(int id)
        {
            {
                Pedido pedido = new();
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from pedidods where id = {id}";
                var dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    pedido = new(dr.GetInt32(0)
                        , Usuario.ObterPorId(dr.GetInt32(1))
                        , Cliente.ObterPorId(dr.GetInt32(2))
                        , dr.GetDateTime(3)
                        , dr.GetString(4)
                        , dr.GetDouble(5)
                        , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                        );
                }
                return pedido;
            }
        }
        public static Pedido ObterPorClienteId(int id)
        {
            {
                Pedido pedido = new();
                return pedido;
            }
        }
        public static List<Pedido> ObterLista()
        {
            {
                List<Pedido> Lista = new();
                return Lista;
            }
        }
        public bool Alterar()
        {
            return true;
        }
        public bool Alterar(string status    )
        {

            return true;
        }
        public double CalcularPedido(int id)
        {
            return 0.0;
        }

    }
}
