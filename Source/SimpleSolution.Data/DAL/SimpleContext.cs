using SimpleSolution.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace SimpleSolution.Data.DAL
{
    public class SimpleContext : DbContext
    {
        public SimpleContext() : base("SimpleSolutionContext")
        {
            Database.SetInitializer(new SimpleInitializer());
        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

    }
}
