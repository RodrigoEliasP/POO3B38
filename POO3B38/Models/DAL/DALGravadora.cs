using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Web;
using System.Data;

namespace POO3B38.Models.DAL
{
    public class DALGravadora
    {
        private string string_conexao = "Persist Security info=false ; server=localhost; database=bd_gravadora;user=root;pwd=;";
        private MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas na conexão com o Banco de Dados. " + e.Message);
            }
        }
        // Metodo da classe que não retorna dados do banco de dados - Insert/Delete/Update
        public void executarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução no Banco de Dados. " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        // Metodo da classe que retorna dados do banco de dados - Select
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a consulta no Banco de Dados. " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}