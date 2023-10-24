namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeorderstatuss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Order", "OrderStatus", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "OrderStatus", c => c.Int(nullable: false));
        }
    }
}
