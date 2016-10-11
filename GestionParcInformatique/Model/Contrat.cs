using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.Model
{
    public class Contrat
    {
        public int ID { get; set; }
        public string NumeroContrat { get; set; }
        public DateTime Date { get; set; }
        public DateTime Fin { get; set; }
        public string CodeFournisseur { get; set; }
        public string RaisonSociale { get; set; }
        public double Montant { get; set; }
    }
}
