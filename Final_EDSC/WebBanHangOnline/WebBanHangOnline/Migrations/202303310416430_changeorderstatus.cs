namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeorderstatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Order", "OrderStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "OrderStatus", c => c.String());
        }
    }
}
