using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace System_Application_Hotel_Hits.Models
{
    public class BaseAtributos
    {
       
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string Reserva { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Passaporte { get; set; }
        public string DataNascimento { get; set; }
    }
       
    public class BaseContatos 
    {
        public string Rua { get; set; }


        public string Numero { get; set; }


        public string Bairro { get; set; }


        public string Cep { get; set; }


        public string Municipio { get; set; }


        public string Estado { get; set; }


        public string Pais { get; set; }

        [DisplayName("Telefone Fixo")]
        public string TelefoneFixo { get; set; }


        public string Celular { get; set; }


        public string WhatsApp { get; set; }


        public string Email { get; set; }
    }
}