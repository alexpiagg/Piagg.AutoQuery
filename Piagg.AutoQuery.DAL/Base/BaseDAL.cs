using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Data.Entity.Infrastructure;
using System.Reflection;
using System.Data;
using Piagg.AutoQuery.Model;

namespace Piagg.AutoQuery.DAL
{
    public abstract class BaseDAL<T>
        where T : BaseModel
    {
        public virtual List<T> SelectAll(T objetoTO)
        {
            throw new NotImplementedException();
        }

        public virtual T SelectScalar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T objeto)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Entry(objeto).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //Logger.LogError(ex.Message);
                throw ex;
            } //fim
        }

        public void Update(T objeto)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Entry(objeto).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //Logger.LogError(ex.Message);
                throw ex;
            } //fim
        }

        public void Delete(T objeto)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Entry(objeto).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //Logger.LogError(ex.Message);
                throw ex;
            } //fim
        }

        public void Save(T objetoModel)
        {
            if (objetoModel.StatusBD == StatusTransacao.Update)
            {
                Update(objetoModel);
            }
            else if (objetoModel.StatusBD == StatusTransacao.Insert)
            {
                Insert(objetoModel);
            }
            else if (objetoModel.StatusBD == StatusTransacao.Delete)
            {
                Delete(objetoModel);
            }
        }

    }

}
