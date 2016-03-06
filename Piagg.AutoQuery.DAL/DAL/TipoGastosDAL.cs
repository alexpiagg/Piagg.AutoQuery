using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.DAL.DAL
{
    public class TipoGastosDAL : BaseDAL<TipoGastosTO>
    {

        public List<TipoGastosTO> SelectAll(FiltroTelaTO filtroTela)
        {
            using (var contexto = new Context())
            {

                StringBuilder sqlQuery = new StringBuilder();

                sqlQuery.Append(@"SELECT 
                                    t.id_tipo_gastos,
                                    t.tipo,
                                    t.excluido
                                  FROM tipo_gastos t
                                  WHERE 1 = 1 ");

                if (filtroTela.IdTipoGasto > 0)
                {
                    sqlQuery.AppendFormat(" AND t.id_tipo_gastos = {0} ", filtroTela.IdTipoGasto);
                }

                if (!String.IsNullOrEmpty(filtroTela.TipoGasto))
                {
                    sqlQuery.AppendFormat(" AND t.tipo LIKE '%{0}%' ", filtroTela.TipoGasto);
                }

                if (filtroTela.Excluido == 1)
                {
                    sqlQuery.Append(" AND IFNULL(t.excluido, false) = true ");
                }

                try
                {
                    var retorno = ExecuteSql<TipoGastosTO>(sqlQuery.ToString()).ToList();
                    return retorno;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public override TipoGastosTO SelectScalar(int id)
        {
            using (var contexto = new Context())
            {
                try
                {
                    return contexto.tipo_gastos.Where(x => x.ID_TIPO_GASTOS == id).Single();
                }                
                catch (Exception ex)
                {
                    throw ex;
                }
            }
       }
    }
}
