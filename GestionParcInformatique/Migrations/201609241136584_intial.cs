namespace GestionParcInformatique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateRecrutement = c.DateTime(nullable: false),
                        GradeID = c.Int(),
                        Echelon = c.Int(nullable: false),
                        FonctionID = c.Int(),
                        StructureAffectationID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Fonctions", t => t.FonctionID)
                .ForeignKey("dbo.Grades", t => t.GradeID)
                .ForeignKey("dbo.StructureAffectations", t => t.StructureAffectationID)
                .Index(t => t.GradeID)
                .Index(t => t.FonctionID)
                .Index(t => t.StructureAffectationID);
            
            CreateTable(
                "dbo.Fonctions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StructureAffectations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PanneTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SousCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategorieID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategorieID)
                .Index(t => t.CategorieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SousCategories", "CategorieID", "dbo.Categories");
            DropForeignKey("dbo.Agents", "StructureAffectationID", "dbo.StructureAffectations");
            DropForeignKey("dbo.Agents", "GradeID", "dbo.Grades");
            DropForeignKey("dbo.Agents", "FonctionID", "dbo.Fonctions");
            DropIndex("dbo.SousCategories", new[] { "CategorieID" });
            DropIndex("dbo.Agents", new[] { "StructureAffectationID" });
            DropIndex("dbo.Agents", new[] { "FonctionID" });
            DropIndex("dbo.Agents", new[] { "GradeID" });
            DropTable("dbo.SousCategories");
            DropTable("dbo.PanneTypes");
            DropTable("dbo.Categories");
            DropTable("dbo.StructureAffectations");
            DropTable("dbo.Grades");
            DropTable("dbo.Fonctions");
            DropTable("dbo.Agents");
        }
    }
}
