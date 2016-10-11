using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParcInformatique.View
{
    public partial class PanneView : Form
    {
        AppContext db = App.db;
        Panne panne = new Panne();

        public PanneView()
        {
            InitializeComponent();
            try
            {
                cbCategorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une catégories" });
                cbCategorie.SelectedIndex = 0;
                foreach (var item in db.Categories.ToList())
                    cbCategorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbSousCategorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une sous catégories" });
                cbSousCategorie.SelectedIndex = 0;
                foreach (var item in db.Categories.ToList())
                    cbSousCategorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbCausePanne.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une cause" });
                cbCausePanne.SelectedIndex = 0;
                foreach (var item in db.Causes.ToList())
                    cbCausePanne.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });
            }
            catch (Exception)
            {
            }
        }

        public PanneView(int v)
        {
            InitializeComponent();

            panne = db.Pannes.Find(v);
            cbCategorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une catégories" });
            cbCategorie.SelectedIndex = 0;
            foreach (var item in db.Categories.ToList())
                cbCategorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

            cbSousCategorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une sous catégories" });
            cbSousCategorie.SelectedIndex = 0;
            foreach (var item in db.Categories.ToList())
                cbSousCategorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

            cbCausePanne.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une cause" });
            cbCausePanne.SelectedIndex = 0;
            foreach (var item in db.Causes.ToList())
                cbCausePanne.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

            //init data
            dtPanne.Value= panne.Date ;
            tmPanne.Value= panne.Date;
            dtFinPanne.Value= panne.Fin ;
            tmFinPanne.Value=panne.Fin  ;
            if (panne.Materiel!=null && panne.Materiel.SousCategorie != null)
            {
                foreach (var item in cbCategorie.Items)
                {
                    if ((item as ComboboxItem).Value == panne.Materiel.SousCategorie.CategorieID)
                        cbCategorie.SelectedIndex = cbCategorie.Items.IndexOf(item);
                }
                foreach (var item in cbSousCategorie.Items)
                {
                    if ((item as ComboboxItem).Value == panne.Materiel.SousCategorieID)
                        cbSousCategorie.SelectedIndex = cbSousCategorie.Items.IndexOf(item);
                }
            }
            foreach (var item in cbCausePanne.Items)
            {
                if ((item as ComboboxItem).Value == panne.CauseID)
                    cbCausePanne.SelectedIndex = cbCausePanne.Items.IndexOf(item);
            }
            foreach (var item in cbEquipement.Items)
            {
                if ((item as ComboboxItem).Value == panne.CauseID)
                    cbEquipement.SelectedIndex = cbEquipement.Items.IndexOf(item);
            }
        }

        private void PanneView_Load(object sender, EventArgs e)
        {

        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (cbCategorie.SelectedItem as ComboboxItem).Value;
                cbSousCategorie.Items.Clear();
                cbSousCategorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une sous catégorie" });
                cbSousCategorie.SelectedIndex = 0;
                foreach (var item in db.SousCategories.Where(a => a.CategorieID == id).ToList())
                    cbSousCategorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });
            }
            catch (Exception)
            {
            }
        }

        private void cbSousCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (cbSousCategorie.SelectedItem as ComboboxItem).Value;
                cbEquipement.Items.Clear();
                cbEquipement.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner un équipement" });
                cbEquipement.SelectedIndex = 0;
                foreach (var item in db.Materiels.Where(a => a.SousCategorieID == id).ToList())
                    cbEquipement.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.NumeroEquipement });
            }
            catch (Exception)
            {
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                panne.Date = dtPanne.Value.Date;
                panne.Date += tmPanne.Value.TimeOfDay;
                panne.Fin = dtFinPanne.Value.Date;
                panne.Fin += tmFinPanne.Value.TimeOfDay;

                if ((cbCausePanne.SelectedItem as ComboboxItem).Value != 0)
                    panne.CauseID = (cbCausePanne.SelectedItem as ComboboxItem).Value;
                if ((cbEquipement.SelectedItem as ComboboxItem).Value != 0)
                    panne.MaterielID = (cbEquipement.SelectedItem as ComboboxItem).Value;
                if(panne.ID==0)
                  db.Pannes.Add(panne);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
