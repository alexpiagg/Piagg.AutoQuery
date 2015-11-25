using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Piagg.AutoQuery.Model
{
    
    [Table("gastos")]
    public class GastosTO : BaseModel
    {
        [Key]
        [Column("id_gastos")]
        public int ID_GASTOS { get; set; }

        [Column("local")]
        public string LOCAL { get; set; }

        [Column("valor")]
        public decimal? VALOR { get; set; }

        [Column("data")]
        public DateTime DATA { get; set; }

        [Column("id_tipo_gastos")]
        public int? ID_TIPO_GASTOS { get; set; }

        [ForeignKey("ID_TIPO_GASTOS")]
        public TipoGastosTO FK_ID_TIPO_GASTOS { get; set; }

        /*
         * Não Mapeados
         */

        [NotMapped]
        public string TIPO { get; set; }

    }
}
