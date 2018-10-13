using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class CidadeModel
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(40, ErrorMessage = "A descrição deve conter no máximo 40 Caracteres")]
        public string Descricao { get; set; }

        public string CodigoEstadual { get; set; }

        public UnidadeFederativaModel UF { get; set; }

        public PaisModel Pais { get; set; }

        [MaxLength(3, ErrorMessage ="O DDD deve conter no máximo 3 caracteres")]
        public string DDD { get; set; }

        [MaxLength(8, ErrorMessage ="O CEP deve conter no maximo 8 caracteres")]
        public string CEP { get; set; }
    }
}