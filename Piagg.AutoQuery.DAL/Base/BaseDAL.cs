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

        public void Insert(List<T> listObjectInsert)
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
                //Logger.LogError(ex.Message);
                throw ex;
            } //fim
        }

        public void Update(List<T> listObjectUpdate)
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
                //Logger.LogError(ex.Message);
                throw ex;
            } //fim
        }

        public void Delete(List<T> listObjectDelete)
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
                //Logger.LogError(ex.Message);
                throw ex;
            } //fim
        }

        public void Save(List<T> listaObjetoModel)
        {

            //Inserir
            if (listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Insert).Count > 0)
            {
                Insert(listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Insert));
            }

            //Alterar
            if (listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Update).Count > 0)
            {
                Update(listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Update));
            }

            //Deletar
            if (listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Delete).Count > 0)
            {
                Delete(listaObjetoModel.FindAll(x => x.StatusBD == StatusTransacao.Delete));
            }
    
        }

    }

}
