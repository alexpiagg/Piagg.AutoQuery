using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Piagg.AutoQuery.BLL
{
    public abstract class BaseBLL<T>
        where T : BaseModel
    {


        public virtual List<T> SelectAll(T objetoTO)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> SelectAll(FiltroTelaTO objetoTela)
        {
            throw new NotImplementedException();
        }

        public abstract T SelectScalar(int id);        

        public abstract void Save(List<T> objetoModel);
        
    }
}
