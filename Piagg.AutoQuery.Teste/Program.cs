using Piagg.AutoQuery.BLL;
using Piagg.AutoQuery.DAL;
using Piagg.AutoQuery.Helpers;
using Piagg.AutoQuery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            FiltroGastosTO g = new FiltroGastosTO();
            g.DataInicio = new DateTime(2015,11,01);
            g.DataFim = new DateTime(2015, 11, 05);

            GastosDAL dal = new GastosDAL();

            var x = dal.getSomatorioPorTipo(g);

            Console.ReadKey();
        }
    }
}
