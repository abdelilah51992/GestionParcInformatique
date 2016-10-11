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
    public partial class EquipementView : Form
    {
        Materiel materiel = new Materiel();
        AppContext db = new AppContext();
        public EquipementView()
        {
            InitializeComponent();
            try
            {
                cbStatut.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner un statut" });
                cbStatut.SelectedIndex = 0;
                foreach (var item in db.PanneTypes.ToList())
                    cbStatut.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbEntiteAffectation.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une entité" });
                cbEntiteAffectation.SelectedIndex = 0;
                foreach (var item in db.StructureAffectations.ToList())
                    cbEntiteAffectation.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbCategorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une catégorie" });
                cbCategorie.SelectedIndex = 0;
                foreach (var item in db.Categories.ToList())
                    cbCategorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });
            }
            catch (Exception)
            {
            }
        }
        public EquipementView(int id)
        {
            InitializeComponent();
            try
            {
                materiel = db.Materiels.Find(id);
                cbStatut.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner un statut" });
                cbStatut.SelectedIndex = 0;
                foreach (var item in db.PanneTypes.ToList())
                    cbStatut.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbEntiteAffectation.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une entité" });
                cbEntiteAffectation.SelectedIndex = 0;
                foreach (var item in db.StructureAffectations.ToList())
                    cbEntiteAffectation.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbCategorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une catégorie" });
                cbCategorie.SelectedIndex = 0;
                foreach (var item in db.Categories.ToList())
                    cbCategorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });
                //init data
                txtNumeroEduipement.Text= materiel.NumeroEquipement ;
                txtDesingation.Text= materiel.Designation ;
                foreach (var item in cbStatut.Items)
                {
                    if ((item as ComboboxItem).Value == materiel.PanneTypeID)
                        cbStatut.SelectedIndex = cbStatut.Items.IndexOf(item);
                }
              
                dtMiseEnService.Value= materiel.MiseEnService ;
                dtAcquisition.Value= materiel.DateAcquisition ;
                txtValeurAcquistion.Text= materiel.Valeur.ToString() ;
                txtFabriquant.Text= materiel.Fabriquant;
                txtPoids.Text= materiel.Poids;
                txtTaille.Text=materiel.Taille ;
                txtNInventaire.Text=materiel.NInventaire;
                txtNSerie.Text= materiel.NSerie ;
                txtDureeVie.Text= materiel.DureeVie;
                foreach (var item in cbEntiteAffectation.Items)
                {
                    if ((item as ComboboxItem).Value == materiel.StructureAffectationID)
                        cbEntiteAffectation.SelectedIndex = cbEntiteAffectation.Items.IndexOf(item);
                }
                if (materiel.SousCategorieID != 0)
                {
                    foreach (var item in cbCategorie.Items)
                    {
                        if ((item as ComboboxItem).Value == materiel.SousCategorie.CategorieID)
                            cbCategorie.SelectedIndex = cbCategorie.Items.IndexOf(item);
                    }
                }
                foreach (var item in cbSubCotegorie.Items)
                {
                    if ((item as ComboboxItem).Value == materiel.SousCategorieID)
                        cbSubCotegorie.SelectedIndex = cbSubCotegorie.Items.IndexOf(item);
                }
                if (materiel.ContratID != null)
                {
                    cbMaintenance.SelectedIndex = 1;
                    foreach (var item in cbContrats.Items)
                    {
                        if ((item as ComboboxItem).Value == materiel.ContratID)
                            cbContrats.SelectedIndex = cbContrats.Items.IndexOf(item);
                    }
                }
                else
                    cbContrats.Enabled = false;
            }
            catch (Exception)
            {
            }
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                materiel.NumeroEquipement = txtNumeroEduipement.Text;
                materiel.Designation = txtDesingation.Text;
                if ((cbStatut.SelectedItem as ComboboxItem).Value != 0)
                    materiel.PanneTypeID = (cbStatut.SelectedItem as ComboboxItem).Value;
                materiel.MiseEnService = dtMiseEnService.Value.Date;
                materiel.DateAcquisition = dtAcquisition.Value.Date;
                materiel.Valeur = Convert.ToDouble(txtValeurAcquistion.Text);
                materiel.Fabriquant = txtFabriquant.Text;
                materiel.Poids = txtPoids.Text;
                materiel.Taille = txtTaille.Text;
                materiel.NInventaire = txtNInventaire.Text;
                materiel.NSerie = txtNSerie.Text;
                materiel.DureeVie = txtDureeVie.Text;
                if ((cbEntiteAffectation.SelectedItem as ComboboxItem).Value != 0)
                    materiel.StructureAffectationID = (cbEntiteAffectation.SelectedItem as ComboboxItem).Value;
                if ((cbSubCotegorie.SelectedItem as ComboboxItem).Value != 0)
                    materiel.SousCategorieID = (cbCategorie.SelectedItem as ComboboxItem).Value;
                if(!cbMaintenance.SelectedItem.ToString().Contains("Garantie"))
                {
                    if ((cbContrats.SelectedItem as ComboboxItem).Value != 0)
                        materiel.ContratID = (cbContrats.SelectedItem as ComboboxItem).Value;
                }
                if(materiel.ID==0)
                db.Materiels.Add(materiel);
                db.SaveChanges();
            }
            catch (Exception)
            {
            }
        }

        private void cbMaintenance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMaintenance.SelectedItem.ToString().Contains("Garantie"))
                {
                    cbContrats.Enabled = false;
                }
                else
                {
                    cbContrats.Enabled = true; cbContrats.Items.Clear();
                    cbContrats.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner un contrat" });
                    cbContrats.SelectedIndex = 0;
                    foreach (var item in db.Contrats.ToList())
                        cbContrats.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.NumeroContrat });
                }
            }
            catch (Exception)
            {
            }
        }

        private void cbMaintenance_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (cbCategorie.SelectedItem as ComboboxItem).Value;
                cbSubCotegorie.Items.Clear();
                cbSubCotegorie.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner un contrat" });
                cbSubCotegorie.SelectedIndex = 0;
                foreach (var item in db.SousCategories.Where(a=>a.CategorieID==id).ToList())
                    cbSubCotegorie.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });
            }
            catch (Exception)
            {
            }
        }
    }
}
