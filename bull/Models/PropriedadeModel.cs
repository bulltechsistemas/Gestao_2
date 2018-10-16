using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class PropriedadeModel
    {
        [Key]
        public int ID { get; set; }

        public enum TipoInscricao
        {
            CPF = 1,
            CNPJ = 2,
            CEI = 3
        }

        public enum Assinatura
        {
            Proprietario = 1,
            Responsavel = 2,
            ProprietarioEResponsavel = 3
        }

        [MaxLength(80, ErrorMessage = "A descrição deve conter no máximo 80 caracteres")]
        public string Descricao { get; set; }

        [MaxLength(40, ErrorMessage = "O endereço deve conter no máximo 40 caracteres")]
        public string Endereco { get; set; }

        [MaxLength(10, ErrorMessage ="O Cep deve conter no máximo 10 caracteres")]
        public string Cep { get; set; }

        [MaxLength(10, ErrorMessage ="O Numero deve conter no máximo 10 caracteres")]
        public string Numero { get; set; }

        [MaxLength(40, ErrorMessage = "O complemento deve conter no máximo 40 caracteres")]
        public string Complemento { get; set; }
        
        public CidadeModel Cidade { get; set; }

        public TipoInscricao TipoDeInscricao { get; set; }

        [MaxLength(15, ErrorMessage ="A inscrição deve conter no máximo 15 caracteres")]
        public string Inscricao { get; set; }

        [MaxLength(15, ErrorMessage = "A inscrição Estadual deve conter no máximo 15 caracteres")]
        public string InscricaoEstadual { get; set; }

        [MaxLength(80, ErrorMessage = "O Proprietario deve conter no máximo 80 caracteres")]
        public string Proprietario { get; set; }

        [MaxLength(80, ErrorMessage = "O responsavel deve conter no máximo 80 caracteres")]
        public string Responsavel { get; set; }

        public Assinatura AssinaturaRelatorios { get; set; }

        [MaxLength(40, ErrorMessage = "O email deve conter no máximo 40 caracteres")]
        public string Email { get; set; }

        [MaxLength(40, ErrorMessage = "O tipo de manejo deve conter no máximo 40 caracteres")]
        public string TipoManejo { get; set; }

        public List<TelefoneModel> Telefones { get; set; }

    }
}