namespace Veloso.Deivid.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SocialCode = c.String(nullable: false, maxLength: 14),
                        FullName = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false, maxLength: 200),
                        Telephone = c.String(nullable: false, maxLength: 11),
                        Disabled = c.Boolean(),
                        DtCriated = c.DateTime(nullable: false),
                        DtUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.SocialCode, unique: true, name: "Index");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Client", "Index");
            DropTable("dbo.Client");
        }
    }
}
