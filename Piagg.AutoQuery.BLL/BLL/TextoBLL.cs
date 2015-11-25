using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.BLL.BLL
{
    public class TextoBLL
    {
        /*
         * Lê um texto e transforma cada linha em um elemento de um ArrayList, que será retornado
         */
        public ArrayList processaTexto(String listaTexto)
        {
            ArrayList linhaTexto = new ArrayList();

            StringReader texto = new StringReader(listaTexto);
            string linha = String.Empty;

            while (linha != null)
            {
                linha = texto.ReadLine();
                linhaTexto.Add(linha);
            }

            return linhaTexto;
        }


    }
}
