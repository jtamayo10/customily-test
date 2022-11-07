namespace CustomilyNETTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initpsg : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Images", "X", c => c.Long(nullable: false));
            AlterColumn("dbo.Images", "Y", c => c.Long(nullable: false));
            AlterColumn("dbo.Images", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Images", "ModfiedDate", c => c.DateTime());
            AlterColumn("dbo.Items", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Items", "ModfiedDate", c => c.DateTime());
            AlterColumn("dbo.Texts", "X", c => c.Long(nullable: false));
            AlterColumn("dbo.Texts", "Y", c => c.Long(nullable: false));
            AlterColumn("dbo.Texts", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Texts", "ModfiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Texts", "ModfiedDate", c => c.DateTime());
            AlterColumn("dbo.Texts", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Texts", "Y", c => c.String());
            AlterColumn("dbo.Texts", "X", c => c.String());
            AlterColumn("dbo.Items", "ModfiedDate", c => c.DateTime());
            AlterColumn("dbo.Items", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Images", "ModfiedDate", c => c.DateTime());
            AlterColumn("dbo.Images", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Images", "Y", c => c.String());
            AlterColumn("dbo.Images", "X", c => c.String());
        }
    }
}
