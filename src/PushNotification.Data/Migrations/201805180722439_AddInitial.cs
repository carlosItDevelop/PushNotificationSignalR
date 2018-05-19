namespace PushNotification.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        ContactName = c.String(nullable: false, maxLength: 40, unicode: false),
                        ContactNo = c.String(nullable: false, maxLength: 8, unicode: false),
                        AddedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contact");
        }
    }
}
