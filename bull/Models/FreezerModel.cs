using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class FreezerModel
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(40, ErrorMessage = "A descrição deve conter no máximo 40 caracteres")]
        public string Descricao { get; set; }

        public MarcaFreezerModel Marca { get; set; }

        public DateTime DataAquisicao { get; set; }
        
        public float Capacidade { get; set; }
    }
}