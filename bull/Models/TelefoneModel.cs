using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class TelefoneModel
    {
        [Key]
        public int ID { get; set; }

        public string DDD { get; set; }

        public string NumeroTelefone { get; set; }
    }
}