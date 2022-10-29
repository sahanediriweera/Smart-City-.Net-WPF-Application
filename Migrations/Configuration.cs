namespace Testing_GUI_Project_DataBase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Testing_GUI_Project_DataBase.Database.MyEntireDataRepository>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Testing_GUI_Project_DataBase.Database.MyEntireDataRepository";
        }

        protected override void Seed(Testing_GUI_Project_DataBase.Database.MyEntireDataRepository context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
