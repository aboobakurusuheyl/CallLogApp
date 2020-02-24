namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CallCategories",
                c => new
                    {
                        CallCategoryId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CallCategoryId);
            
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
                        StaffId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        CallCategoryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CallerId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false),
                        UserName = c.String(),
                        Designation = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false),
                        StatusDescription = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
            DropTable("dbo.Staffs");
            DropTable("dbo.Callers");
            DropTable("dbo.CallCategories");
        }
    }
}
