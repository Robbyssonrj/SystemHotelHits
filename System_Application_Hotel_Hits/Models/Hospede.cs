using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace System_Application_Hotel_Hits.Models
{
    public class Hospede : BaseEndereco
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nome")]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public string Passaporte { get; set; }       
        public double ContaReserva { get; set; }
        public Hospede Hospedes { get;  set; }
    }
}