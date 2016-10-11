namespace GestionParcInformatique.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestionParcInformatique.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GestionParcInformatique.AppContext context)
        {
            context.Categories.AddOrUpdate(
                new Categorie() {   ID=1 , Name="Equipement Bureautique"  },
                new Categorie() {   ID=2 , Name="Equipement serveurs et stockage"  },
                new Categorie() {   ID=3 , Name="Equipement réseau et sécurité"  },
                new Categorie() {   ID=4 , Name= "Equipement d'evironnement et sécurité" }
                );

            context.SousCategories.AddOrUpdate(
                new SousCategorie() { ID=1,  CategorieID=1  , Name="PC de bureau - Unité centrale" },
                new SousCategorie() { ID=2,  CategorieID=1  , Name="PC de bureau - Ecran" },
                new SousCategorie() { ID=3,  CategorieID=1  , Name="PC de bureau - Clavier" },
                new SousCategorie() { ID=4,  CategorieID=1  , Name= "PC de bureau - Souris" },

                new SousCategorie() { ID = 5, CategorieID = 1, Name = "PC Portable" },
                new SousCategorie() { ID = 6, CategorieID = 1, Name = "Imprimante" },
                new SousCategorie() { ID = 7, CategorieID = 1, Name = "Scanner" },
                new SousCategorie() { ID = 8, CategorieID = 1, Name = "Fax" },
                new SousCategorie() { ID = 9, CategorieID = 1, Name = "Photocopieurse" },
                new SousCategorie() { ID = 10, CategorieID = 1, Name = "Poste Téléphonique" },

                new SousCategorie() { ID=11,  CategorieID=2  , Name= "Serveur" },
                new SousCategorie() { ID=12,  CategorieID=2  , Name= "Baie de Stockage" },
                new SousCategorie() { ID=13,  CategorieID=2  , Name= "Robot de sauvegade" },

                new SousCategorie() { ID = 14, CategorieID = 3, Name = "Switch" },
                new SousCategorie() { ID = 15, CategorieID = 3, Name = "Routeur" },
                new SousCategorie() { ID = 16, CategorieID = 3, Name = "Firewall" },
                new SousCategorie() { ID = 17, CategorieID = 3, Name = "Proxy" },

                new SousCategorie() { ID = 18, CategorieID = 4, Name = "Climatiseur" },
                new SousCategorie() { ID = 19, CategorieID = 4, Name = "Onduleur" },
                new SousCategorie() { ID = 20, CategorieID = 4, Name = "Vidéo-surveillance" },
                new SousCategorie() { ID = 21, CategorieID = 4, Name = "Contôle d'accès" },
                new SousCategorie() { ID = 22, CategorieID = 4, Name = "Détecteur de fuite d'eau" },
                new SousCategorie() { ID = 23, CategorieID = 4, Name = "Détecteur d'incendie" }
                );

            context.PanneTypes.AddOrUpdate(
                new PanneType() {  ID=1 , Name="Actif" },
                new PanneType() {  ID=2 , Name="En panne" },
                new PanneType() {  ID=3 , Name="En réforme" }
                );
            context.Fonctions.AddOrUpdate(
                new Fonction() { ID=1 , Name= "Directeur" },
                new Fonction() { ID=2 , Name= "Chef de service" },
                new Fonction() { ID=3 , Name= "Employee" },
                new Fonction() { ID=4 , Name= "Comptable" }
                );
            context.Grades.AddOrUpdate(
                new Grade() {  ID=1, Name="Ingénieur" },
                new Grade() {  ID=2, Name= "Administrateur" }
                );
            context.StructureAffectations.AddOrUpdate(
                new StructureAffectation() {  ID=1 , Name="DAAG" },
                new StructureAffectation() {  ID=2 , Name= "DB" },
                new StructureAffectation() {  ID=3 , Name= "IGF" }
                );
            context.Causes.AddOrUpdate(
           new Cause() { ID = 1, Name = "Electricité" },
           new Cause() { ID = 2, Name = "Autre" }
           );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
