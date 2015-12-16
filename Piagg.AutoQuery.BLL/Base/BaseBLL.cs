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

        public virtual T SelectScalar(int id) 
        {   
            throw new NotImplementedException();
        }

        public abstract void Save(List<T> objetoModel);
        
    }
}
