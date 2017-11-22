namespace PersonalFinanceSite.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressInformation",
                c => new
                    {
                        AddressInformationPK = c.Guid(nullable: false),
                        UserFK = c.Guid(nullable: false),
                        AddressLine1 = c.String(maxLength: 256),
                        AddressLine2 = c.String(maxLength: 256),
                        City = c.String(maxLength: 256),
                        State = c.String(maxLength: 256),
                        Zip = c.String(maxLength: 16),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AddressInformationPK);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserPK = c.Guid(nullable: false),
                        UserName = c.String(maxLength: 256),
                        FirstName = c.String(maxLength: 256),
                        LastName = c.String(maxLength: 256),
                        MiddleName = c.String(maxLength: 256),
                        Email = c.String(maxLength: 256),
                        Age = c.Int(nullable: false),
                        Gender = c.String(maxLength: 256),
                        VeteranStatus = c.String(maxLength: 256),
                        Birthday = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserPK);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.AddressInformation");
        }
    }
}
