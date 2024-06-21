using System.Data;

using Mysqlx.Prepare;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Data;
 
namespace ComClassSys

{

    public class Pedido

    {

        public int? ID { get; set; }

        public Usuario Usuario { get; set; }

        public Cliente Cliente { get; set; }

        public DateTime Data { get; set; }

        public string Status { get; set; }

        public double Desconto { get; set; }

        List<ItemPedido> Itens { get; set; }

        public Pedido() { }

        public Pedido(int? iD, Usuario usuario, Cliente clienete, DateTime data, string status, double desconto)

        {

            ID = iD;

            Usuario = usuario;

            Cliente = clienete;

            Data = data;

            Status = status;

            Desconto = desconto;

        }

        public Pedido(int? iD, Usuario usuario, Cliente clienete, DateTime data, string status, double desconto, List<ItemPedido> itens)

        {

            ID = iD;

            Usuario = usuario;

            Cliente = clienete;

            Data = data;

            Status = status;

            Desconto = desconto;

            Itens = itens;

        }

        public Pedido(Usuario usuario, Cliente clienete, DateTime data, string status, double desconto)

        {

            Usuario = usuario;

            Cliente = clienete;

            Data = data;

            Status = status;

            Desconto = desconto;

        }

        public void Inserir()

        {

            var cmd = Banco.Abrir();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "sp_pedido_insert";

            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);

            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);

            cmd.Parameters.AddWithValue("spstatus", Status);

            cmd.Parameters.AddWithValue("spdesconto", Desconto);

            ID = Convert.ToInt32(cmd.ExecuteScalar());

        }

        public Pedido ObterPorId(int id)

        {

            Pedido pedido = new();

            var cmd = Banco.Abrir();

            cmd.CommandText = $"select * from pedidos where id = {id} ";

            var dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                pedido = new(

                    dr.GetInt32(0),

                    Usuario.ObterPorId(dr.GetInt32(1)),

                    Cliente.ObterPorId(dr.GetInt32(2)),

                    dr.GetDateTime(3),

                    dr.GetString(4),

                    dr.GetDouble(5),

                    ItemPedido.ObterListaPorPedido(dr.GetInt32(0))

                    );

            }

            return pedido;

        }


        public static List<Pedido> ObterPorClientePorId(int ClienteId)

        {

            List<Pedido> pedidos = new();

            var cmd = Banco.Abrir();

            cmd.CommandText = $"select * from pedidos where cliente_id = {ClienteId} ";

            var dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                pedidos.Add(new(

                    dr.GetInt32(0),

                    Usuario.ObterPorId(dr.GetInt32(1)),

                    Cliente.ObterPorId(dr.GetInt32(2)),

                    dr.GetDateTime(3),

                    dr.GetString(4),

                    dr.GetDouble(5),

                    ItemPedido.ObterListaPorPedido(dr.GetInt32(0))

                    ));

            }

            return pedidos;

        }


        public static List<Pedido> ObterLista(string status = "")

        {

            List<Pedido> pedidos = new();

            var cmd = Banco.Abrir();

            if (status == "")

            {

                cmd.CommandText = "select * from pedidos";

            }

            else

            {

                cmd.CommandText = $"select * from pedidos where status = {status}";

            }

            cmd.CommandText = $"select * from pedidos";

            var dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                pedidos.Add(new(

                    dr.GetInt32(0),

                    Usuario.ObterPorId(dr.GetInt32(1)),

                    Cliente.ObterPorId(dr.GetInt32(2)),

                    dr.GetDateTime(3),

                    dr.GetString(4),

                    dr.GetDouble(5),

                    ItemPedido.ObterListaPorPedido(dr.GetInt32(0))

                    ));

            }

            return pedidos;

        }


        public bool Alterar()

        {

            var com = Banco.Abrir();

            com.CommandType = CommandType.StoredProcedure;

            com.CommandText = "sp_pedido_update";

            com.Parameters.AddWithValue("spid", ID);

            com.Parameters.AddWithValue("spusuario_id", Usuario.Id);

            com.Parameters.AddWithValue("spcliente_id", Cliente.Id);

            com.Parameters.AddWithValue("spstatus", Status);

            com.Parameters.AddWithValue("spdeconto", Desconto);

            return com.ExecuteNonQuery() > 0 ? true : false;

        }


        public bool Alterar(string status)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update pedidos set status = {Status} where id = {ID}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        public static double CalcularPedido(int id)

        {

            return 0.0;

        }

    }

}
