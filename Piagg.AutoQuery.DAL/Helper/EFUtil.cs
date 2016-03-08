using MySql.Data.MySqlClient;
using Piagg.AutoQuery.Helpers;
using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.DAL.Helper
{
    public static class EFUtil
    {

        /*
         * Retorna se o banco de dados está ativo ou não
         */
        public static void TestarConexaoBD()
        {
            using (var context = new Context())
            {
                try
                {
                    context.Database.Connection.Open();
                }
                catch
                {
                    throw new Exception("Verifique a conexão com o banco de dados.");
                }
                finally
                {
                    if (context.Database.Connection.State == ConnectionState.Open)
                    {
                        context.Database.Connection.Close();
                    }
                }
            }
        }

        public static void Insert<T>(List<T> listObjectInsert) where T : BaseModel
        {
            try
            {
                using (var context = new Context())
                {
                    foreach (var objeto in listObjectInsert)
                    {
                        context.Entry(objeto).State = EntityState.Added;
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message, ex);
                throw ex;
            } //fim
        }

        public static void Update<T>(List<T> listObjectUpdate) where T : BaseModel
        {
            try
            {
                using (var context = new Context())
                {
                    foreach (var objeto in listObjectUpdate)
                    {
                        context.Entry(objeto).State = EntityState.Modified;
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message, ex);
                throw ex;
            }
        }

        public static void Delete<T>(List<T> listObjectDelete) where T : BaseModel
        {
            try
            {
                using (var context = new Context())
                {
                    foreach (var objeto in listObjectDelete)
                    {
                        context.Entry(objeto).State = EntityState.Deleted;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message, ex);
                throw ex;
            } //fim
        }

        public static List<Y> ExecuteSql<Y>(string selectSQL)
        {
            try
            {
                using (var context = new Context())
                {

                    if (context.Database.Connection.State != System.Data.ConnectionState.Open)
                    {
                        context.Database.Connection.Open();
                    }

                    var cmd = context.Database.Connection.CreateCommand();
                    cmd.CommandText = selectSQL;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandTimeout = 60;

                    var dataReader = cmd.ExecuteReader();

                    var retorno = new List<Y>();
                    var props = typeof(Y).GetProperties().ToList();

                    while (dataReader.Read())
                    {

                        if (!dataReader.HasRows)
                        {
                            continue;
                        }

                        var obj = Activator.CreateInstance<Y>();

                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {

                            var columnName = dataReader.GetName(i);
                            var propObj = props.Find(p => p.Name.Equals(columnName, StringComparison.CurrentCultureIgnoreCase));

                            if (propObj == null)
                            {
                                continue;
                            }

                            var valor = dataReader[columnName];

                            if (!String.IsNullOrEmpty(valor.ToString()))
                            {
                                propObj.SetValue(obj, valor, null);
                            }
                        }

                        retorno.Add(obj);
                    }

                    dataReader.Close();

                    return retorno;
                }

            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message, ex);
                throw ex;
            }
        }
    }
}
