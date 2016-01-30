using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.Helpers
{
    public static class OutrosUtil
    {

        public static DateTime StringToDate(string data)
        {
            int dia = Convert.ToInt32(data.Substring(6, 2).Trim());
            int mes = Convert.ToInt32(data.Substring(4, 2).Trim());
            int ano = Convert.ToInt32(data.Substring(0, 4).Trim());

            DateTime dataRetorno = new DateTime(ano, mes, dia);
            return dataRetorno;
        }

        public static string FormatarDecimal(decimal? valor)
        {
            string valorFormatado = "";

            if (valor != null)
            {
                valorFormatado = String.Format("{0:0,0.00}", valor);
            }

            return valorFormatado;
        }

    }
}
