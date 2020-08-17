namespace SimpleSolution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomId = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        CreateDate = c.DateTime(),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ClassroomId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        ClassroomId = c.Guid(nullable: false),
                        CreateDate = c.DateTime(),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomId, cascadeDelete: true)
                .Index(t => t.ClassroomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassroomId", "dbo.Classrooms");
            DropIndex("dbo.Students", new[] { "ClassroomId" });
            DropTable("dbo.Students");
            DropTable("dbo.Classrooms");
        }
    }
}
