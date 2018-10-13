using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bull.Models
{
    public class BalancaModel
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(40, ErrorMessage = "A descrição/identificação da balança deve conter no máximo 40 caracteres")]
        public string Descricao { get; set; }

        public MarcaBalancaModel Marca { get; set; }

        public DateTime DataAquisicao { get; set; }

        public float PesoMaximo { get; set; }

    }
}