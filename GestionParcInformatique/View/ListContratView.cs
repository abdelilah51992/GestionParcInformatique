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
    public partial class ListContratView : Form
    {
        AppContext db = new AppContext();
        public ListContratView()
        {
            InitializeComponent();
            try
            {
                dgListContrat.DataSource = db.Contrats.ToList();
            }
            catch (Exception)
            {
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                new ContratView().ShowDialog();
                dgListContrat.DataSource = db.Contrats.ToList();
            }
            catch (Exception)
            {
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
              try
                {
                    if (dgListContrat.SelectedRows.Count == 0)
                        MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        DataGridViewRow row = dgListContrat.SelectedRows[0];
                        new ContratView(Convert.ToInt32(row.Cells[0].Value)).ShowDialog();
                    dgListContrat.DataSource = null;
                    dgListContrat.DataSource = db.Contrats.ToList();
                    dgListContrat.Update();
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
                if (dgListContrat.SelectedRows.Count == 0)
                    MessageBox.Show("selectioner une ligne svp", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var response = MessageBox.Show("êtes-vous sûr de surppimer ce contrat ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgListContrat.SelectedRows[0];
                        var item = db.Contrats.Find(Convert.ToInt32(row.Cells[0].Value));
                        foreach (var mat in db.Materiels.Where(a => a.ContratID == item.ID).ToList())
                        {
                            mat.Contrat = null;
                            mat.ContratID = null;
                        }
                        db.SaveChanges();
                        db.Contrats.Remove(item);
                        db.SaveChanges();
                        dgListContrat.DataSource = null;
                        dgListContrat.DataSource = db.Contrats.ToList();
                        dgListContrat.Update();
                    }
                }


            }
            catch (Exception)
            {
            }
        }
    }
}
