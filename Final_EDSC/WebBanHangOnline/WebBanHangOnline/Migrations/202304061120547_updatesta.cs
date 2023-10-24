namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatesta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.tb_Product", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.tb_Order", "Status");
        }
    }
}
