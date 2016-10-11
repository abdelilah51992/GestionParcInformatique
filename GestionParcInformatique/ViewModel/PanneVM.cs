using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.ViewModel
{
 public   class PanneVM
    {
     public Panne panne = new Panne();
        public int ID
        {
            get { return panne.ID; }
            set { panne.ID = value; }
        }

        public string Materiel
        {
            get { if (panne.Materiel != null) return panne.Materiel.NumeroEquipement; else return "-"; }
        }
        public string Cause
        {
            get { if (panne.Cause != null) return panne.Cause.Name; else return "-"; }
        }
        public DateTime Date
        {
            get { return panne.Date; }
        }
        public DateTime Fin
        {
            get { return panne.Fin; }
        }
    }
}
