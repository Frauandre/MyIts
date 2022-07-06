namespace GAM_Collezioni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamCollezioni : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nominativo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mostre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titolo = c.String(),
                        Datazione = c.String(),
                        Tecnica = c.String(),
                        Dimensioni = c.String(),
                        Immagine = c.String(),
                        Autore_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Autori", t => t.Autore_Id)
                .Index(t => t.Autore_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mostre", "Autore_Id", "dbo.Autori");
            DropIndex("dbo.Mostre", new[] { "Autore_Id" });
            DropTable("dbo.Mostre");
            DropTable("dbo.Autori");
        }
    }
}
