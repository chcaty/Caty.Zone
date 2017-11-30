namespace Caty.Spider.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        BookLink = c.String(),
                        DownloadLink = c.String(),
                        DownloadLink_BDYP = c.String(),
                        DownloadPsw_BDYP = c.String(),
                        DownloadLink_CTWP = c.String(),
                        DownloadPsw_CTWP = c.String(),
                        DownloadLink_TYYP = c.String(),
                        DownloadPsw_TYYP = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
