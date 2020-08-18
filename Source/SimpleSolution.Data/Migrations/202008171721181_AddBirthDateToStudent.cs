using System.Data.Entity.Migrations;

namespace SimpleSolution.Data.Migrations
{
    public partial class AddBirthDateToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDate");
        }
    }
}
