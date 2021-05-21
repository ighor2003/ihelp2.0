using ihelp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihelp.Classes
{
    public class Servicos
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Status { get; set; }
        public string Comentarios { get; set; }
        public Servicos() { }

        public Servicos(int id, string nome, string descricao, double valor, string status, string comentarios)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Status = status;
            Comentarios = comentarios;
        }

        public Servicos(string nome, string descricao, double valor, string status, string comentarios)
        {


            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Status = status;
            Comentarios = comentarios;
        }

        public List<Servicos> Listar()
        {
            List<Servicos> lista = new List<Servicos>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from servicos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Servicos(
                 dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetDouble(3),
                 dr.GetString(4),
                 dr.GetString(5)

                ));
            }
            return lista;
        }

        public void BuscarPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from Servicos where idServ = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Descricao = dr.GetString(2);
                Valor = dr.GetDouble(3);
                Status = dr.GetString(4);
                Comentarios = dr.GetString(5);
            }
        }

        public bool Alterar(int id)
        {
            bool alterado = false;
            var cmd = Banco.Abrir();

            cmd.CommandText = $"update servicos set " +
                $"statusServ = '{Status}' " +
                $"where idServ = {id}";
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
