namespace System_Application_Hotel_Hits.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System_Application_Hotel_Hits.DataContext;
    using System_Application_Hotel_Hits.Models;
    using System_Application_Hotel_Hits.Controllers;

    internal sealed class Configuration : DbMigrationsConfiguration<System_Application_Hotel_Hits.DataContext.HotelDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HotelDB context)
        {
            
                        


            context.fornecedores.AddOrUpdate(c => c.Categoria,
                                          new Categoria { NomeCategoria = "Horti Fruti" },
                                          new Categoria { NomeTipoCategoria = "Refrigerantes" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
