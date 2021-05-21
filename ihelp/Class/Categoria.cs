using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ihelp.Classes;
using MySql.Data.MySqlClient;

namespace ihelp.Classes
{
    public class categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ativo { get; set; }

        public categoria() { }

        public categoria(int id, string nome, string ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;

        }
        public categoria(string nome, string ativo)
        {
            Nome = nome;
            Ativo = ativo;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = $"insert categoria values (0, '{Nome}','{Ativo}'))";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        internal static object ObterCategoria()
        {
            throw new NotImplementedException();
        }

        public List<categoria> Listar()
        {
            List<categoria> lista = new List<categoria>();

            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categoria";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new categoria(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2)

                ));
            }
            return lista;
        }

        public void BuscarPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categoria where idCat = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Ativo = dr.GetString(2);
            }

        }
        public bool Alterar(int id)
        {
            bool alterado = false;
            var cmd = Banco.Abrir();
            
            cmd.CommandText = $"update categoria set " +
                $"nomeCat = '{Nome}', " +
                $"ativoCat = '{Ativo}', " +
                $"where idCat = {id}";
            try
            {
                cmd.ExecuteNonQuery();
                alterado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return alterado;
        }
    }
}