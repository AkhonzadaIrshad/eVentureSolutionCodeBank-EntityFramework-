namespace FirstDayWithEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "RollNumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "RollNumber", c => c.Int(nullable: true));
        }
    }
}
