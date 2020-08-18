using SimpleSolution.Data.DAL;
using System.Data.Entity.Migrations;

namespace SimpleSolution.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<SimpleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SimpleSolution.Data.DAL.SimpleContext";
        }

        protected override void Seed(SimpleContext context)
        {
            SimpleInitializer.SeedSimpleData(context);
        }
    }
}
