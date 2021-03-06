﻿using Piagg.AutoQuery.DAL.DAL;
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

        public override List<TipoGastosTO> SelectAll(FiltroTelaTO filtro)
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
            try
            {
                TipoGastosDAL tipoGastoDAL = new TipoGastosDAL();
                return tipoGastoDAL.SelectScalar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public override void Save(List<TipoGastosTO> objetoModel)
        {
            try
            {
                TipoGastosDAL tipoGastoDAL = new TipoGastosDAL();
                tipoGastoDAL.Save(objetoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
