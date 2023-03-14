namespace WebApplicationAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class schema12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProfessorName = c.String(),
                        ProfessorLastname = c.String(),
                        Profession = c.String(),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Nickname = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.Double(nullable: false),
                        Professor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professors", t => t.Professor_ID)
                .Index(t => t.Professor_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Professor_ID", "dbo.Professors");
            DropForeignKey("dbo.Professors", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Students", new[] { "Professor_ID" });
            DropIndex("dbo.Professors", new[] { "Account_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Professors");
        }
    }
}
