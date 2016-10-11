using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.ViewModel
{
   public class InterventionVM
    {
       public Intervention inter = new Intervention();
        public int ID
        {
            get { return inter.ID; }
            set { inter.ID = value; }
        }
        public string Realisation
        {
            get { return inter.Realisation==0 ? "Interne":"Externe"; }
           
        }
        public DateTime Date
        {
            get { return inter.Date; }
        }
        public DateTime DateFinPalnifie
        {
            get { return inter.Date; }
        }
        public DateTime DateFinReal
        {
            get { return inter.Date; }
        }
    }
}
