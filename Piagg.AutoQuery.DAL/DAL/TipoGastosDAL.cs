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
                return contexto.tipo_gastos.ToList();
            }
        }

    }
}
