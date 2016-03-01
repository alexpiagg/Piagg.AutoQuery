using Piagg.AutoQuery.DAL.DAL;
using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.BLL.BLL
{
    public class TipoGastosBLL : BaseBLL<TipoGastosTO>
    {


        public List<TipoGastosTO> SelectAll(TipoGastosTO filtro)
        {
            try
            {
                TipoGastosDAL tipoGastosDAL = new TipoGastosDAL();
                return tipoGastosDAL.SelectAll(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public override TipoGastosTO SelectScalar(int id)
        {
            throw new NotImplementedException();
        }
        
        public override void Save(List<TipoGastosTO> objetoModel)
        {
            throw new NotImplementedException();
        }


    }
}
