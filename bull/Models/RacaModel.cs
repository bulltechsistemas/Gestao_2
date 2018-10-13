using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class RacaModel
    {
        [Key]
        public int ID { get; set; }
        
        [MaxLength(40, ErrorMessage ="A descrição deve ter no máximo 40 caracteres")]
        public string Descricao { get; set; }

        public enum Tipo
        {
            Corte = 1,
            leite = 2
        }

        public Tipo TipoPredominancia { get; set; }

        public string InromacoesAdicionais { get; set; }
    }
}