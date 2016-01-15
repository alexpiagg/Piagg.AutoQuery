using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Piagg.AutoQuery.Model
{
    [Table("tipo_gastos")]
    public class TipoGastosTO : BaseModel
    {

        [Key]
        [Column("id_tipo_gastos")]
        public int ID_TIPO_GASTOS { get; set; }

        [Column("tipo")]
        public string TIPO { get; set; }

        public virtual List<GastosTO> LISTA_GASTOS_MODEL { get; set; }

    }
}
