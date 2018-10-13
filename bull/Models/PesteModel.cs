using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class PesteModel
    {
        [Key]
        public int ID { get; set; }

        public enum Grau
        {
            Baixo = 1
        }

        public enum SimNao
        {
            Sim = 'S',
            Nao = 'N'
        }

        public Grau GrauPericulosidade { get; set; }

        public SimNao NecessitaVeterinario { get; set; }
    }
}