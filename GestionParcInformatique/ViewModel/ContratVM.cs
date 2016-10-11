using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.ViewModel
{
  public  class ContratVM
    {
        Contrat contrat = new Contrat();
        [Display(Name ="Identifiant")]
        public int ID
        {
            get { return contrat.ID; }
            set { contrat.ID = value; }
        }
        [Display(Name = "N° Contrat")]

        public string NumeroContrat
        {
            get { return contrat.NumeroContrat; }
            set { contrat.NumeroContrat = value; }
        }
        [Display(Name = "Date du contrat")]
        public DateTime Date
        {
            get { return contrat.Date; }
            set { contrat.Date = value; }
        }
        [Display(Name = "Date fin du contrat")]
        public DateTime Fin
        {
            get { return contrat.Fin; }
            set { contrat.Fin = value; }
        }
        [Display(Name = "Code Fournisseur")]
        public string CodeFournisseur
        {
            get { return contrat.CodeFournisseur; }
            set { contrat.CodeFournisseur = value; }
        }
        [Display(Name = "Raison sociale")]
        public string RaisonSociale
        {
            get { return contrat.RaisonSociale; }
            set { contrat.RaisonSociale = value; }
        }
        [Display(Name = "Montant du contrat")]
        public double Montant
        {
            get { return contrat.Montant; }
            set { contrat.Montant = value; }
        }
    }
}
