namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderStatusColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "OrderStatus", c => c.String());
            DropColumn("dbo.tb_Order", "ShipingStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Order", "ShipingStatus", c => c.Int(nullable: false));
            DropColumn("dbo.tb_Order", "OrderStatus");
        }
    }
}
