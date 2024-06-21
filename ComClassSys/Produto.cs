using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Produto
    {
        public int? ID { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public decimal? ValorUnit { get; set; }
        public int? CategoriaId { get; set; }
        public decimal? EstoqueMinimo { get; set; }
        public decimal? ClasseDesconto { get; set; }
        public string? Imagem { get; set; }
        public DateTime? DataCad { get; set; }

        public Produto()
        {
            ID = 0;
        }

        public Produto(int id, string codBarras, string descricao, decimal valorUnit, int categoriaId, decimal estoqueMinimo, decimal classeDesconto, string imagem, DateTime dataCad)
        {
            ID = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CategoriaId = categoriaId;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;

        }
        public Produto(string codBarras, string descricao, decimal valorUnit, int categoriaId, decimal estoqueMinimo, decimal classeDesconto, string imagem, DateTime dataCad)
        {

            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CategoriaId = categoriaId;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spcategoria_id", CategoriaId);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
        }
        public bool Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", ID);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spcategoria_id", CategoriaId);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDecimal(3),
                        dr.GetInt32(4),
                        dr.GetDecimal(5),
                        dr.GetDecimal(6),
                        dr.GetString(7),
                        dr.GetDateTime(8)
                    );
            }
            return produto;
        }
        public static List<Produto> ObterPorDescricaoProduto()
        {
            List<Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDecimal(3),
                        dr.GetInt32(4),
                        dr.GetDecimal(5),
                        dr.GetDecimal(6),
                        dr.GetString(7),
                        dr.GetDateTime(8)
                        ));
            }
            return produtos;
        }
    }
}

