namespace _1811061230_TranPhanMinhTruong_BigShool.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_1811061230_TranPhanMinhTruong_BigShool.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_1811061230_TranPhanMinhTruong_BigShool.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest versio
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
