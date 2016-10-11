using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.Model
{
   public class Intervention
    {
        public int ID { get; set; }
        public int? PanneID { get; set; }
        public Panne Panne { get; set; }
        public int Realisation { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateFinPalnifie { get; set; }
        public DateTime DateFinReal { get; set; }
    }
}
