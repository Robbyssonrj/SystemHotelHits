using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace System_Application_Hotel_Hits.Models
{
    public class BaseEndereco
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