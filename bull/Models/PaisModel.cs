using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class PaisModel
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(40, ErrorMessage = "A descrição deve possuir no máximo 40 caracteres")]
        public string Descricao { get; set; }
    }
}