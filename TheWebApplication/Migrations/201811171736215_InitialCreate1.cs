namespace TheWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "EnrollmentDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "EnrollmentDate", c => c.DateTime(nullable: false));
        }
    }
}
