using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static fluxoDeCaixa.DBConnect;
using Npgsql;

namespace fluxoDeCaixa
{
    internal class ClassesSQL
    {
        /*public class Cliente
        {
            public int ClienteID { get; set; }
            public string Nome { get; set; }
            public static void Carregar()
            {
                DBConnect.Conexao.ConectarDB(); ;

                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Select nomeusur from users";
                comm.Connection = Conexao.Conn;
                DataTable dt = new DataTable();
                SqlDataReader dr = comm.ExecuteReader();
                dt.Load(dr);

                DBConnect.Conexao.DesconectarDB(); 
            }
        }*/
    }
}
