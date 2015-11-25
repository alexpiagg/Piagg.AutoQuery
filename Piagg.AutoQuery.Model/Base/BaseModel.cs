using Piagg.AutoQuery.Helpers.Enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace Piagg.AutoQuery.Model
{
    public abstract class BaseModel
    {

        [NotMapped]
        public StatusTransacao StatusBD { get; set; }

    }
}
