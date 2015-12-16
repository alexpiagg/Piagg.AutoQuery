using Piagg.AutoQuery.DAL;
using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.BLL
{
    public class GastosBLL :BaseBLL<GastosTO>
    {

        public override void Save(List<GastosTO> gastosTO)
        {
            try
            {
                GastosDAL gastosDAL = new GastosDAL();
                gastosDAL.Save(gastosTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GastosTO> SelectAll(GastosFiltroTela filtroGastos)
        {
            GastosDAL gastosDAL = new GastosDAL();
            var listaGastos = gastosDAL.SelectAll(filtroGastos);

            return listaGastos;
        }

        public List<GastosTO> getSomatorioPorTipo(GastosFiltroTela filtroGastos)
        {
            GastosDAL gastosDAL = new GastosDAL();

            List<GastosTO> retorno = gastosDAL.getSomatorioPorTipo(filtroGastos);

            return retorno;
        }
    }
}
