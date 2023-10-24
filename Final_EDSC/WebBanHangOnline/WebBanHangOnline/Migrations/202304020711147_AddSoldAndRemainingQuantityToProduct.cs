namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSoldAndRemainingQuantityToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "SoldQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.tb_Product", "RemainingQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "RemainingQuantity");
            DropColumn("dbo.tb_Product", "SoldQuantity");
        }
    }
}
