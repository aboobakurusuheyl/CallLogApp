namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class callinfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CallInfoes",
                c => new
                    {
                        CallInfoId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Contact = c.String(),
                        Address = c.String(),
                        Summary = c.String(),
                        CallDuration = c.String(),
                        Dob = c.DateTime(nullable: false),
                        ReceivedDate = c.DateTime(nullable: false),
                        StaffId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        CallCategoryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CallInfoId);
            
            DropTable("dbo.Callers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Callers",
                c => new
                    {
                        CallerId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Contact = c.String(),
                        Address = c.String(),
                        Summary = c.String(),
                        CallDuration = c.String(),
                        Dob = c.DateTime(nullable: false),
                        ReceivedDate = c.DateTime(nullable: false),
                        StaffId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        CallCategoryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CallerId);
            
            DropTable("dbo.CallInfoes");
        }
    }
}
