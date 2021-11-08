using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System_Application_Hotel_Hits.Models;
using System_Application_Hotel_Hits.Controllers;

namespace System_Application_Hotel_Hits.DataContext
{
    public class HotelDB : DbContext
    {
        

        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Fornecedores> fornecedores { get; set; }
        public DbSet<Fornecedores> Categoria { get; set; }
        public DbSet<Categoria> TipoCategoria { get; set; }
        public DbSet<Categoria> NomeCategoria { get; set; }

    }
}
