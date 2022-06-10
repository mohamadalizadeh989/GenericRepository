namespace Generic.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Generic_Db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Family = c.String(nullable: false, maxLength: 150),
                        Mobile = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
