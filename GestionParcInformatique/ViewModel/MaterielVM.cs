using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.ViewModel
{
  public  class MaterielVM
    {
      public  Materiel materiel = new Materiel();
        public int ID
        {
            get { return materiel.ID; }
            set { materiel.ID = value; }
        }

        public string NumeroEquipement
        {
            get { return materiel.NumeroEquipement; }
            set { materiel.NumeroEquipement = value; }
        }
        public string Designation
        {
            get { return materiel.Designation; }
            set { materiel.Designation = value; }
        }
        public string PanneType
        {
            get { if (materiel.PanneType != null) return materiel.PanneType.Name;
                else
                    return "-";
            }
        }
        public DateTime MiseEnService
        {
            get { return materiel.MiseEnService; }
            set { materiel.MiseEnService = value; }
        }
        public DateTime DateAcquisition
        {
            get { return materiel.DateAcquisition; }
            set { materiel.DateAcquisition = value; }
        }
        public double Valeur
        {
            get { return materiel.Valeur; }
            set { materiel.Valeur = value; }
        }
        public string Fabriquant
        {
            get { return materiel.Fabriquant; }
            set { materiel.Fabriquant = value; }
        }
        public string Poids
        {
            get { return materiel.Poids; }
            set { materiel.Poids = value; }
        }
        public string Taille
        {
            get { return materiel.Taille; }
            set { materiel.Taille = value; }
        }
        public string NInventaire
        {
            get { return materiel.NInventaire; }
            set { materiel.NInventaire = value; }
        }
        public string NSerie
        {
            get { return materiel.NSerie; }
            set { materiel.NSerie = value; }
        }
        public string DureeVie
        {
            get { return materiel.DureeVie; }
            set { materiel.DureeVie = value; }
        }
      
        public string StructureAffectation
        {
            get { if (materiel.StructureAffectation != null) return materiel.StructureAffectation.Name; else return "-"; }
        }
        public string SousCategorie
        {
            get { if (materiel.SousCategorie != null) return materiel.SousCategorie.Name; else return "-"; }
        }
        public string Categorie
        {
            get { if (materiel.SousCategorie != null && materiel.SousCategorie.Categorie != null) return materiel.SousCategorie.Categorie.Name; else return "-"; }
        }
    }
}
