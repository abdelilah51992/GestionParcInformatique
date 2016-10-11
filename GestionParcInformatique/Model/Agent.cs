using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.Model
{
   public class Agent
    {
        public int ID { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateRecrutement { get; set; }
        public int? GradeID { get; set; }
        public virtual Grade Grade { get; set; }
        public int Echelon  { get; set; }
        public int? FonctionID { get; set; }
        public virtual Fonction Fonction { get; set; }
        public int?  StructureAffectationID { get; set; }
        public virtual StructureAffectation StructureAffectation { get; set; }
    }
}
