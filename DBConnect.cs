using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace fluxoDeCaixa
{
    internal class DBConnect
    {
        static string serverName = "localhost";
        static string port = "5432";
        static string userName = "postgres";
        static string password = "1234";
        static string databaseName = "producao";
        //NpgsqlConnection pgsqlConnection = null;
        static string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", serverName, port, userName, password, databaseName);
        
        public static void select(DataGridView dgv)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from users";
                    MessageBox.Show("conectado");
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        DataTable tabela = new DataTable();
                        Adpt.Fill(tabela);     
                        dgv.DataSource = tabela;
                        
                            //oraReader.GetOracleNumber(0)
                    }
                    pgsqlConnection.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //pgsqlConnection.Close();
            }
        }
        


        /*public class Conexao
        {
            private static string strConexao =  "Server=localhost;" +
                                                //"Port=5432;" +
                                                "User Id=postgres;" +
                                                "Password=1234;" +
                                                "Database=auths;";
            
            public static SqlConnection Conn { get; set; }

            public static void ConectarDB()
            {
                try
                {
                    Conn = new SqlConnection(strConexao);
                    Conn.Open();
                    MessageBox.Show("Conectado!");
                }
                catch (SqlException ex)
                {
                    string error = ex.Message;
                }
            }

            public static void DesconectarDB()
            {
                if (Conn.State == ConnectionState.Open)
                {
                    //Conn.Close();
                }
            }
        }*/
    }    
}
