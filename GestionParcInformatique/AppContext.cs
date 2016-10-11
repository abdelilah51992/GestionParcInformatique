using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique
{
  public  class AppContext : DbContext
    {
        public AppContext() :base("name=DefaultConnection")
        {

        }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<SousCategorie> SousCategories { get; set; }
        public DbSet<PanneType> PanneTypes { get; set; }
        public DbSet<Fonction> Fonctions { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Materiel> Materiels { get; set; }
        public DbSet<StructureAffectation> StructureAffectations { get; set; }
        public DbSet<Panne> Pannes { get; set; }
        public DbSet<Cause> Causes { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
    }

}
