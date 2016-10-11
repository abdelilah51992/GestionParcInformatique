using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.Model
{
   public class Materiel
    {
        public int ID { get; set; }
        public string NumeroEquipement { get; set; }
        public string Designation { get; set; }
        public int? PanneTypeID { get; set; }
        public virtual PanneType PanneType { get; set; }
        public int? SousCategorieID { get; set; }
        public virtual SousCategorie SousCategorie { get; set; }
        public DateTime MiseEnService { get; set; }
        public DateTime DateAcquisition { get; set; }
        public double Valeur { get; set; }
        public string Fabriquant { get; set; }
        public string Poids { get; set; }
        public string Taille { get; set; }
        public string NInventaire { get; set; }
        public string NSerie { get; set; }
        public string DureeVie { get; set; }
        public int? StructureAffectationID { get; set; }
        public virtual StructureAffectation StructureAffectation { get; set; }
        public int? ContratID { get; set; }
        public virtual  Contrat Contrat { get; set; }

    }
}
