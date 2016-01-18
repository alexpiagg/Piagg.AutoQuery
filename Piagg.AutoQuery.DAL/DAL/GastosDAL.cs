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

        public List<GastosTO> SelectAll(FiltroGastosTO filtroGastos)
        {
            using (var contexto = new Context())
            {

                if (filtroGastos.DataInicio == null)
                {
                    filtroGastos.DataInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                }

                if (filtroGastos.DataFim == null)
                {
                    filtroGastos.DataFim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
                }

                var where = PredicateBuilder.True<GastosTO>();

                where = where.And<GastosTO>(x => x.DATA >= filtroGastos.DataInicio);
                where = where.And<GastosTO>(x => x.DATA <= filtroGastos.DataFim);

                var retorno = contexto.gastos.AsExpandable().Where(where).ToList();

                return retorno;
            }
        }

        public List<GastosTO> getSomatorioPorTipo(FiltroGastosTO filtroGastos)
        {

            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append (@"  SELECT
	                                TG.Tipo,
	                                SUM(G.valor) VALOR,
	                                TG.id_tipo_gastos
                                FROM GASTOS G
                                JOIN TIPO_GASTOS TG ON TG.`id_tipo_gastos` = G.`id_tipo_gastos`
                                WHERE G.id_tipo_gastos is not null 
                                  AND G.data >= @DATAINI
                                  AND G.data <= @DATAFIM 
                                GROUP BY TIPO ");

                if (filtroGastos.DataInicio == null)
                {
                    filtroGastos.DataInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                }

                if (filtroGastos.DataFim == null)
                {
                    filtroGastos.DataFim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
                }

                MySqlConnection conn = DBUtil.GetMySqlConnection();
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
                
                cmd.Parameters.AddWithValue("@DATAINI", filtroGastos.DataInicio);
                cmd.Parameters.AddWithValue("@DATAFIM", filtroGastos.DataFim);

                conn.Open();

                MySqlDataReader myReader = cmd.ExecuteReader();

                List<GastosTO> listaGastos = new List<GastosTO>();
                while (myReader.Read())
                {
                    GastosTO gastosModel = new GastosTO();

                    gastosModel.TIPO = myReader.GetString(0);
                    gastosModel.VALOR = myReader.GetDecimal(1);
                    gastosModel.ID_TIPO_GASTOS = myReader.GetInt32(2);

                    listaGastos.Add(gastosModel);
                }

                conn.Close();
                return listaGastos;
            }
            catch (Exception ex)
            {
                //Logger.LogError(ex.Message);
                throw ex;
            }
        }

    }
}
