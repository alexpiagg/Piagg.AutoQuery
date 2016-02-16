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
                                        t.tipo
                                    FROM gastos g
                                    JOIN tipo_gastos t ON t.id_tipo_gastos = g.id_tipo_gastos
                                    WHERE 1 = 1 ");

                List<MySqlParameter> parametros = new List<MySqlParameter>();

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

                var retorno = contexto.Database.SqlQuery<GastosTO>(sqlQuery.ToString(), parametros.ToArray()).ToList(); 
                
                return retorno;
            }
        }

        public override GastosTO SelectScalar(int id)
        {
            using (var contexto = new Context())
            {
                return contexto.gastos.Where(x => x.ID_GASTOS == id).Single();
            }
        }

        /*
        public List<GastosTO> getSomatorioPorTipo(FiltroTelaTO filtroGastos)
        {

            using (var contexto = new Context())
            {
                StringBuilder sql = new StringBuilder();

                sql.Append(@"  SELECT
                	                TG.Tipo,
                	                SUM(G.valor) VALOR,
                	                TG.id_tipo_gastos,
                                    
                                    null local,
                                    CAST(NOW() AS DATE) data,
                                    0 id_gastos
                                FROM GASTOS G
                                JOIN TIPO_GASTOS TG ON TG.id_tipo_gastos = G.id_tipo_gastos
                                WHERE G.id_tipo_gastos is not null 
                                    AND G.data >= @DataInicio
                                    AND G.data <= @DataFim 
                                GROUP BY TIPO ");

                List<MySqlParameter> parametros = new List<MySqlParameter>();

                MySqlParameter DataInicio = new MySqlParameter("@DataInicio", filtroGastos.DataInicio);
                parametros.Add(DataInicio);

                MySqlParameter DataFim = new MySqlParameter("@DataFim", filtroGastos.DataFim);
                parametros.Add(DataFim);
                
                var retorno = contexto.Database.SqlQuery<GastosTO>(sql.ToString(), parametros.ToArray()).ToList();

                return retorno;
            }
        }
        */
    }
}
