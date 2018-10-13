using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class PastoModel
    {
        [Key]
        public int ID { get; set; }

        public TipoMedicaoModel TipoMedicao { get; set; }

        public int CapacidadeAnimais { get; set; }

        public string DimensaoCampo { get; set; }

        public string OrientacaoTerritorio { get; set; }
    }
}