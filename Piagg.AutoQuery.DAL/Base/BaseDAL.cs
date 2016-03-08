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
