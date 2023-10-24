namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateorder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "CouponId", c => c.Int());
            AddColumn("dbo.tb_Order", "Discount", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Order", "Discount");
            DropColumn("dbo.tb_Order", "CouponId");
        }
    }
}
