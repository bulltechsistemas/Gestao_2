using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bull.Models
{
    public class FornecedorModel
    {
        [Key]
        public int ID { get; set; }

        public enum TipoInscricao
        {
            CNPJ = 1,
            CPF = 2
        }

        public enum TipoIdentificacao
        {
            RG = 1,
            InscricaoEstadual = 2
        }

        public TipoInscricao TipoDeInscricao { get; set; }

        [MaxLength(15, ErrorMessage = "A inscrição deve conter no máximo 15 caracteres")]
        public string Inscricao;

        public TipoIdentificacao TipoDeIdentificacao { get; set; }

        [MaxLength(15, ErrorMessage = "A identificacao deve conter no máximo 15 caracteres")]
        public string Identificacao;

        [MaxLength(80, ErrorMessage = "O nome deve conter no máximo 80 caracteres")]
        public string Nome;

        public TelefoneModel TelefonePrincipal { get; set; }

        public TelefoneModel TelefoneSecundario { get; set; }

        [MaxLength(40, ErrorMessage = "O email deve conter no máximo 40 caracteres")]
        public string EMail { get; set; }

        [MaxLength(40, ErrorMessage = "O endereço deve conter no máximo 40 caracteres")]
        public string Endereco { get; set; }

        [MaxLength(10, ErrorMessage = "O Cep deve conter no máximo 10 caracteres")]
        public string CEP { get; set; }

        [MaxLength(10, ErrorMessage = "O número deve conter no máximo 10 caracteres")]
        public string Numero { get; set; }

        [MaxLength(40, ErrorMessage = "O complemento deve conter no máximo 40 caracteres")]
        public string Complemento { get; set; }

        public CidadeModel Cidade { get; set; }
    }
}