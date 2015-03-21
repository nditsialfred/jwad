namespace JWAD.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JWAD.Data.JwadDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JWAD.Data.JwadDbContext context)
        {
            Seeder.Seed(context);
        }
    }
}
