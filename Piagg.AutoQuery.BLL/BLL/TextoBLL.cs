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

        /*
         * Verifica se existe algum dado não preenchido
         * Se houver algum item em branco retorna TRUE
         */
        public bool ValidarLinhas(string[] validarColuna)
        {
            {
                if (String.IsNullOrEmpty(validarColuna[0]) ||
                    String.IsNullOrEmpty(validarColuna[1]) ||
                    String.IsNullOrEmpty(validarColuna[2]) ||
                    String.IsNullOrEmpty(validarColuna[3])
                    )
                {
                    return true;
                }

                return false;
            }

        }
    }
}
