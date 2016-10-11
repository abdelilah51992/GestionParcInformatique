using GestionParcInformatique.Model;
using GestionParcInformatique.View;
using GestionParcInformatique.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParcInformatique
{
    public partial class MainPage : Form
    {
        AppContext db =App.db;
        public MainPage()
        {
            InitializeComponent();
            try
            {
                DGPersonnels.DataSource = db.Agents.Select(a=> new AgentVM() { agent=a } ).ToList();
                dgMateriels.DataSource = db.Materiels.Select(m => new MaterielVM() { materiel = m }).ToList();
                DGPannes.DataSource = db.Pannes.Select(a => new PanneVM() { panne = a }).ToList();
            }
            catch (Exception)
            {
            }
        }

        private void parametreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paramèresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Personnels_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                new AgentView().ShowDialog();
                DGPersonnels.DataSource = db.Agents.Select(a => new AgentVM() { agent = a }).ToList();
            }
            catch (Exception)
            {
            }
        }

        private void Personnels_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGPersonnels.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DataGridViewRow row = DGPersonnels.SelectedRows[0];
                  
                    new AgentView(Convert.ToInt32(row.Cells[0].Value)).ShowDialog();
                    DGPersonnels.DataSource = null;
                    DGPersonnels.DataSource = db.Agents.Select(a => new AgentVM() { agent = a }).ToList();
                    DGPersonnels.Update();
                }

                //DGPersonnels.DataSource = db.Agents.ToList();
            }
            catch (Exception ex)
            {
            }
        }

        private void contratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new ListContratView().ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void btnMaterielAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                new EquipementView().ShowDialog();
                dgMateriels.DataSource = db.Materiels.Select(m => new MaterielVM() { materiel = m });
            }
            catch (Exception)
            {
            }
        }

        private void btnMaterielsModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMateriels.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DataGridViewRow row = dgMateriels.SelectedRows[0];

                    new EquipementView(Convert.ToInt32(row.Cells[0].Value)).ShowDialog();
                    dgMateriels.DataSource = null;
                    dgMateriels.DataSource = db.Materiels.Select(a => new MaterielVM() { materiel = a }).ToList();
                    dgMateriels.Update();
                }

                //DGPersonnels.DataSource = db.Agents.ToList();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnPannesAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                new PanneView().ShowDialog();
                DGPannes.DataSource = null;
                DGPannes.DataSource = db.Pannes.Select(a => new PanneVM() { panne = a }).ToList();
                DGPannes.Update();
            }
            catch (Exception)
            {
            }
        }

        private void btnInterventions_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGPannes.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DataGridViewRow row = DGPannes.SelectedRows[0];
                    new ListInterventions(Convert.ToInt32(row.Cells[0].Value)).ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPanneModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGPannes.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DataGridViewRow row = DGPannes.SelectedRows[0];
                    new PanneView(Convert.ToInt32(row.Cells[0].Value)).ShowDialog();
                    DGPannes.DataSource = null;
                    DGPannes.DataSource = db.Pannes.Select(a => new PanneVM() { panne = a }).ToList();
                    DGPannes.Update();
                }
               
            }
            catch (Exception)
            {
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMateriels.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var response = MessageBox.Show("êtes-vous sûr de surppimer ce materiel  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgMateriels.SelectedRows[0];
                        var item = db.Materiels.Find(Convert.ToInt32(row.Cells[0].Value));
                        foreach (var mat in db.Pannes.Where(a => a.MaterielID == item.ID).ToList())
                        {
                            mat.MaterielID = null;
                            mat.Materiel = null;
                        }
                        db.SaveChanges();
                        db.Materiels.Remove(item);
                        db.SaveChanges();
                        dgMateriels.DataSource = null;
                        dgMateriels.DataSource = db.Materiels.Select(a => new MaterielVM() { materiel = a }).ToList();
                        dgMateriels.Update();
                    }
                }


            }
            catch (Exception)
            {
            }
        }

        private void btnPannesSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGPannes.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var response = MessageBox.Show("êtes-vous sûr de surppimer cette panne  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes)
                    {
                        DataGridViewRow row = DGPannes.SelectedRows[0];
                        var item = db.Pannes.Find(Convert.ToInt32(row.Cells[0].Value));
                        foreach (var mat in db.Interventions.Where(a => a.PanneID == item.ID).ToList())
                        {
                            mat.PanneID = null;
                            mat.Panne = null;
                        }
                        db.SaveChanges();
                        db.Pannes.Remove(item);
                        db.SaveChanges();
                        DGPannes.DataSource = null;
                        DGPannes.DataSource = db.Pannes.Select(a => new PanneVM() { panne = a }).ToList();
                        DGPannes.Update();
                    }
                }


            }
            catch (Exception)
            {
            }
        }

        private void btnPersonnelsSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGPersonnels.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var response = MessageBox.Show("êtes-vous sûr de surppimer cette personne  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes)
                    {
                        DataGridViewRow row = DGPersonnels.SelectedRows[0];
                        var item = db.Agents.Find(Convert.ToInt32(row.Cells[0].Value));
                        db.Agents.Remove(item);
                        db.SaveChanges();
                        DGPersonnels.DataSource = null;
                        DGPersonnels.DataSource = db.Agents.Select(a => new AgentVM() { agent = a }).ToList();
                        DGPersonnels.Update();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
