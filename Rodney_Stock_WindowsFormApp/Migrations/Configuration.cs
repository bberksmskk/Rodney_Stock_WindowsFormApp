namespace Rodney_Stock_WindowsFormApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rodney_Stock_WindowsFormApp.Models.RodneyStockDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Rodney_Stock_WindowsFormApp.Models.RodneyStockDB context)
        {
            //context.Managers.AddOrUpdate(x => x.ID, new Models.Manager() { ID = 1, Name = "Berk", Surname = "Şimşek", Email = "dev@dev.com", Username = "developer", Password = "1234", IsActive = true, IsDeleted = false });
        }
    }
}




