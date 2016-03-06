using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.Model
{
    public class FiltroTelaTO
    {
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int IdTipoGasto { get; set; }

        public string Local { get; set; }

        public string TipoGasto { get; set; }

        public int Excluido { get; set; }

    }
}
