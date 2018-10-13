using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class TanqueLeiteModel
    {
        [Key]
        public int ID { get; set; }

        public string Descricao { get; set; }

        public MarcaTanqueLeiteModel Marca { get; set; }

        public DateTime DataAquisicao { get; set; }

        public float Capacidade { get; set; }
    }
}