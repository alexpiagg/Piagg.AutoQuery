using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LinqKit;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Piagg.AutoQuery.DAL
{
    public class GastosDAL : BaseDAL<GastosTO>
    {

        public List<GastosTO> SelectAll(FiltroTelaTO filtroGastos)
        {
            using (var contexto = new Context())
            {

                StringBuilder sqlQuery = new StringBuilder();

                sqlQuery.Append(  @"SELECT 
	                                    g.data,
	                                    g.id_gastos,
                                        g.id_tipo_gastos,
	                                    g.local,
	                                    g.valor,
                                        t.tipo TIPO
                                    FROM gastos g
                                    JOIN tipo_gastos t ON t.id_tipo_gastos = g.id_tipo_gastos
                                    WHERE 1 = 1 ");

                List<MySqlParameter> parametros = new List<MySqlParameter>();
                /*
                if (filtroGastos.DataInicio != null)
                {
                    sqlQuery.Append(" AND g.data >= @DataInicio");
                    MySqlParameter DataInicio = new MySqlParameter("@DataInicio", filtroGastos.DataInicio);
                    parametros.Add(DataInicio);
                }
                
                if (filtroGastos.DataFim != null)
                {
                    sqlQuery.Append(" AND g.data <= @DataFim");
                    MySqlParameter DataFim = new MySqlParameter("@DataFim", filtroGastos.DataFim);
                    parametros.Add(DataFim);
                }
                
                if (filtroGastos.IdTipoGasto > 0)
                {
                    sqlQuery.Append(" AND g.id_tipo_gastos = @IdTipoGasto");
                    MySqlParameter idTipoGasto = new MySqlParameter("@IdTipoGasto", filtroGastos.IdTipoGasto);
                    parametros.Add(idTipoGasto);
                }
                */

                if (filtroGastos.DataInicio != null)
                {
                    sqlQuery.AppendFormat(" AND g.data >= {0}", filtroGastos.DataInicio.ToString("yyyyMMdd"));
                }

                if (filtroGastos.DataFim != null)
                {
                    sqlQuery.AppendFormat(" AND g.data <= {0}", filtroGastos.DataFim.ToString("yyyyMMdd"));
                }

                if (filtroGastos.IdTipoGasto > 0)
                {
                    sqlQuery.AppendFormat(" AND g.id_tipo_gastos = {0}", filtroGastos.IdTipoGasto);
                }

                try
                {
                    //var retorno = contexto.Database.ExecuteSql<GastosTO>(sqlQuery.ToString(), parametros.ToArray()).ToList();
                    var retorno = ExecuteSql<GastosTO>(sqlQuery.ToString()).ToList();
                    return retorno;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public override GastosTO SelectScalar(int id)
        {
            using (var contexto = new Context())
            {
                return contexto.gastos.Where(x => x.ID_GASTOS == id).Single();
            }
        }

    }
}

