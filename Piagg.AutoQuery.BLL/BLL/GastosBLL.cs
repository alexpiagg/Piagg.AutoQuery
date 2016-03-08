using Piagg.AutoQuery.DAL;
using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.BLL
{
    public class GastosBLL : BaseBLL<GastosTO>
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

        public override List<GastosTO> SelectAll(FiltroTelaTO filtroGastos)
        {
            GastosDAL gastosDAL = new GastosDAL();
            try
            {
                var listaGastos = gastosDAL.SelectAll(filtroGastos);
                return listaGastos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GastosTO> getSomatorioPorTipo(FiltroTelaTO filtroGastos)
        {
            GastosDAL gastosDAL = new GastosDAL();

            try
            {
                List<GastosTO> retorno = gastosDAL.SelectAll(filtroGastos);

                var listaAgrupada = retorno.GroupBy(x => x.TIPO).Select(g => new GastosTO()
                                                                                    {
                                                                                        TIPO = g.First().TIPO,
                                                                                        ID_TIPO_GASTOS = g.First().ID_TIPO_GASTOS,
                                                                                        VALOR = g.Sum(s => s.VALOR),                           
                                                                                    }).ToList();

                return listaAgrupada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override GastosTO SelectScalar(int id)
        {
            GastosDAL gastosDAL = new GastosDAL();

            try
            {
                return gastosDAL.SelectScalar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
