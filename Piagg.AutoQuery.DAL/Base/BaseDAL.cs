using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Data.Entity.Infrastructure;
using System.Reflection;
using System.Data;
using Piagg.AutoQuery.Model;
using MySql.Data.MySqlClient;
using Piagg.AutoQuery.DAL.Helper;

namespace Piagg.AutoQuery.DAL
{
    public abstract class BaseDAL<T>
        where T : BaseModel
    {
        public virtual List<T> SelectAll(T objetoTO)
        {
            throw new NotImplementedException();
        }

        protected List<Y> ExecuteSql<Y>(string selectSQL)
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
                //LogHelper.ErroLog(ex);
                throw ex;
            }
        }

        public abstract T SelectScalar(int id);

        public void Save(List<T> listaObjetoModel)
        {

            //Inserir
            if (listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Insert).Count > 0)
            {
                EFUtil.Insert(listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Insert));
            }

            //Alterar
            if (listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Update).Count > 0)
            {
                EFUtil.Update(listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Update));
            }

            //Deletar
            if (listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Delete).Count > 0)
            {
                EFUtil.Delete(listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Delete));
            }
    
        }

    }

}
