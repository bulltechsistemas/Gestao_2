using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bull.Models
{
    public class AnimalModel
    {
        [Key]
        public int ID { get; set; }

        public enum TipoOrigem
        {
            Lote = 1,
            Cobertura =2
        };

        public enum TipoSexo
        {
            Macho = 'M',
            Femea = 'F'
        }

        public enum AnimalDesmamado
        {
            Sim = 'S',
            Nao = 'N'
        }

        public TipoOrigem Origem { get; set; }

        [MaxLength(10, ErrorMessage = "O número da cobertura deve conter no máximo 10 caracteres")]
        public string NumeroCobertura { get; set; }

        [MaxLength(40, ErrorMessage = "O nome do animal deve conter no máximo 40 caracteres")]
        public string NomeAnimal { get; set; }

        public DateTime DataNascimento { get; set; }

        public RacaModel Raca { get; set; }

        public TipoSexo Sexo { get; set; }
            
        public AnimalDesmamado Desmamado { get; set; }

        [MaxLength(20, ErrorMessage = "A pelagem do animal deve conter no máximo 20 caracteres")]
        public string Pelagem { get; set; }

        public int Categoria { get; set; }

        public double Peso { get; set; }

    }
}