using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInformatique.Model
{
 public   class SousCategorie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? CategorieID { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}
