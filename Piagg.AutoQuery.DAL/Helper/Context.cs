using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piagg.AutoQuery.Model;

namespace Piagg.AutoQuery.DAL
{
    public class Context : DbContext
    {

        public Context()
            : base("BancoDados")
        {

        }

        public DbSet<GastosTO> gastos { get; set; }

        public DbSet<TipoGastosTO> tipo_gastos { get; set; }
    }
}
