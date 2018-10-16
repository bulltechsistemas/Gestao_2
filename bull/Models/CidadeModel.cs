using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class CidadeModel
    {
        [Key]
        public int ID { get; set; }

        public enum UnidadeFederativa 
        {
            [Description("AC")]
            Acre             = 1,
            [Description("AL")]
            ALagoas          = 2,
            [Description("AP")]
            Amapa            = 3,
            [Description("AM")]
            Amazonas         = 4,
            [Description("BA")]
            Bahia            = 5,
            [Description("CE")]
            Ceara            = 6,
            [Description("DF")]
            DistritoFederal  = 7,
            [Description("ES")]
            EspiritoSanto    = 8,
            [Description("GO")]
            Goias            = 9,
            [Description("MA")]
            Maranhao         = 10,
            [Description("MT")]
            MatoGrosso       = 11,
            [Description("MS")]
            MatoGrossoDoSul  = 12,
            [Description("MG")]
            MinasGerais      = 13,
            [Description("PA")]
            Para             = 14,
            [Description("PB")]
            Paraiba          = 15,
            [Description("PR")]
            Parana           = 16,
            [Description("PE")]
            Pernambuco       = 17,
            [Description("PI")]
            Piaui            = 18,
            [Description("RJ")]
            RioDeJaneiro     = 19,
            [Description("RN")]
            RioGrandeDoNorte = 20,
            [Description("RS")]
            RioGrandeDoSul   = 21,
            [Description("RO")]
            Rondonia         = 22,
            [Description("RR")]
            Roraima          = 23,
            [Description("SC")]
            SantaCatarina    = 24,
            [Description("SP")]
            SaoPaulo         = 25,
            [Description("SE")]
            Sergipe          = 26,
            [Description("TO")]
            Tocantins        = 27,
        }

        [MaxLength(40, ErrorMessage = "A descrição deve conter no máximo 40 Caracteres")]
        public string Descricao { get; set; }

        public string CodigoEstadual { get; set; }

        public UnidadeFederativa UF { get; set; }

        public PaisModel Pais { get; set; }

        [MaxLength(3, ErrorMessage ="O DDD deve conter no máximo 3 caracteres")]
        public string DDD { get; set; }

        [MaxLength(8, ErrorMessage ="O CEP deve conter no maximo 8 caracteres")]
        public string CEP { get; set; }
    }
}