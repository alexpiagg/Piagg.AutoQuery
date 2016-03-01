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

        public override List<TipoGastosTO> SelectAll(TipoGastosTO tipoGasto)
        {
            using (var contexto = new Context())
            {

                StringBuilder sqlQuery = new StringBuilder();

                sqlQuery.Append(@"SELECT 
                                    t.id_tipo_gastos,
                                    t.tipo
                                FROM tipo_gastos t");

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
