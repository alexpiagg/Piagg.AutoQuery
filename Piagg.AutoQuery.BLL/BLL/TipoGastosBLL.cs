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


        public List<TipoGastosTO> SelectAll(TipoGastosTO filtro)
        {
            TipoGastosDAL tipoGastosDAL = new TipoGastosDAL();

            return tipoGastosDAL.SelectAll(filtro);
        }
        
        public override void Save(List<TipoGastosTO> objetoModel)
        {
            throw new NotImplementedException();
        }
    }
}