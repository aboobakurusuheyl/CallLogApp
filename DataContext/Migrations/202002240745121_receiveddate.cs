namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class receiveddate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Callers", "ReceivedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Callers", "ReceivedDate");
        }
    }
}
