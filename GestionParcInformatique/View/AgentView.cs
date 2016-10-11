using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParcInformatique.View
{
    public partial class AgentView : Form
    {
        AppContext db =App.db;
        Agent agent = new Agent();

        public AgentView()
        {
            InitializeComponent();
            try
            {
                cbGrades.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une grade" });
                cbGrades.SelectedIndex = 0;
                foreach (var item in db.Grades.ToList())
                    cbGrades.Items.Add( new ComboboxItem() { Value=item.ID,Text= item.Name } );

                cbFonctions.Items.Add(new ComboboxItem() { Value = 0, Text = "selectionner une fonction" });
                cbFonctions.SelectedIndex = 0;
                foreach (var item in db.Fonctions.ToList())
                    cbFonctions.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbStructures.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une structeur" });
                cbStructures.SelectedIndex = 0;
                foreach (var item in db.StructureAffectations.ToList())
                    cbStructures.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });
            }
            catch (Exception)
            {

            }
        }

        public AgentView(int v)
        {
            InitializeComponent();
            try
            {
                cbGrades.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une grade" });
                cbGrades.SelectedIndex = 0;
                foreach (var item in db.Grades.ToList())
                    cbGrades.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbFonctions.Items.Add(new ComboboxItem() { Value = 0, Text = "selectionner une fonction" });
                cbFonctions.SelectedIndex = 0;
                foreach (var item in db.Fonctions.ToList())
                    cbFonctions.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

                cbStructures.Items.Add(new ComboboxItem() { Value = 0, Text = " selectionner une structeur" });
                cbStructures.SelectedIndex = 0;
                foreach (var item in db.StructureAffectations.ToList())
                    cbStructures.Items.Add(new ComboboxItem() { Value = item.ID, Text = item.Name });

            agent = db.Agents.Find(v);
            txtMatricule.Text=agent.Matricule ;
            txtNom.Text = agent.Nom ;
            txtPrenom.Text= agent.Prenom;
            dtRecrutement.Value = agent.DateRecrutement;
                txtEchlon.Text = agent.Echelon.ToString();
                foreach( var item in cbGrades.Items)
                {
                    if ((item as ComboboxItem).Value == agent.GradeID)
                        cbGrades.SelectedIndex = cbGrades.Items.IndexOf(item);
                }
                foreach (var item in cbFonctions.Items)
                {
                    if ((item as ComboboxItem).Value == agent.FonctionID)
                        cbFonctions.SelectedIndex = cbFonctions.Items.IndexOf(item);
                }
                foreach (var item in cbStructures.Items)
                {
                    if ((item as ComboboxItem).Value == agent.StructureAffectationID)
                        cbStructures.SelectedIndex = cbStructures.Items.IndexOf(item);
                }
            }
            catch (Exception)
            {
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                agent.Matricule = txtMatricule.Text;
                agent.Nom = txtNom.Text;
                agent.Prenom = txtPrenom.Text;
                agent.DateRecrutement = dtRecrutement.Value;
                agent.Echelon = Convert.ToInt32(txtEchlon.Text);

                if((cbFonctions.SelectedItem as ComboboxItem).Value!=0)
                agent.FonctionID =  (cbFonctions.SelectedItem as ComboboxItem).Value ;

                if ((cbFonctions.SelectedItem as ComboboxItem).Value != 0)
                agent.GradeID = (cbGrades.SelectedItem as ComboboxItem).Value;

                if ((cbFonctions.SelectedItem as ComboboxItem).Value != 0)
                agent.StructureAffectationID = (cbStructures.SelectedItem as ComboboxItem).Value;

                if (agent.ID == 0)
                    db.Agents.Add(agent);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
