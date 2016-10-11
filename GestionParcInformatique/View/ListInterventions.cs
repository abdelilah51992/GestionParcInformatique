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

namespace GestionParcInformatique.View
{
    public partial class ListInterventions : Form
    {
        private int panneID;
        AppContext db = App.db;

        public ListInterventions()
        {
            InitializeComponent();
        }

        public ListInterventions(int v)
        {
            try
            {
                this.panneID = v;
                InitializeComponent();
                DGInterventions.DataSource = db.Interventions.Where(a => a.PanneID == panneID).Select(a=> new InterventionVM() { inter=a } ).ToList();
            }
            catch (Exception)
            {
            }
            
        }

        private void btnPannesAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                new InterventionsView(panneID).ShowDialog();
                DGInterventions.DataSource = null;
                DGInterventions.DataSource = db.Interventions.Where(a => a.PanneID == panneID).Select(a => new InterventionVM() { inter = a }).ToList();
                DGInterventions.Update();
            }
            catch (Exception)
            {
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGInterventions.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DataGridViewRow row = DGInterventions.SelectedRows[0];
                    new InterventionsView(Convert.ToInt32(row.Cells[0].Value), null).ShowDialog();
                    DGInterventions.DataSource = null;
                    DGInterventions.DataSource = db.Interventions.Where(a => a.PanneID == panneID).Select(a => new InterventionVM() { inter = a }).ToList();
                    DGInterventions.Update();
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
                if (DGInterventions.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var response = MessageBox.Show("êtes-vous sûr de surppimer cette intervention ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes)
                    {
                        DataGridViewRow row = DGInterventions.SelectedRows[0];
                        db.Interventions.Remove(db.Interventions.Find(Convert.ToInt32(row.Cells[0].Value)));
                        db.SaveChanges();
                        DGInterventions.DataSource = null;
                        DGInterventions.DataSource = db.Interventions.Where(a => a.PanneID == panneID).Select(a => new InterventionVM() { inter = a }).ToList();
                        DGInterventions.Update();
                    }
                }


            }
            catch (Exception)
            {
            }
        }
    }
}
