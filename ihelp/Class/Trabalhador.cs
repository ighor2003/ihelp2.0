using ihelp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihelp.Classes
{
    public class Trabalhador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cep { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }

        public Trabalhador() { }

        public Trabalhador(int id, string nome, string email, string senha, string cep, string cpf, string celular)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cep = cep;
            Cpf = cpf;
            Celular = celular;
        }
        public Trabalhador(string nome, string email, string senha, string cep, string cpf, string celular)
        {

            Nome = nome;
            Email = email;
            Senha = senha;
            Cep = cep;
            Cpf = cpf;
            Celular = celular;
        }
        public List<Trabalhador> Listar()
        {
            List<Trabalhador> lista = new List<Trabalhador>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from trabalhador";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Trabalhador(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                ));
            }
            return lista;
        }
        public void BuscarPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from Trabalhador where idTrab = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Senha = dr.GetString(3);
                Cep = dr.GetString(4);
                Cpf = dr.GetString(5);
                Celular = dr.GetString(6);
            }
        }
        public bool Alterar(int id)
        {
            bool alterado = false;

            var cmd = Banco.Abrir();

            cmd.CommandText = $"update trabalhador set " +
                $"nomeTrab = '{Nome}', " +
                $"emailTrab = '{Email}', " +
                $"senhaTrab = md5('{Senha}') " +
                $"cepTrab = ('{Cep}') " +
                $"cpfTrab = ('{Cpf}') " +
                $"celularTrab = ('{Celular}') " +
                $"where idTrab = {id}";
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