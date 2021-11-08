using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System_Application_Hotel_Hits.Migrations;



namespace System_Application_Hotel_Hits.Models
{
    public class Fornecedores : BaseContatos
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nome Empresa")]
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string Categoria { get; set; }
        public string TipoCategoria { get; set; }
        [DisplayName("Inscrição Estadual")]
        public string InscricaoEstatual{ get; set; }
                  
    }
    public class Categoria : Fornecedores    {
        public new int Id { get; set; }
        public string NomeCategoria { get; set; }
        public string NomeTipoCategoria { get; set; }

    }

 }


 
