using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Categoria
    {
        // propriedades da classe
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // metodos construtores
        public Categoria() { }
        public Categoria(int id, string nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        // metodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            try
            {
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }
        
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from categorias where id={id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                categoria.Id = dr.GetInt32(0);
                categoria.Nome = dr.GetString(1);
                categoria.Sigla = null;
            }

            return categoria;
        }
        public static List<Categoria> ObterLista(string nome = null)
        {
            List<Categoria> lista = new List<Categoria>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == null)
            {
                cmd.CommandText = "select * from categorias order by nome";
            }
            else
            {
                cmd.CommandText = $"select * from categorias where nome like '%{nome}%' order by nome";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria cat = new Categoria();
                cat.Id = dr.GetInt32(0);
                cat.Nome = dr.GetString(1);
                cat.Sigla = null;

                lista.Add(cat);
            }

            return lista;
        }
    }
}