using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.ViewModel
{
  public  class AgentVM
    {
        public Agent agent = new Agent();
        public int ID {
            get { return agent.ID; }
            set { agent.ID = value; }
        }
        public string Matricule
        {
            get { return agent.Matricule; }
            set { agent.Matricule = value; }
        }
        public string Nom
        {
            get { return agent.Nom; }
            set { agent.Nom = value; }
        }
        public string Prenom
        {
            get { return agent.Prenom; }
            set { agent.Prenom = value; }
        }
        public DateTime DateRecrutement
        {
            get { return agent.DateRecrutement; }
            set { agent.DateRecrutement = value; }
        }
        public string Grade
        {
            get { return agent.Grade.Name; }
        }
        public string Fonction
        {
            get { return agent.Fonction.Name; }
        }
        public string StructureAffectation
        {
            get { return agent.StructureAffectation.Name; }
        }
        public int Echelon
        {
            get { return agent.Echelon; }
            set { agent.Echelon = value; }
        }
    }
}
