using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.BC;
using System.Diagnostics;

namespace ComClassSys
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double? ValoUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria CategoriaId { get; set; }
        public double? EstoqueMinimo { get; set; }
        public double? ClasseDesconto { get; set; }
        public string? Imagem { get; set; }
        public DateTime DataCad { get; set; }

        public Produto()
        {
            Id = 0;
        }
        public Produto(int id, string codBarras, string descricao, double valoUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto, string imagem, DateTime dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValoUnit = valoUnit;
            UnidadeVenda = unidadeVenda;
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public Produto(string codBarras, string descricao, double valoUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto, string imagem)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValoUnit = valoUnit;
            UnidadeVenda = unidadeVenda;
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
        }
        public Produto(string codBarras, string descricao, double valoUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValoUnit = valoUnit;
            UnidadeVenda = unidadeVenda;
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            
        }
        public Produto(int id,string codBarras, string descricao, double valoUnit, string unidadeVenda, Categoria categoriaId, double estoqueMinimo, double classeDesconto)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao= descricao;
            ValoUnit = valoUnit;
            UnidadeVenda = unidadeVenda;
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValoUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", CategoriaId.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo",EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValoUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", CategoriaId);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            return cmd.ExecuteNonQuery() > -1 ? true : false;

        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id ={id}";
            var dr = cmd.ExecuteReader(); // retorno das consultas (se tiver)
            while (dr.Read())
            {
                produto = new(dr.GetInt32(0)
                 ,dr.GetString(1)
                 , dr.GetString(2)
                 ,dr.GetDouble(3)
                 ,dr.GetString(4)
                 ,Categoria.ObterPorId((5))
                 , dr.GetDouble(6)
                 ,dr.GetDouble(7)
            

                 );
            }
            return produto;
        }
        public static List<Produto> ObterLista(string descricao=null)
        {
            List<Produto> lista = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (descricao == null)
            {
                cmd.CommandText = "select * from produtos";
            }
            else
            {
                cmd.CommandText = $"select * from produtos where descricao like '%{descricao}%'";
            }
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lista.Add(new Produto(

                   dr.GetInt32(0)
                 , dr.GetString(1)
                 , dr.GetString(2)
                 , dr.GetDouble(3)
                 , dr.GetString(4)
                , Categoria.ObterPorId((5))
                 , dr.GetDouble(6)
                 , dr.GetDouble(7)
                 
               
 ));
            }
            return lista;
        }


    }
}