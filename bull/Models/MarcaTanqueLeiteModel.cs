using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class MarcaTanqueLeiteModel
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(40, ErrorMessage = "A Descrição da marca deve conter no máximo 40 caracteres")]
        public string Marca { get; set; }

        [MaxLength(40, ErrorMessage = "O modelo deve conter no máximo 40 caracteres")]
        public string Modelo { get; set; }

        public DateTime Fabricacao { get; set; }
    }
}