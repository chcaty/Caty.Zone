namespace Caty.Spider.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpiderArgsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpiderArgs",
                c => new
                    {
                        SpiderArgsId = c.Int(nullable: false, identity: true),
                        SpiderType = c.Int(nullable: false),
                        Hour = c.String(),
                        Minute = c.String(),
                    })
                .PrimaryKey(t => t.SpiderArgsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SpiderArgs");
        }
    }
}
