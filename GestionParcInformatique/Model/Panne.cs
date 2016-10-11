using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.Model
{
   public class Panne
    {
        public int ID { get; set; }
        public int? MaterielID { get; set; }
        public virtual Materiel Materiel { get; set; }
        public DateTime Date { get; set; }
        public DateTime Fin { get; set; }
        public int? CauseID { get; set; }
        public virtual Cause Cause { get; set; }
    }
}
