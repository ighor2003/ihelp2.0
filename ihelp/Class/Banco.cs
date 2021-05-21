using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ihelp.Classes;

namespace ihelp.Classes
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strconn = @"server=softkleen.com.br;database=wellington_ihelp;user id=alunos_ihelp;password=!6Bcxn84";
            MySqlConnection cn = new MySqlConnection(strconn);
            
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {
                throw;
            }
            return cmd;
        }
    }

}
