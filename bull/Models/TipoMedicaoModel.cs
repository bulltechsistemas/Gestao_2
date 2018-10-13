using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class TipoMedicaoModel
    {
        [Key]
        public int ID { get; set; }

        public string Descricao { get; set; }
    }
}