using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Piagg.AutoQuery.Model
{
    public class ArquivoTO
    {

        public string nomeArquivo { get; set; }

        public string pathArquivoOrigem { get; set; }

        public string pathArquivoDestino { get; set; }

        public ArrayList textoSql { get; set; }

    }
}
