using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Piagg.AutoQuery.DAL;
using Piagg.AutoQuery.Helpers;

namespace Piagg.AutoQuery.DAL
{

    /*
     * Classe desenvolvida para trabalhar com o banco de dados somente via MySqlConnection
     */
    public static class DBUtil
    {

        public static MySqlParameter Parametros(string nomeParamentro, DbType tipo, object valor)
        {

            MySqlParameter parametro = new MySqlParameter();
            parametro.ParameterName = nomeParamentro;
            parametro.Value = valor;
            parametro.DbType = tipo;

            return parametro;
        }

        public static MySqlConnection GetMySqlConnection()
        {
            string connectionString = ConfigHelper.GetStringConnection();

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }

        public static MySqlDataReader ExecuteProcedure(string nome, List<MySqlParameter> listaParametros = null)
        {
            {
                try
                {

                    var conn = DBUtil.GetMySqlConnection();
                    conn.Open();

                    using (MySqlCommand sqlCommand = new MySqlCommand(nome, conn))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        if (listaParametros != null)
                        {
                            sqlCommand.Parameters.AddRange(listaParametros.ToArray());
                        }

                        return sqlCommand.ExecuteReader();
                    }

                }
                catch (Exception ex)
                {
                    LoggerUtil.ErrorLog(ex.Message, ex);
                    throw ex;
                }

            }
        }

        /*
         * Efetua o backup da base de dados
         */
        public static void Backup(string pathComplete)
        {
            string constring = ConfigHelper.GetStringConnection();
            string file = pathComplete;

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            mb.ExportToFile(file);

                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
        }

        /*
         * Inicia os processos de restore da base de dados
         */
        public static void Restore(string pathComplete)
        {
            string constring = ConfigHelper.GetStringConnection();
            string file = pathComplete;

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            mb.ImportFromFile(pathComplete);

                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
        }
    }
}